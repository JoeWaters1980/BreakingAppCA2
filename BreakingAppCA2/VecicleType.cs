//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BreakingAppCA2
{
    using System;
    using System.Collections.Generic;
    
    public partial class VecicleType
    {
        public int Id { get; set; }
        public string TypeOfVechicle { get; set; }
        public int Weather_Id { get; set; }
    
        public virtual Weather Weather { get; set; }
    }
}