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
        public IEnumerable<InformationScreenViewModel> GetWarehouseInfo()
        {
            // TODO async
            var infoScreensWarehouseData = new List<InformationScreenViewModel>();
            var startDate = DateTime.Now.AddMonths(-3).Date.Add(new TimeSpan(0,0,0)); 

            infoScreensWarehouseData = (from zak in dbDATA.ЗаказыРегион
                                        join reg in dbDATA.ТоварВЗаказеРегион on zak.Номер equals reg.НомерПокупателя
                                        join nom in dbDATA.НоменклатураТоваров on reg.IdТовара equals nom.IdТовара
                                        join grp in dbDATA.СписокПодгрупп on nom.IdПодгруппы equals grp.IdПодгруппы
                                        where zak.Завод == 44 
                                        && zak.ДатаКогдаПроставилоПроизводство != null
                                        && zak.Дата > startDate
                                        && zak.NSub != null
                                        && zak.Регион != 1603
                                        && zak.ДатаКогдаПроставилоПроизводство != null
                                        && grp.IdГруппы == 99
                                        && zak.Регион == reg.Регион
                                        //group zak.Номер, zak.ДатаОжидаемая, zak.ДатаКогдаПроставилоПроизводство, reg.IdТовара into zakg
                                        // let a = t.L != null ? t.L : t.A
                                        select new InformationScreenViewModel
                                        {
                                            Order = zak.Номер,
                                            Region = zak.Регион,
                                            Orderquantity = reg.Количество,
                                            OrderDate = zak.ДатаОжидаемая,
                                            ProducedQuantity = 0,
                                            WarehouseDate = (DateTime?)null,
                                            ShipmentQuantity = 0,
                                            ShipmentDate = (DateTime?)null,
                                            StatusId = 0,
                                            Status = null,
                                            /*
                                            public string Client { get; set; }
                                            public int Reason { get; set; }
                                            public string Coment { get; set; }
                                            public DateTime DelayDate { get; set; }
                                                                                    */
                                        }).ToList();
            return infoScreensWarehouseData;
        }
    }
}
