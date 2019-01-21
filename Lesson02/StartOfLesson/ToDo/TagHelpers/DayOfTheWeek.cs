using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
 


namespace ToDoApp.TagHelpers  
{
    [HtmlTargetElement("*", Attributes = "day-of-the-week")]
    public class DayOfWeekTagHelper : TagHelper
    {

        public DateTime TodoDate { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {


            var stringDate = TodoDate < DateTime.Now.AddDays(-7)
                ? TodoDate.ToString("MM/dd/yyyy")
                : TodoDate.DayOfWeek.ToString();

            output.Content.SetContent(stringDate);
            // item.Created < DateTime.Now.AddDays(7) ? item.Created.DayOfWeek.ToString() : item.Created.ToString("mm/dd/yyyy")
        }
    }
}
