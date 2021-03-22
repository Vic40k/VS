using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VS_CRM.Data;
using VS_CRM.Model;
using VS_CRM.Models;
using VS_CRM.Models.DATA_DB_Model;

namespace VS_CRM.Controllers
{
    [ApiController]
    [Route("api/infoScreens")]
    public class InformationScreensController : Controller
    {
        DATAContext dbDATA;
        public InformationScreensController(DATAContext context)
        {
            dbDATA = context;
        }
        [HttpGet]
        public IEnumerable<ЗаказыРегион> GetStorageInfo()
        {
            try
            {
                var result = dbDATA.ЗаказыРегион.ToList();
                return result;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }
    }
}
