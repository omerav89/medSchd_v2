using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MedSchd
    {
        public String ClientId { get; set; }
        public String MedId { get; set; }
        public DateTime StartTime { get; set; }
        public int DaysLong { get; set; }
        public int PharmacistId { get; set; }
        public int AmountMorning { get; set; }
        public int AmountNight { get; set; }
        public int AmountNoon { get; set; }
        
    }
}
