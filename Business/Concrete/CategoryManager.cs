using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation.CategoryValidators;
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

        [ValidationAspect(typeof(CreateCategoryValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Add(Category category)
        {
            IResult result = BusinessRules.Run(IsCategoryNameExists(category.CategoryName));
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

        [ValidationAspect(typeof(UpdateCategoryValidator))]
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

        public IDataResult<Category> GetById(int categoryId)
        {
            Category get = _categoryDal.Get(c => c.Id == categoryId);
            if (get is null)
            {
                return new ErrorDataResult<Category>(CategoryMessages.CategoryNotFound);
            }
            return new SuccessDataResult<Category>(get,CategoryMessages.CategoryFound);
        }

        public IDataResult<Category> GetByName(string categoryName)
        {
            Category get = _categoryDal.Get(c => c.CategoryName == categoryName);
            if (get is null)
            {
                return new ErrorDataResult<Category>(CategoryMessages.CategoryNotFound);
            }
            return new SuccessDataResult<Category>(get, CategoryMessages.CategoryFound);
        }



        //Elave Metodlar----------------->

        
        private IResult IsCategoryNameExists(string categoryName)
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
