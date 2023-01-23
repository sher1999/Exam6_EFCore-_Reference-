using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class GetIssuesDto
    {
        public int IssueId { get; set; }
        public string Type { get; set; }

        public string Details { get; set; }
        public bool IsResolved { get; set; }
        public int StudentId {get;set;}
        public GetIssuesDto()
        {

        }
        public GetIssuesDto(int issueId, string tybe, string details, bool isResolved,int studentId)
        {
            IssueId = issueId;
            Type = tybe;
            Details = details;
            IsResolved = isResolved;
            StudentId=studentId;
        }
    }
}
