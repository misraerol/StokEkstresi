using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SKI : IEntity
    {
        public int Id { get; set; }
        public short IslemTur { get; set; }
        public string EvrakNo { get; set; }
        public int Tarih { get; set; }
        public string Malkodu { get; set; }
        public decimal Miktar { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Tutar { get; set; }
        public string Birim { get; set; }
    }
}
