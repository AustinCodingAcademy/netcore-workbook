using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Intrastructure
{
    [HtmlTargetElement("form", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class formTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = output.TagName + " autocomplete = 'off'";
        }
    }

}
