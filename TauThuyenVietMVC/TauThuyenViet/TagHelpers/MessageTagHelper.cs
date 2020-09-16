using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TauThuyenViet.TagHelpers
{
    public class MessageTagHelper : TagHelper
    {
        [HtmlAttributeName("type")]
        public string Type { get; set; }

        [HtmlAttributeName("content")]
        public string Content { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            string type = this.Type.ToString().ToLower();
            string content = this.Content;

            if (string.IsNullOrEmpty(content))
            {
                var elemContent = await output.GetChildContentAsync();
                content = elemContent.GetContent();
                this.Content = content;
            }

            string template = $@"<div class='alert alert-{type}'>
                                        <button type='button' class='close'
                                        data-dismiss='alert'>&times;</button>
                                        <span>{content}</span>
                                </div>";
            output.TagName = string.Empty;

            if (this.Content.Trim() != string.Empty)
            {
                output.Content.SetHtmlContent(template);
            }
            else
            {
                output.Content.SetHtmlContent(string.Empty);
            }


        }
    }
}
