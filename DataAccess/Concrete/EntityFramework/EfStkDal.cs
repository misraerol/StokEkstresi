using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    //IStkDal özel durumlarda kullanılmak için var.
    public class EfStkDal : EfEntityRepositoryBase<Stk, TestContext>, IStkDal
    {
      

        public List<FormDto> GetForm()
        {

            using (var context = new TestContext())
            {
                var result = from k in context.STK
                             join i in context.STI
                             on k.MalKodu equals i.Malkodu
                             select new FormDto
                             {
                                 MalAdi = k.MalAdi,
                                 MalKodu = k.MalKodu,
                                 Tarih = i.Tarih
                             };
                return result.ToList();
            }
        }
    }
}
