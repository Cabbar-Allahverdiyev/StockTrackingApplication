using Business.Constants.Messages;
using Core.DataAccess;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Business.Utilites.BusinessRuleMethods
{
    public static class BusinessRuleForIEnttityRepository<TEntity> where TEntity : class, new()
    {
        //Mesajlari tekmillesdir ve update ucun metod yaz Qeyd hele istifade olunmur
        public static IResult IsNameExists(IEntityRepository<TEntity> dal
                                            , Expression<Func<TEntity, bool>> filter)
           
        {
            TEntity entity = dal.Get(filter);
            if (entity != null)
            {
                //string lambdaParam = GetParametsLambda(filter);
                
                return new ErrorResult(BrandMessages.AlreadyExistsName);
            }
            return new SuccessResult();

        }

        public static IResult IsNameExistsForUpdate(IEntityRepository<TEntity> dal
                                            , Expression<Func<TEntity, bool>> filter)

        {
            TEntity entity = dal.Get(filter);
            if (entity != null)
            {
                //string lambdaParam = GetParametsLambda(filter);

                return new ErrorResult(BrandMessages.AlreadyExistsName);
            }
            return new SuccessResult();

        }

        private static string GetParametsLambda(Expression<Func<TEntity, bool>> filter)
        {
            string lambda= "";
            MemberExpression node=(MemberExpression)filter.Body;
            var c = node.Expression as ConstantExpression;
            if (c != null)
            {
                Type t = c.Value.GetType();
                lambda = t.InvokeMember(node.Member.Name, BindingFlags.GetField,
                                   null, c.Value, null).ToString();
            }



           // string lambda = filter.ToString();// = memberExpression.Member.ToString();
            //for (int i = 0; i < lambda.Length; i++)
            //{
            //    if ($"{lambda[i]}{lambda[i + 1]}" =="==")
            //    {
            //        int index = i + 1;
            //        lambda = lambda.Substring(index);
            //        return lambda;
            //    }
            //}
            return lambda;
        }
    }
}
