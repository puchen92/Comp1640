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
    
    public partial class ProjectComment
    {
        public int CommentId { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string Body { get; set; }
        public System.DateTime CreatedDT { get; set; }
        public Nullable<System.DateTime> DeletedDT { get; set; }
        public System.DateTime ModifiedDT { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Project_Log Project_Log { get; set; }
    }
}
