using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clarifi.Imaging.Host.Models
{
    public class Image
    {
        public long Id { get; set; }
        public string ReportedBy { get; set; }
        public string ReportedOn { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }
        public Status Status { get; set; }
    }
}