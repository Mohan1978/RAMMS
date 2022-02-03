﻿using System;
using System.Collections.Generic;

namespace RAMMS.EFDataAccess.Models
{
    public partial class InvLandscape
    {
        public int Pk { get; set; }
        public string RampId { get; set; }
        public string AssetName { get; set; }
        public string AssetLocation { get; set; }
        public string ZoneCode { get; set; }
        public string SoftLandscaping { get; set; }
        public string HardLandscaping { get; set; }
        public string AssetNumbering { get; set; }
        public string AssetType { get; set; }
        public int? AssetQty { get; set; }
        public double? AssetDiameter { get; set; }
        public double? AssetSize { get; set; }
        public string Aging { get; set; }
        public string DrawingNo { get; set; }
        public string DrawingTitle { get; set; }
        public string DrawingFile { get; set; }
        public string ContractorVendorNo { get; set; }
        public string ContractorCompanyName { get; set; }
        public string ContractorRegNo { get; set; }
        public string ContractorRptno { get; set; }
        public string ConsultantVendorNo { get; set; }
        public string ConsultantCompanyName { get; set; }
        public string ConsultantRegNo { get; set; }
        public string ConsultantRptno { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
