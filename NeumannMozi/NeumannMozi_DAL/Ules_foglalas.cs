//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NeumannMozi_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ules_foglalas
    {
        public int Id { get; set; }
        public string Kategoria { get; set; }
        public int UlesId { get; set; }
        public int VetitesId { get; set; }
        public int FoglalasId { get; set; }
    
        public virtual Ules Ules { get; set; }
        public virtual Vetites Vetites { get; set; }
        public virtual Foglalas Foglalas { get; set; }
    }
}
