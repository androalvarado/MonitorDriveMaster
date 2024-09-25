using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorDrive.Models
{
    public class Travel
    {
        public DateTime Date { get; set; }
        public double Distance { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Tips { get; set; }
        public int NumberOfTravels { get; set; }
    }
}
