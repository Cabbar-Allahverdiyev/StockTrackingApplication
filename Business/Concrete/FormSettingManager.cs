using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FormSettingManager : IFormSettingService
    {
        IFormSettingDal _formSettingDal;

        public FormSettingManager(IFormSettingDal formSettingDal)
        {
            _formSettingDal = formSettingDal;
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
    }
}
