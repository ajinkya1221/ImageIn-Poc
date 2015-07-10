using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clarifi.Imaging.Host.Models
{
    public class ReportSummary
    {
        public List<CategoryReport> CategoryReports { get; set; }
        public List<UserReport> UserReports { get; set; }
    }
}