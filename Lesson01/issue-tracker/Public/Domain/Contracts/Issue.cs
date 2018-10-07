using System.Collections.Generic;
using System.Text;
using System;


namespace IssueTracker.Domain.Contracts
{
    public class Issue : IIssue
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Estimate { get; set; }
        public string Status { get; set; }
        public List<string> PastStates { get; set; }
        //public IssueType Type { get; set; }
        //public List<IssueType> Statuses = new List<IssueType>();

    }
}
