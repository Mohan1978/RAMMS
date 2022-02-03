﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RAMMS.DTO
{
    public class FormDSearchGridDTO
    {
        public string Reference_No { get; set; }
        public string RMU { get; set; }
        public int? Month { get; set; }

        public string WeekNo { get; set; }
        public string Road_Code { get; set; }

        public string Bydate { get; set; }

        public string WeekDay { get; set; }

        public string RoadName { get; set; }
        public string Asset_Type { get; set; }
        public string Asset_GroupCode { get; set; }
        public string Owner { get; set; }
        public string Verified_By { get; set; }
        public string Section { get; set; }
        public int? ChinageFromKm { get; set; }
        public int? ChinageToKm { get; set; }
        public int? ChinageFromM { get; set; }
        public int? ChinageToM { get; set; }
        public int? Year { get; set; }        
        public string SmartInputValue { get; set; }
        public string sortOrder { get; set; }
        public string currentFilter { get; set; }
        public string searchString { get; set; }
        public int? Page_No { get; set; }
        public int? pageSize { get; set; }
    }
}
