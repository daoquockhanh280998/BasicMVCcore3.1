#pragma checksum "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "790ecdebe49bf283f95be6f5ac62ea5abe13ed7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\_ViewImports.cshtml"
using TauThuyenViet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\_ViewImports.cshtml"
using TauThuyenViet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\_ViewImports.cshtml"
using TauThuyenViet.ViewComponensts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\_ViewImports.cshtml"
using TauThuyenViet.ClassHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790ecdebe49bf283f95be6f5ac62ea5abe13ed7a", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63bc3713835b82a841ae4e0bd0c75b2f2c199600", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::AspNetCore.Views_Product_Detail.__Generated__vcProductRelatedViewComponentTagHelper __vcProductRelatedViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <section id=\"product-detail\">\r\n        <aside class=\"avatar\">\r\n            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 208, "\"", 227, 1);
#nullable restore
#line 9 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
WriteAttributeValue("", 214, Model.Avatar, 214, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </aside>\r\n        <aside class=\"info\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12 col-md-6\">\r\n                        <h1>\r\n                            ");
#nullable restore
#line 16 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h1>\r\n                        <div>\r\n                            ");
#nullable restore
#line 19 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
                       Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-12 col-md-6"">
                        <div class=""product-imagelist-swiper"">
                            <div class=""swiper-container"">
                                <div class=""swiper-wrapper"">
");
#nullable restore
#line 26 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
                                     foreach (var item in Model.ImageList.Trim().Split("\n", StringSplitOptions.RemoveEmptyEntries))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"swiper-slide\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1176, "\"", 1188, 1);
#nullable restore
#line 29 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1183, item, 1183, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-fancybox=\"gallery\">\r\n                                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1286, "\"", 1297, 1);
#nullable restore
#line 30 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1292, item, 1292, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            </a>\r\n                                        </div>\r\n");
#nullable restore
#line 33 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""swiper-pagination""></div>
                                <div class=""swiper-button-prev""></div>
                                <div class=""swiper-button-next""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </aside>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:vc-product-related", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "790ecdebe49bf283f95be6f5ac62ea5abe13ed7a7610", async() => {
            }
            );
            __vcProductRelatedViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Product_Detail.__Generated__vcProductRelatedViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__vcProductRelatedViewComponentTagHelper);
#nullable restore
#line 46 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
__vcProductRelatedViewComponentTagHelper.ID = Model.ProductID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __vcProductRelatedViewComponentTagHelper.ID, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
__vcProductRelatedViewComponentTagHelper.catID = Model.ProductCategoryID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cat-id", __vcProductRelatedViewComponentTagHelper.catID, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:vc-product-related", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "790ecdebe49bf283f95be6f5ac62ea5abe13ed7a9446", async() => {
            }
            );
            __vcProductRelatedViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Product_Detail.__Generated__vcProductRelatedViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__vcProductRelatedViewComponentTagHelper);
#nullable restore
#line 47 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
__vcProductRelatedViewComponentTagHelper.ID = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __vcProductRelatedViewComponentTagHelper.ID, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "D:\học tập\Khóa MVC CORE 3.1\github\TauThuyenVietMVC\TauThuyenViet\Views\Product\Detail.cshtml"
__vcProductRelatedViewComponentTagHelper.catID = Model.ProductCategoryID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cat-id", __vcProductRelatedViewComponentTagHelper.catID, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </section>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:vc-product-related")]
        public class __Generated__vcProductRelatedViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__vcProductRelatedViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32? ID { get; set; }
            public System.Int32? catID { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("vcProductRelated", new { ID, catID });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591