﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ServerLocal.Model
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        public int PlaceID { get; set; }
        public int FloorID { get; set; }
        public string Owner { get; set; }
        public string LicensePlate { get; set; }
    }
}
