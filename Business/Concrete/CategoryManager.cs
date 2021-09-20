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
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
       
        //CRUD

        [ValidationAspect(typeof(CategoryValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Add(Category category)
        {
            IResult result = BusinessRules.Run(IsCategoryManagerExists(category.CategoryName));
            if (result != null)
            {
                return new ErrorDataResult<Category>(result.Message);
            }

            _categoryDal.Add(category);
            return new SuccessResult(ProductMessages.ProductAdded);
        }

        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(ProductMessages.ProductDeleted);
        }

        [ValidationAspect(typeof(CategoryValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(ProductMessages.ProductUpdated);
        }
        [CacheAspect]
        public IDataResult<List<Category>> GetAll()
        {
           List<Category> get= _categoryDal.GetAll();
            return new SuccessDataResult<List<Category>>(get,ProductMessages.ProductGetAll);
        }



        //Elave Metodlar----------------->

        
        private IResult IsCategoryManagerExists(string categoryName)
        {
            List<Category> getAllCategories = _categoryDal.GetAll();
            foreach (Category category in getAllCategories)
            {
                if (category.CategoryName.Equals(categoryName))
                {
                    return new ErrorResult(CategoryMessages.CategoryNameAvailable);
                }
            }
            return new SuccessResult();
        }
        
    }
}
