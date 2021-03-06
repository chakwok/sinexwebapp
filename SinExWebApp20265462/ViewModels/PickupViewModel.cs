﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SinExWebApp20265462.Models;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SinExWebApp20265462.ViewModels
{
    public class PickupViewModel
    {
        public virtual Pickup Pickup { get; set; }

        public virtual int PickUpLocationID { get; set; }
        public virtual List<SelectListItem> PickUpLocations { get; set; }

        public virtual List<CheckBox> ShipmentCheckBoxes { get; set; } // User's shipments

        public virtual List<SelectListItem> Cities { get; set; }

        [Required]
        [Range(1,31)]
        public int PickupDay { get; set; }
        [Required]
        [Range(1, 12)]
        public int PickupMonth { get; set; }
        [Required]
        [Range(2000, 2020, ErrorMessage = "Please enter a valid year.")]
        public int PickupYear { get; set; }
        [Required]
        [Range(0, 23)]
        public int PickupHour { get; set; }
        [Required]
        [Range(0, 59)]
        public int PickupMinute { get; set; }
        
    }

    public class CheckBox
    {
        public CheckBox() { }
        public CheckBox(int _value, bool _checked) { Value = _value; Checked = _checked; }
        public int Value { get; set; }
        public bool Checked { get; set; }
    }
}