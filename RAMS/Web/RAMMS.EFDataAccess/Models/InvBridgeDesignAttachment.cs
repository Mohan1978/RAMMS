﻿using System;
using System.Collections.Generic;

namespace RAMMS.EFDataAccess.Models
{
    public partial class InvBridgeDesignAttachment
    {
        public int InvBridgeDesignPk { get; set; }
        public int RecordIndex { get; set; }
        public string AttachmentFileName { get; set; }
        public string AttachmentRemarks { get; set; }
    }
}
