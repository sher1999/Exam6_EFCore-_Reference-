using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TimeTable
    {[Key]
      public int  TTId { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Subject { get; set; }

        public TimeTable()
        {

        }
        public TimeTable(int tTId,string day,string time, string subject)
        {
            TTId = tTId;
            Day = day;
            Time = time;
            Subject = subject;
        }
    }
}
