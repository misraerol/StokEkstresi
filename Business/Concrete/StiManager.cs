using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StiManager : IStiService
    {
        IStiDal _stiDal;

        public StiManager(IStiDal stiDal)
        {
            _stiDal = stiDal;
        }

        public List<Sti> GetAll()
        {

            return _stiDal.sıraNoList();
            
        }

    }
}
