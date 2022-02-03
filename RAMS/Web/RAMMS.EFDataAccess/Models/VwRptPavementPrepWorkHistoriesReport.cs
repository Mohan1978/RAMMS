﻿using System;
using System.Collections.Generic;

namespace RAMMS.EFDataAccess.Models
{
    public partial class VwRptPavementPrepWorkHistoriesReport
    {
        public int? Year { get; set; }
        public string Road { get; set; }
        public string Bound { get; set; }
        public string RoadNo { get; set; }
        public string RecordId { get; set; }
        public double? Direction { get; set; }
        public double? Lane { get; set; }
        public double? StartKm { get; set; }
        public string ReviewDate { get; set; }
        public string MaintCode { get; set; }
        public string WorksDate { get; set; }
        public double? EndKm { get; set; }
        public double? Source { get; set; }
        public double? Quality { get; set; }
        public double? SurfaceClass { get; set; }
        public string Roughness { get; set; }
        public string Rutting { get; set; }
        public string LaneNo { get; set; }
    }
}
