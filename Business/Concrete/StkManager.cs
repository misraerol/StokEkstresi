using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StkManager : IStkService
    {
        IStkDal _stkDal;

        public StkManager(IStkDal stkDal)
        {
            _stkDal = stkDal;
        }

        public List<Stk> GetBytext(string text)
        {
            return _stkDal.GetAll(s=> s.MalAdi==text || s.MalKodu==text);
        }

        public List<FormDto> GetForms()
        {
            return _stkDal.GetForm();
        }
    }
}
