﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccommodationManagerApp.Model {
    [Table("rooms")]
    public class Room {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public int? BuildingId { get; set; }
        [ForeignKey("BuildingId")]
        public Building Building { get; set; }
        [EnumDataType(typeof(RoomStatus))]
        public RoomStatus Status { get; set; } = RoomStatus.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Room() 
        {
        }
        
        public Room(string roomNumber, int? buildingId, Building building, RoomStatus status) {
            RoomNumber = roomNumber;
            BuildingId = buildingId;
            Building = building;
            Status = status;
        }
    }
}