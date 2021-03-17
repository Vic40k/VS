using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VS_CRM.Data;
using VS_CRM.Model;
using VS_CRM.Models;

namespace VS_CRM.Controllers
{
    [ApiController]
    [Route("api/factoryComponents")]
    public class FactoryComponentsController : Controller
    {
        TestDBContext db;
        public FactoryComponentsController(TestDBContext context)
        {
            db = context;
            /*
            if (!db.Det1.Any())
            {
                //db.Det1.Add(new Det1 { Name = "X", Company = "A", Price = 79900 });
                //db.SaveChanges();
            }
            */

        }
        [HttpGet]
        public IEnumerable<FactoryComponents> Get()
        {
            var result = db.FactoryComponents.ToList();
            return result;
        }

        [HttpGet("{articul}")]
        public FactoryComponents Get(string articul)
        {
            FactoryComponents factoryComponent = db.FactoryComponents.FirstOrDefault(x => x.Articul == articul);
            return factoryComponent;
        }

        [HttpPost]
        public IActionResult Post(FactoryComponents factoryComponent)
        {
            if (ModelState.IsValid)
            {
                db.FactoryComponents.Add(factoryComponent);
                db.SaveChanges();
                return Ok(factoryComponent);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(FactoryComponents factoryComponent)
        {
            if (ModelState.IsValid)
            {
                db.Update(factoryComponent);
                db.SaveChanges();
                return Ok(factoryComponent);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{articul}")]
        public IActionResult Delete(string articul)
        {
            FactoryComponents factoryComponent = db.FactoryComponents.FirstOrDefault(x => x.Articul == articul);
            if (factoryComponent != null)
            {
                db.FactoryComponents.Remove(factoryComponent);
                db.SaveChanges();
            }
            return Ok(factoryComponent);
        }
    }
}