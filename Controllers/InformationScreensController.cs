﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Web.Administration;
using VS_CRM.Data;
using VS_CRM.Model;
using VS_CRM.Models;
using VS_CRM.Models.DATA_DB_Model;

namespace VS_CRM.Controllers
{
    [ApiController]
    [Route("api/info-screens")]
    public class InformationScreensController : Controller
    {
        DATAContext dbDATA;
        public InformationScreensController(DATAContext context)
        {
            dbDATA = context;
        }

        [HttpGet]
        [Route("getWarehouseInfoEF")]
        public IEnumerable<InformationScreenViewModel> GetWarehouseInfoEF()
        {
            // TODO async
            var orderList = new List<InformationScreenViewModel>();
            var arrivalList = new List<InformationScreenViewModel>();
            var procedureList = new List<InformationScreenViewModel>();
            var startDate = DateTime.Now.AddMonths(-3).Date.Add(new TimeSpan(0, 0, 0));

            orderList = (from zak in dbDATA.ЗаказыРегион
                         join reg in dbDATA.ТоварВЗаказеРегион on new { CustomerNumber = zak.Номер, Region = zak.Регион } equals new { CustomerNumber = reg.НомерПокупателя, Region = reg.Регион }
                         join nom in dbDATA.НоменклатураТоваров on reg.IdТовара equals nom.IdТовара
                         join grp in dbDATA.СписокПодгрупп on nom.IdПодгруппы equals grp.IdПодгруппы
                         where zak.Дата > startDate
                         && zak.Завод == 44
                         && zak.NSub != null
                         && zak.Регион != 1603
                         && zak.ДатаКогдаПроставилоПроизводство != null
                         && zak.ДатаКогдаПроставилоПроизводство != null
                         && grp.IdГруппы == 99
                         && zak.Регион == reg.Регион
                         //group zak.Номер, zak.ДатаОжидаемая, zak.ДатаКогдаПроставилоПроизводство, reg.IdТовара into zakg
                         // let a = t.L != null ? t.L : t.A
                         select new InformationScreenViewModel
                         {
                             Order = zak.Номер,
                             Region = zak.Регион,
                             Orderquantity = (decimal?)reg.Количество,
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

            arrivalList = (from zak in orderList
                           join arr in dbDATA.ПриходТовараРегион on zak.Order equals arr.НомерЗаказа
                           select new InformationScreenViewModel
                           {
                               Order = zak.Order,
                               Region = zak.Region,
                               /*
                               A.IDgoods,
                               SUM(B.Количество) AS KolIzgot,
                               MAX(B.[Дата прихода]) AS DateSklad
                               */
                           }).ToList();
            return orderList;
        }

        [HttpGet]
        [Route("getWarehouseInfo")]
        public IEnumerable<InformationScreenViewModel> GetWarehouseInfo()
        {
            // TODO async
            var procedureList = new List<InformationScreenViewModel>();

            using (SqlConnection DBConection = (SqlConnection)dbDATA.Database.GetDbConnection())
            {
                SqlCommand sqcmd = new SqlCommand("ASUPSQL.dbo.[sp_ASUPTablo]", DBConection);
                sqcmd.CommandType = CommandType.StoredProcedure;
                sqcmd.Parameters.Add("IdIzgot", SqlDbType.Int).Value = 44;
                sqcmd.Parameters.Add("IdSubGroup", SqlDbType.Int).Value = 0;
                sqcmd.Parameters.Add("IdGroup", SqlDbType.Int).Value = 99;
                DBConection.Open();
                var reader = sqcmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // var name = reader.GetName(11);
                        // var type = reader.GetProviderSpecificFieldType(11);
                        procedureList.Add(new InformationScreenViewModel
                        {
                            Order = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            Region = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                            Orderquantity = reader.IsDBNull(2) ? (decimal?)null : reader.GetDecimal(2),
                            OrderDate = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3),
                            ProducedQuantity = reader.IsDBNull(4) ? (decimal?)null : reader.GetDecimal(4),
                            WarehouseDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                            ShipmentQuantity = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                            ShipmentDate = reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7),
                            StatusId = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                            Status = reader.IsDBNull(9) ? "" : reader.GetString(9),
                            Client = reader.IsDBNull(10) ? "" : reader.GetString(10),
                            Comment = reader.IsDBNull(11) ? "" : reader.GetString(11),
                            DelayDate = reader.IsDBNull(12) ? (DateTime?)null : reader.GetDateTime(12),                            
                        });
                    }
                }
                reader.Close();
                DBConection.Close();
            }

            return procedureList;
        }
    }
}
