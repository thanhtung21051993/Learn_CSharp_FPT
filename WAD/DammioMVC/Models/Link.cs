//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DammioMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Link
    {
        public int LinkID { get; set; }
        public string LinkName { get; set; }
        public string LinkURL { get; set; }
        public string LinkDescription { get; set; }
        public Nullable<int> CategoryID { get; set; }
    }
}
