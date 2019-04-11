using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MovieSystem.Data.Infrastructure.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSystem.Web.Utilities.CustomTagHelpers
{
    [HtmlTargetElement("div-page-link", Attributes = "page-model")]
    public class PageLinTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory helperFactory;

        public PageLinTagHelper(IUrlHelperFactory helperFactory)
        {
            this.helperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; } =
            new Dictionary<string, object>();

        public PagingInfo PageModel { get; set; }

        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = helperFactory.GetUrlHelper(ViewContext);

            TagBuilder result = new TagBuilder("div");
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                PageUrlValues["moviePage"] = i;
                tag.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);

                tag.InnerHtml.Append(i.ToString());

                result.InnerHtml.AppendHtml(tag);
            }

            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}
