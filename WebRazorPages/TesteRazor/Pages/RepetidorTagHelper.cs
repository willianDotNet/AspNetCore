using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteRazor.Pages
{
    public class RepetidorTagHelper : TagHelper
    {
        public int Quantidade { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            for (int i = 0; i < Quantidade; i++)
            {
                output.Content.AppendHtml( await output.GetChildContentAsync(useCachedResult:false));
            }
        }
    }
}
