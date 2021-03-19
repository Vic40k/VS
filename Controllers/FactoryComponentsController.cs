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
    [Route("api/factoryComponents")]
    public class FactoryComponentsController : Controller
    {
        TestDBContext dbTestDB;
        //DATAContext dbDATA;
        public FactoryComponentsController(TestDBContext context)
        {
            dbTestDB = context;
            /*
            if (!dbTestDB.Det1.Any())
            {
                //dbTestDB.Det1.Add(new Det1 { Name = "X", Company = "A", Price = 79900 });
                //dbTestDB.SaveChanges();
            }
            */

        }
        [HttpGet]
        public IEnumerable<FactoryComponents> Get()
        {
            var result = dbTestDB.FactoryComponents.ToList();
            return result;
        }

        [HttpGet("{articul}")]
        public FactoryComponents Get(string articul)
        {
            FactoryComponents factoryComponent = dbTestDB.FactoryComponents.FirstOrDefault(x => x.Articul == articul);
            return factoryComponent;
        }

        [HttpPost]
        public IActionResult Post(FactoryComponents factoryComponent)
        {
            if (ModelState.IsValid)
            {
                dbTestDB.FactoryComponents.Add(factoryComponent);
                dbTestDB.SaveChanges();
                return Ok(factoryComponent);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(FactoryComponents factoryComponent)
        {
            if (ModelState.IsValid)
            {
                dbTestDB.Update(factoryComponent);
                dbTestDB.SaveChanges();
                return Ok(factoryComponent);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{articul}")]
        public IActionResult Delete(string articul)
        {
            FactoryComponents factoryComponent = dbTestDB.FactoryComponents.FirstOrDefault(x => x.Articul == articul);
            if (factoryComponent != null)
            {
                dbTestDB.FactoryComponents.Remove(factoryComponent);
                dbTestDB.SaveChanges();
            }
            return Ok(factoryComponent);
        }
    }
}