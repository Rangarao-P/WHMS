//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WHMS_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InLedgerLocation
    {
        public int InLedgerId { get; set; }
        public int LedgerId { get; set; }
        public int LocationId { get; set; }
    
        public virtual InLedger InLedger { get; set; }
        public virtual Location Location { get; set; }
    }
}
