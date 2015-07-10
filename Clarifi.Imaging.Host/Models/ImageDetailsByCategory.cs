using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clarifi.Imaging.Host.Models
{
    public class ImageDetailsByCategory
    {
        public long TotalImages { get; set; }
        public long ProcessedImages { get; set; }
        public long UnCategorized { get; set; }
        public long FlaggedImages { get; set; }
        public long AssignedImages { get; set; }
        public long ReviewdImages { get; set; }
        public List<Image> Images { get; set; }
    }
}