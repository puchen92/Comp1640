//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace devPMS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeLog
    {
        public int ID { get; set; }
        public int ProID { get; set; }
        public int EmpID { get; set; }
        public int SubTaskID { get; set; }
        public System.DateTime WorkedDate { get; set; }
        public double Hours { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime LastModifiedDateTime { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
