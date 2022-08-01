using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Concrete
{
    public class FormSettingManager : IFormSettingService
    {
        IFormSettingDal _formSettingDal;

        private readonly string UsbBarCodeScannerFormTrackBarValues;

        public FormSettingManager(IFormSettingDal formSettingDal)
        {
            _formSettingDal = formSettingDal;
            UsbBarCodeScannerFormTrackBarValues = "UsbBarCodeScannerFormTrackBarValues";
        }

        [ValidationAspect(typeof(FormSettingValidator))]
        [CacheRemoveAspect("IFormSettingService.Get")]
        public IResult Add(FormSetting formSetting)
        {
            _formSettingDal.Add(formSetting);
            return new SuccessResult(FormSettingMessaeges.Added);
        }

        [CacheRemoveAspect("IFormSettingService.Get")]
        public IResult Delete(FormSetting formSetting)
        {
            _formSettingDal.Delete(formSetting);
            return new SuccessResult(FormSettingMessaeges.Deleted);
        }

        [CacheAspect]
        public IDataResult<List<FormSetting>> GetAll()
        {
            List<FormSetting> get = _formSettingDal.GetAll();
            return new SuccessDataResult<List<FormSetting>>(get, FormSettingMessaeges.GetAll);
        }

        [CacheAspect]
        public IDataResult<FormSetting> GetById(int id)
        {
            FormSetting get = _formSettingDal.Get(m => m.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<FormSetting>(MacAddressMessaeges.NotFound);
            }
            return new SuccessDataResult<FormSetting>(get, FormSettingMessaeges.Found);
        }

        [ValidationAspect(typeof(FormSettingValidator))]
        [CacheRemoveAspect("IFormSettingService.Get")]
        public IResult Update(FormSetting formSetting)
        {
            _formSettingDal.Update(formSetting);
            return new SuccessResult(FormSettingMessaeges.Updated);
        }

        [CacheAspect]
        public IDataResult<FormSetting> GetByName(string name)
        {
            FormSetting formSetting = _formSettingDal.Get(s => s.Name == name);
            if (formSetting==null)
            {
                return new ErrorDataResult<FormSetting>(FormSettingMessaeges.NotFound);
            }
            return new SuccessDataResult<FormSetting>(formSetting,FormSettingMessaeges.Found);  
        }

        public IDataResult<Size> GetUsbBarCodeScannerFormTrackBarValues()
        {
            FormSetting formSetting = _formSettingDal.Get(s => s.Name == UsbBarCodeScannerFormTrackBarValues);
            if (formSetting == null)
            {
                return new ErrorDataResult<Size>(FormSettingMessaeges.NotFound);
            }
            int width = Convert.ToInt32(formSetting.Value.Split(",")[0]);
            int height = Convert.ToInt32(formSetting.Value.Split(",")[1]);
            return new SuccessDataResult<Size>(new Size() { Width=width,Height=height},
                                               FormSettingMessaeges.Found);
        }

        public IResult UpdateUsbBarCodeScannerFormTrackBarValues(int width,int height)
        {
            string values = string.Join(',', width.ToString(), height.ToString());
            FormSetting formSetting = _formSettingDal.Get(s => s.Name == UsbBarCodeScannerFormTrackBarValues);
            formSetting.Value = values;
            IResult result = this.Update(formSetting);
            if (result.Success)
            {
                return new SuccessResult(result.Message);
            }
            return new ErrorResult(result.Message);
        }
    }
}
