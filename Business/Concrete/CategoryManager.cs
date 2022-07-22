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
using System.Globalization;
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
            IResult result = BusinessRules.Run(IsCategoryNameExists(category.CategoryName)
                                             , CategoryNameToTitleCase(category));
            if (result != null)
            {
                return new ErrorResult(result.Message);
            }

            _categoryDal.Add(category);
            return new SuccessResult(CategoryMessages.CategoryAdded);
        }

        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Delete(Category category)
        {
            IResult result = BusinessRules.Run(IsCategoryIdNull(category));
            if (result != null)
            {
                return new ErrorResult(result.Message);
            }
            _categoryDal.Delete(category);
            return new SuccessResult(CategoryMessages.CategoryDeleted);
        }

        [ValidationAspect(typeof(UpdateCategoryValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Update(Category category)
        {
            IResult result = BusinessRules.Run(IsCategoryNameExistsForUpdate(category)
                                             , CategoryNameToTitleCase(category));
            if (result != null)
            {
                return new ErrorResult(result.Message);
            }
            _categoryDal.Update(category);
            return new SuccessResult(CategoryMessages.CategoryUpdated);
        }


        [CacheAspect]
        public IDataResult<List<Category>> GetAll()
        {
            List<Category> get = _categoryDal.GetAll();
            return new SuccessDataResult<List<Category>>(get, CategoryMessages.CategoryGetAll);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            Category get = _categoryDal.Get(c => c.Id == categoryId);
            if (get is null)
            {
                return new ErrorDataResult<Category>(CategoryMessages.CategoryNotFound);
            }
            return new SuccessDataResult<Category>(get, CategoryMessages.CategoryFound);
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

        private IResult CategoryNameToTitleCase(Category category)
        {
            category.CategoryName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(category.CategoryName);
            return new SuccessResult();
        }

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

        private IResult IsCategoryNameExistsForUpdate(Category category)
        {
            Category getCategory = _categoryDal.Get(c => c.CategoryName.ToLower() == category.CategoryName.ToLower());
            if (getCategory != null && getCategory.Id != category.Id)
            {
                return new ErrorResult(CategoryMessages.CategoryNameAvailable);
            }
            return new SuccessResult();
        }

        private IResult IsCategoryIdNull(Category category)
        {
            if (category.Id == 0)
            {
                return new ErrorResult(CategoryMessages.CategoryIdIsEmpty);
            }
            return new SuccessResult();
        }

    }

    
}
