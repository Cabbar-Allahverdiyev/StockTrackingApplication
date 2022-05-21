using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MacAddressManager : IMacAddressService
    {
        IMacAddressDal _macAddressDal;

        public MacAddressManager(IMacAddressDal macAddressDal)
        {
            _macAddressDal = macAddressDal;
        }

        public IResult Add(MacAddres macAddress)
        {
            _macAddressDal.Add(macAddress);
            return new SuccessResult(MacAddressMessaeges.Added);
        }

        public IResult Delete(MacAddres macAddress)
        {
            _macAddressDal.Delete(macAddress);
            return new SuccessResult(MacAddressMessaeges.Deleted);
        }

        public IDataResult<List<MacAddres>> GetAll()
        {
            List<MacAddres> get = _macAddressDal.GetAll();
            return new SuccessDataResult<List<MacAddres>>(get, MacAddressMessaeges.GetAll);
        }

        public IDataResult<MacAddres> GetById(int id)
        {
             MacAddres  get=_macAddressDal.Get(m=>m.Id==id);
            if (get==null)
            {
                return new ErrorDataResult<MacAddres>(MacAddressMessaeges.NotFound);
            }
            return new SuccessDataResult<MacAddres>(get,MacAddressMessaeges.Found);
        }

        public IResult Update(MacAddres macAddress)
        {
            _macAddressDal.Update(macAddress);
            return new SuccessResult(MacAddressMessaeges.Updated);
        }
    }
}
