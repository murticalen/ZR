//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplikacija.BP
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdminPredmet
    {
        public int sifraAdminPredmet { get; set; }
        public int sifraAdmina { get; set; }
        public int sifraPredmeta { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Predmet Predmet { get; set; }
    }
}