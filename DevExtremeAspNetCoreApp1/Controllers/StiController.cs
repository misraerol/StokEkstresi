using Business.Abstract;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StiController : ControllerBase
    {
        IStiService _stiService;
        public StiController(IStiService stiService)
        {
            _stiService = stiService;
        }
        [HttpGet("Get")]
        public IActionResult GetAll()
        {
            decimal stok = 0;
            var result = _stiService.GetAll();
            foreach (var sti in result)
            { //context.STI.GroupBy(s => s.Id)

                if (sti.IslemTur == 0)
                {
                    string giris = "giriş";
                    return Ok(giris);
                }
                else
                {
                    return Ok("cıkış");
                }

                // DateTime ExpiryDate = DateTime.ParseExact((sti.Tarih).ToString(), "dd mmm yy", null);
                // Console.WriteLine(sti.EvrakNo + "--->" + sti.Tarih);
                if (sti.IslemTur == 0 & sti.Miktar != 0)
                {
                    return Ok(sti.Tutar);

                }
                if (sti.IslemTur == 1 & sti.Miktar != 0)
                {
                    return Ok(sti.Fiyat);

                }

                if (sti.IslemTur == 0)
                {
                    stok += sti.Miktar;
                }
                else
                {
                    stok -= sti.Miktar;
                }
                return Ok(stok);

            }
            return Ok(result);
            
        }
    }
}
