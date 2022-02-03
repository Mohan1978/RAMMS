﻿using System;
using System.Collections.Generic;

namespace RAMMS.MobileApps
{
    public partial class RmAllassetInventory
    {
        public RmAllassetInventory()
        {
            RmAllassetInvOthers = new HashSet<RmAllassetInvOthers>();
            RmAssetImageDtl = new HashSet<RmAssetImageDtl>();
        }

        public int AiPkRefNo { get; set; }
        public string AiAssetId { get; set; }
        public string AiDivCode { get; set; }
        public string AiDist { get; set; }
        public string AiRmuCode { get; set; }
        public string AiSecCode { get; set; }
        public string AiSecName { get; set; }
        public string AiRdCode { get; set; }
        public string AiRdName { get; set; }
        public string AiAssetGrpCode { get; set; }
        public string AiGrpType { get; set; }
        public string AiBound { get; set; }
        public string AiStrucCode { get; set; }
        public int? AiRefNo { get; set; }
        public string AiFeatureId { get; set; }
        public double? AiDiameter { get; set; }
        public double? AiWidth { get; set; }
        public double? AiHeight { get; set; }
        public string AiMaterial { get; set; }
        public double? AiFinRdLevel { get; set; }
        public double? AiCatchArea { get; set; }
        public double? AiSkew { get; set; }
        public double? AiDesignFlow { get; set; }
        public double? AiLength { get; set; }
        public string AiPrecastSitu { get; set; }
        public int? AiBarrelNo { get; set; }
        public double? AiIntelLevel { get; set; }
        public string AiIntelStruc { get; set; }
        public double? AiOutletLevel { get; set; }
        public string AiOutletStruc { get; set; }
        public string AiOwner { get; set; }
        public string AiMaintainedBy { get; set; }
        public double? AiGpsEasting { get; set; }
        public double? AiGpsNorthing { get; set; }
        public string AiRiverName { get; set; }
        public double? AiWidthLane { get; set; }
        public double? AiLengthSpan { get; set; }
        public string AiBridgeName { get; set; }
        public int? AiLaneCnt { get; set; }
        public int? AiSpanCnt { get; set; }
        public double? AiMedian { get; set; }
        public double? AiWalkway { get; set; }
        public string AiStrucSuper { get; set; }
        public string AiParapetType { get; set; }
        public string AiBearingType { get; set; }
        public string AiExpanType { get; set; }
        public string AiDeckType { get; set; }
        public string AiAbutType { get; set; }
        public string AiPierType { get; set; }
        public int? AiExpanJointCount { get; set; }
        public double? AiExpanJointSpace { get; set; }
        public string AiAbutFound { get; set; }
        public string AiPiersPrimComp { get; set; }
        public string AiBearingSeatDiaphg { get; set; }
        public string AiBeamsGridTrusArch { get; set; }
        public string AiDeckPavement { get; set; }
        public string AiUtilities { get; set; }
        public string AiWaterway { get; set; }
        public string AiWaterDownpipe { get; set; }
        public string AiParapetRailing { get; set; }
        public string AiSidewalksAppSlab { get; set; }
        public string AiExpanJoint { get; set; }
        public string AiSlopeRetainWall { get; set; }
        public int? AiBuiltYear { get; set; }
        public int? AiFrmCh { get; set; }
        public int? AiFrmChDeci { get; set; }
        public int? AiToCh { get; set; }
        public int? AiToChDeci { get; set; }
        public string AiLaneNo { get; set; }
        public double? AiPostSpacing { get; set; }
        public double? AiTier { get; set; }
        public double? AiBotWidth { get; set; }
        public string AiModBy { get; set; }
        public DateTime? AiModDt { get; set; }
        public string AiCrBy { get; set; }
        public DateTime? AiCrDt { get; set; }
        public bool AiSubmitSts { get; set; }
        public bool? AiActiveYn { get; set; }
        public int? AiLocChKm { get; set; }
        public int? AiLocChM { get; set; }

        public virtual ICollection<RmAllassetInvOthers> RmAllassetInvOthers { get; set; }
        public virtual ICollection<RmAssetImageDtl> RmAssetImageDtl { get; set; }
    }
}
