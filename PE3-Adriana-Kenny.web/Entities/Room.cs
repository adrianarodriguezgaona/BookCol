﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Entities
{
    public class Room : BaseEntity <long>
    {     
       
        public long HotelId { get; set; }
        
        public long RoomTypeId { get; set; }

        [Required]
        [MaxLength(350)]
        public string Description { get; set; }
        
        [Required]
        public decimal PriceNight { get; set; }

        public Hotel Hotel { get; set; }        
        public Roomtype Roomtype { get; set; }
        public List<Booking>Bookings { get; set; }
    }
}
