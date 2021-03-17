using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VS_CRM.Services;
using VS_CRM.Models;

namespace VS_CRM.Controllers
{
    [ApiController]
    [Route("api/factoryComponents")]
    public class FactoryComponentsController : Controller
    {
        VS_CRM.Models.ASUPSQLContext db;
        public FactoryComponentsController(VS_CRM.Models.ASUPSQLContext context)
        {
            db = context;
            /*
            if (!db.Det1.Any())
            {
                db.Det1.Add(new Det1 { Name = "X", Company = "A", Price = 79900 });
                db.SaveChanges();
            }
            */
        }
        [HttpGet]
        public IEnumerable<Det1> Get()
        {
            return db.Det1.ToList();
        }

        [HttpGet("{articul}")]
        public Det1 Get(string articul)
        {
            Det1 product = db.Det1.FirstOrDefault(x => x.Articul == articul);
            return product;
        }

        [HttpPost]
        public IActionResult Post(Det1 factoryComponent)
        {
            if (ModelState.IsValid)
            {
                db.Det1.Add(factoryComponent);
                db.SaveChanges();
                return Ok(factoryComponent);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(Det1 factoryComponent)
        {
            if (ModelState.IsValid)
            {
                db.Update(factoryComponent);
                db.SaveChanges();
                return Ok(factoryComponent);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string articul)
        {
            Det1 factoryComponent = db.Det1.FirstOrDefault(x => x.Articul == articul);
            if (factoryComponent != null)
            {
                db.Det1.Remove(factoryComponent);
                db.SaveChanges();
            }
            return Ok(factoryComponent);
        }
    }
}