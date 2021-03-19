using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStiDal : EfEntityRepositoryBase<Sti, TestContext>, IStiDal
    {
        public List<Sti> sıraNoList()
        {
            using (TestContext context = new TestContext())
            {
                var result = from s in context.STI
                             orderby s.Id
                             select s;

                return result.ToList();
            }
        }
    }
}
