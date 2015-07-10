using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clarifi.Imaging.Host.Models
{
    public class Report
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long TotalImages { get; set; }
        public long ProcessedImages { get; set; }
        public string LastUpdatedOn { get; set; }
    }

    public class UserReport : Report
    {

    }

    public class CategoryReport : Report
    {

    }
}