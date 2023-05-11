﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace eSyaEnterprise_UI.Areas.Configure.Models
{
    public class DO_CurrencyDenominationInformation
    {
        public string CurrencyCode { get; set; }
        public string BnorCnId { get; set; }
        public decimal DenomId { get; set; }
        public string DenomDesc { get; set; }
        public decimal DenomConversion { get; set; }
        public int Sequence { get; set; }
        public DateTime EffectiveDate { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
