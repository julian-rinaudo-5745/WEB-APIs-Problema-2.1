using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_APIs_Problema_2._1.Models;

namespace WEB_APIs_Problema_2._1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DateController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDate()
        {
            DateTime currentDate = DateTime.Now;
            DateModel date = new DateModel()
            {
                Number = currentDate.Day,
                DayOfWeek = currentDate.DayOfWeek.ToString(),
                Month = currentDate.Month,
                Year = currentDate.Year
            };
            return Ok(date);
        }
    }
}