using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class STK : IEntity
    {
        public int Id { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
    }
}
