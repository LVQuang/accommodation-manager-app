﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model
{
    [Table("bills")]
    public class Bill
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ElecQuantity { get; set; } = 0;
        public int WaterQuantity { get; set; } = 0;
        public int ElecFee { get; set; } = 0;
        public int WaterFee { get; set; } = 0;
        public int InternetFee { get; set; } = 0;
        [EnumDataType(typeof(BillStatus))] public BillStatus Status { get; set; } = BillStatus.Edit;
        public int? ContractId { get; set; }
        [ForeignKey("ContractId")] public Contract Contract { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")] public User User { get; set; }
        // Date
        [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedAtFormatted => CreatedAt.ToString("dd/MM/yyyy");

        public Bill() { }

        public Bill(int? userId,int contractId, DateTime createdAt)
        {
            ContractId = contractId;
            CreatedAt = createdAt;
            UserId = userId;
        }
    }
    public enum BillStatus
    {
        Edit,
        Unpaid,
        Paid
    }
}
