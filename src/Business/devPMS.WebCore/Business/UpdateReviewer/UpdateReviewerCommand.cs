﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devPMS.WebCore.Business
{
    public class UpdateReviewerCommand 
    {
        public int ID { get; set; }
        public string Reviewer { get; set; }
        public bool IncludeScopeofService { get; set; }
    }
}
