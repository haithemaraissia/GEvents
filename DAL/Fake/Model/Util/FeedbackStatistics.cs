using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Fake.Model.Util
{
    public class FeedbackStatistics
    {
        public double Average { get; set; }
        public double Percentage { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int NumberOfRaters { get; set; }
    }
}
