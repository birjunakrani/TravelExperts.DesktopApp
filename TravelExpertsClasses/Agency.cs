﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClasses
{
    public class Agency
    {
        /**
        * Threaded project 2 
        * Purpose: Agent object to store agent data from database
        * **/
        public Agency() { } 

        public int AgencyID { get; set; }
        public string AgencyAddress { get; set; }
        public string AgencyCity { get; set; }
        public string AgencyProv { get; set; }
        public string AgencyPostal { get; set; }
        public string AgencyCountry { get; set; }
        public string AgencyPhone { get; set; }
        public string AgencyFax { get; set; }
    }
}
