﻿using System;
using System.Collections.Generic;

namespace RAMMS.EFDataAccess.Models
{
    public partial class RmScheduleDetail
    {
        public string MainGroupAttributeName { get; set; }
        public string MainGroupAttributeType { get; set; }
        public string MainGroupAttributeCode { get; set; }
        public string SubGroupAttributeName { get; set; }
        public string SubGroupAttributeCode { get; set; }
        public string SubGroupAttributeType { get; set; }
        public string SubComponentAttributeName { get; set; }
        public string SubComponentAttributeType { get; set; }
        public string SubComponentAttributeCode { get; set; }
        public string MainComponentAttributeName { get; set; }
        public string MainComponentAttributeCode { get; set; }
        public string MainComponentAttributeType { get; set; }
        public string CompanyName { get; set; }
        public string SectionCode { get; set; }
        public string SectionName { get; set; }
        public string AssetId { get; set; }
        public string RmFormName { get; set; }
        public string RmFormCode { get; set; }
        public string RmFormCategoryName { get; set; }
        public int? RmFormCategoryPk { get; set; }
        public DateTime? RescheduleStartDateTime { get; set; }
        public DateTime? RescheduleEndDateTime { get; set; }
        public int Pk { get; set; }
        public string PlanningType { get; set; }
        public string Task { get; set; }
        public DateTime? ScheduleStartDateTime { get; set; }
        public DateTime? ScheduleEndDateTime { get; set; }
        public string DescriptionOfWork { get; set; }
        public string Category { get; set; }
        public int? RmFormPk { get; set; }
        public int? AssetPk { get; set; }
        public int? GroupStructurePk { get; set; }
        public string AssetName { get; set; }
        public int? FeaturePk { get; set; }
        public int SectionPk { get; set; }
        public double? ChainageStartKm { get; set; }
        public double? ChainageEndKm { get; set; }
        public string Location { get; set; }
        public int? ContractorPk { get; set; }
        public string ContractorRemark { get; set; }
        public string Status { get; set; }
        public string ReviewBy { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string ReviewRemark { get; set; }
        public string Remark { get; set; }
        public int? RescheduleFromRmSchedulePk { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? InspectionStartDate { get; set; }
        public DateTime? InspectionEndDate { get; set; }
        public string InspectedBy { get; set; }
        public double? InspectionLat { get; set; }
        public double? InspectionLng { get; set; }
        public DateTime? ResultUploadedDate { get; set; }
        public string ResultUploadedBy { get; set; }
        public string Bound { get; set; }
        public string RescheduleReason { get; set; }
        public string ResultModifiedBy { get; set; }
        public DateTime? ResultModifiedDate { get; set; }
    }
}
