using IssueTracker.DataAccess.Contracts;
using IssueTracker.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace IssueTracker.DataAccess
{
    internal static class IssueExtensions
    {
        public static bool IsPersisted(this IIssue issue)
        {
            return issue.Id.HasValue;
        }

        public static List<string> PastStates(this DataAccess.Contracts.Issue issue)
        {
            var result = new List<string>();
            foreach (var item in issue.Statuses)
            {
                result.Add(item.ToString());
            }
            return result;
            //return Enum.GetValues(typeof(IssueType)).Cast<IssueType>().Where(v => issue.Type.HasFlag(v)).Select(v => v.ToString()).ToList();
        }
    }
}
