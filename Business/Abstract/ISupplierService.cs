using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        IDataResult<List<Supplier>> GetAll();
        IResult Add(Supplier supplier); 
        IResult Update(Supplier supplier );
        IResult Delete(Supplier supplier );

        IDataResult<Supplier> GetById(int id);
        IDataResult<List<Supplier>> GetAllByCompanyName(string companyName);
        IDataResult<List<Supplier>> GetAllByContactName(string contactName);
    }
}
