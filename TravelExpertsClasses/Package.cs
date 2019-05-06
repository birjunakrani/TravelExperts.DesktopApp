﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Purpose: To perform CRUD operation on packages offered by company and reflect that in the database
///<summary>


namespace TravelExpertsClasses
{
    public class Package
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; } //allows null
        public DateTime? PkgEndDate { get; set; } //allows null
        public string PkgDesc { get; set; } //allows null 
        public double PkgBasePrice { get; set; }
        public double? PkgAgencyCommission { get; set; } //allows null

     
    }
}
