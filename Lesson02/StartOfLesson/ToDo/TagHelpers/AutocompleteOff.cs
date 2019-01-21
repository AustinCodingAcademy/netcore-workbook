using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;



namespace ToDoApp.TagHelpers
{
    [HtmlTargetElement("*", Attributes = "autocomplete-off")]
    public class AutocompleteOffTagHelper : TagHelper
    {

        

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.Attributes.SetAttribute("autocomplete", "off");

        }
    }
}
