using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StiManager stiManager = new StiManager(new EfStiDal());
            var result = stiManager.GetAll();
            foreach (var sti in result)
            {
                Console.WriteLine(sti.Id + "--" + Islemturu(sti.IslemTur) + "--" + sti.EvrakNo + "--" + sti.Tarih + "--" +
                    Girismiktarı(sti.IslemTur, sti.Miktar, sti.Tutar) + "--" + CıkısMiktarı(sti.IslemTur, sti.Miktar, sti.Fiyat) + "--" + StokMiktarı(sti.IslemTur, sti.Miktar));

            }
        }
  

        private static string Islemturu(int IslemTur)
        {
            if (IslemTur == 0)
            {
                string giris = (IslemTur).ToString();
                return giris = "giriş";
            }
            else
            {
                string cıkıs = (IslemTur).ToString();
                return cıkıs = "çıkış";
            }
        }
        private static decimal StokMiktarı(int IslemTur, decimal Miktar)
        {
            decimal stok = 0;
            if (IslemTur == 0)
            {
                stok += Miktar;
            }
            else
            {
                stok -= Miktar;
            }
            return stok;
        }
        private static decimal Girismiktarı(int IslemTur, decimal Miktar,decimal tutar)
        {
            if (IslemTur == 0 & Miktar != 0)
            {
                decimal girismiktarı = tutar;
                
            }
            return tutar;
        }
        private static decimal CıkısMiktarı(int IslemTur, decimal Miktar, decimal fiyat)
        {
            if (IslemTur == 1 & Miktar != 0)
            {
                decimal cıkısmiktarı = fiyat;

            }
            return fiyat;
        }
    }
}
