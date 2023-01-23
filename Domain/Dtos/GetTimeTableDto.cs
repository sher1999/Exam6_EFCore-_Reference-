using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class GetTimeTableDto
    {
        public int TTId { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Subject { get; set; }

        public GetTimeTableDto()
        {

        }
        public GetTimeTableDto(int tTId, string day, string time, string subject)
        {
            TTId = tTId;
            Day = day;
            Time = time;
            Subject = subject;
        }
    }
}
