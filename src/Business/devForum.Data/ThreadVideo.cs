//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace devForum.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThreadVideo
    {
        public int ThreadVideoId { get; set; }
        public int ThreadId { get; set; }
        public string VideoUrl { get; set; }
        public string VideoThumbnail { get; set; }
        public string VideoSiteName { get; set; }
    
        public virtual Thread Thread { get; set; }
    }
}
