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

        public IResult Add(MacAddress macAddress)
        {
            _macAddressDal.Add(macAddress);
            return new SuccessResult(MacAddressMessaeges.Added);
        }

        public IResult Delete(MacAddress macAddress)
        {
            _macAddressDal.Delete(macAddress);
            return new SuccessResult(MacAddressMessaeges.Deleted);
        }

        public IDataResult<List<MacAddress>> GetAll()
        {
            List<MacAddress> get = _macAddressDal.GetAll();
            return new SuccessDataResult<List<MacAddress>>(get, MacAddressMessaeges.GetAll);
        }

        public IDataResult<MacAddress> GetById(int id)
        {
             MacAddress  get=_macAddressDal.Get(m=>m.Id==id);
            if (get==null)
            {
                return new ErrorDataResult<MacAddress>(MacAddressMessaeges.NotFound);
            }
            return new SuccessDataResult<MacAddress>(get,MacAddressMessaeges.Found);
        }

        public IResult Update(MacAddress macAddress)
        {
            _macAddressDal.Update(macAddress);
            return new SuccessResult(MacAddressMessaeges.Updated);
        }
    }
}
