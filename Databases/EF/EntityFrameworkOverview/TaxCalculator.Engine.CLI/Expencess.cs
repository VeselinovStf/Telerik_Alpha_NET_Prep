//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxCalculator.Engine.CLI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expencess
    {
        public int id { get; set; }
        public Nullable<decimal> FlatTax { get; set; }
        public Nullable<decimal> Electricity { get; set; }
        public Nullable<decimal> Water { get; set; }
        public Nullable<decimal> BlockTax { get; set; }
    
        public virtual User User { get; set; }
    }
}
