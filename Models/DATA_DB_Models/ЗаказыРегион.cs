using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗаказыРегион
    {
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public string Примечание { get; set; }
        public int UserId { get; set; }
        public bool Аннулирована { get; set; }
        public DateTime? Срок { get; set; }
        public double? Объем { get; set; }
        public int? Вес { get; set; }
        public DateTime? ДатаРеализации { get; set; }
        public int Регион { get; set; }
        public DateTime? ДатаОжидаемая { get; set; }
        public int Завод { get; set; }
        public int IdКлиента { get; set; }
        public string NSub { get; set; }
        public int Id { get; set; }
        public DateTime? ПринятоВПроизводство { get; set; }
        public int IdВалюты { get; set; }
        public int? ДилерКлиент { get; set; }
        public string AddedBy { get; set; }
        public int StatusId { get; set; }
        public string ShippingMethod { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Shipping { get; set; }
        public string ShippingFirstName { get; set; }
        public string ShippingLastName { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingCountry { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerFax { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string TransactionId { get; set; }
        public string TrackingId { get; set; }
        public int? IdСклада { get; set; }
        public int? IdФирмы { get; set; }
        public int? Филиал { get; set; }
        public int? IdФилиала { get; set; }
        public bool Двери { get; set; }
        public int StatusIdKat { get; set; }
        public int StatusIdKatB { get; set; }
        public string Ответственный { get; set; }
        public byte[] Файл { get; set; }
        public string Ext { get; set; }
        public DateTime? ДатаГруппировки { get; set; }
        public DateTime? ДатаЖелаемая { get; set; }
        public byte[] Техзадание { get; set; }
        public DateTime? ДатаКонтсруктора { get; set; }
        public string ExtТз { get; set; }
        public int UserIdБренд { get; set; }
        public int UserIdПроизв { get; set; }
        public string Маркировка { get; set; }
        public string ТипКонструкции { get; set; }
        public DateTime? ДатаКогдаПроставилоПроизводство { get; set; }
        public string КтоОтПроизводства { get; set; }
        public int? IdМашины { get; set; }
    }
}
