using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDal _supplierDal;
        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        //CRUD
        [ValidationAspect(typeof(SupplierValidator))]
        [CacheRemoveAspect("ISupplierService.Get")]
        public IResult Add(Supplier supplier)
        {
            IResult rules = BusinessRules.Run(this.IsSupplierExistsByCompanyNameAndContactName(supplier),
                                              this.SupplierToTitleCase(supplier));
            if (rules != null)
            {
                return new ErrorResult(rules.Message);
            }
            _supplierDal.Add(supplier);
            return new SuccessResult(SupplierMessages.SupplierAdded);
        }

        [CacheRemoveAspect("ISupplierService.Get")]
        public IResult Delete(Supplier supplier)
        {
            IResult rules = BusinessRules.Run(this.GetById(supplier.Id));
            if (rules != null)
            {
                return new ErrorResult(rules.Message);
            }
            _supplierDal.Delete(supplier);
            return new SuccessResult(SupplierMessages.SupplierDeleted);
        }

        [ValidationAspect(typeof(SupplierValidator))]
        [CacheRemoveAspect("ISupplierService.Get")]
        public IResult Update(Supplier supplier)
        {
            IResult rules = BusinessRules.Run(this.GetById(supplier.Id),
                                              this.SupplierToTitleCase(supplier));
            if (rules != null)
            {
                return new ErrorResult(rules.Message);
            }
            _supplierDal.Update(supplier);
            return new SuccessResult(SupplierMessages.SupplierUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Supplier>> GetAll()
        {
            List<Supplier> get = _supplierDal.GetAll()
                .OrderBy(s => s.CompanyName).ToList();
            return new SuccessDataResult<List<Supplier>>(get, SupplierMessages.SupplierGetAll);
        }

        public IDataResult<Supplier> GetById(int id)
        {
            Supplier get = _supplierDal.Get(s => s.Id == id);
            if (get is null)
            {
                return new ErrorDataResult<Supplier>(SupplierMessages.SupplierNotFound);
            }
            return new SuccessDataResult<Supplier>(get, SupplierMessages.SupplierFound);
        }

        public IDataResult<List<Supplier>> GetAllByCompanyName(string companyName)
        {
            List<Supplier> get = _supplierDal.GetAll(s => s.CompanyName.ToLower() == companyName.ToLower(new CultureInfo("en-Us", false)));
            if (get.Count == 0)
            {
                return new ErrorDataResult<List<Supplier>>(SupplierMessages.CompanyNameNotFound(companyName));
            }
            return new SuccessDataResult<List<Supplier>>(get, SupplierMessages.GetAllByCompanyName(companyName));
        }

        public IDataResult<List<Supplier>> GetAllByContactName(string contactName)
        {
            List<Supplier> get = _supplierDal.GetAll(s => s.ContactName.ToLower() == contactName.ToLower(new CultureInfo("en-Us", false)));
            if (get.Count == 0)
            {
                return new ErrorDataResult<List<Supplier>>(SupplierMessages.ContactNameNotFound(contactName));
            }
            return new SuccessDataResult<List<Supplier>>(get, SupplierMessages.GetAllByContactName(contactName));
        }

        //Business rules-------------------->
        private IResult IsSupplierExistsByCompanyNameAndContactName(Supplier supplier)
        {
            Supplier getSupplier = _supplierDal.Get(s => s.ContactName.ToLower() == supplier.ContactName.ToLower(new CultureInfo("en-Us", false))
                                                    & s.CompanyName.ToLower() == supplier.CompanyName.ToLower(new CultureInfo("en-Us", false)));
            if (getSupplier != null)
            {
                return new ErrorResult(SupplierMessages.AlreadyExistsCompanyNameAndContactName(supplier));
            }
            return new SuccessResult();

        }

        private IResult SupplierToTitleCase(Supplier supplier)
        {
            supplier.ContactName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(supplier.ContactName);
            supplier.CompanyName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(supplier.CompanyName);
            supplier.City = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(supplier.City);
            return new SuccessResult();
        }

    }
}
