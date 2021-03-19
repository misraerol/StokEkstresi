using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IStkService
    {
        List<Stk> GetBytext(string text);
        List<FormDto> GetForms();
    }
}
