#pragma checksum "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf31cb76d5a306ecfb6febd079d0cb0320cba667"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_vcProductRelated_Default), @"mvc.1.0.view", @"/Views/Shared/Components/vcProductRelated/Default.cshtml")]
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
#line 1 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\_ViewImports.cshtml"
using vuonsendaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\_ViewImports.cshtml"
using vuonsendaMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\_ViewImports.cshtml"
using vuonsendaMVC.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\_ViewImports.cshtml"
using vuonsendaMVC.ClassHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf31cb76d5a306ecfb6febd079d0cb0320cba667", @"/Views/Shared/Components/vcProductRelated/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f63df52bbec31bda01ce30c812997e9a116ac0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_vcProductRelated_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "product-detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("invarseColor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/FileUpload/image/sendacolon/SenBanhBaoXanhCoDai.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <aside class=\"styled_header\">\r\n            <div class=\"title-line\">\r\n                <h4>");
#nullable restore
#line 6 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
               Write(ViewData[ViewDataUtility.PRODUCT_RELATED_HEADING]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n        </aside>\r\n    </div>\r\n    <ul>\r\n\r\n");
#nullable restore
#line 12 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"col-md-3 col-sm-6 col-12\">\r\n                <div class=\"thumbnail \">\r\n                    <div class=\"carousel-inner\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf31cb76d5a306ecfb6febd079d0cb0320cba6676214", async() => {
                WriteLiteral("\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 648, "\"", 666, 1);
#nullable restore
#line 18 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
WriteAttributeValue("", 654, item.Avatar, 654, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                                                        WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                                                                                          WriteLiteral(item.Title.ToUrlFormat());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <span class=\" product-sale\"> </span>\r\n                    </div>\r\n                </div>\r\n                <div class=\"thumbSetting\">\r\n                    <div class=\"thumbTitle\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf31cb76d5a306ecfb6febd079d0cb0320cba6679948", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 26 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                                                        WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                                                                                          WriteLiteral(item.Title.ToUrlFormat());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"thumbPrice\">\r\n                    <span>\r\n                        ");
#nullable restore
#line 32 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <span class=""strike-through""></span>
                    </span>
                </div>
                <div class=""thumbButtons"">
                    <button type=""button"" class=""btn btn-primary btn-small"" data-toggle=""modal"" data-target="".bd-example-modal-xl"">
                        <i class=""fa fa-shopping-cart""></i>
                        Thêm vào giỏ hàng
                    </button>
                    <div class=""modal fade bd-example-modal-xl"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myExtraLargeModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog modal-xl"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""exampleModalScrollableTitle"">Bạn có <span>1</span> sản phẩm trong giỏ hàng</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-labe");
            WriteLiteral(@"l=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    <table class=""table table-striped"">
                                        <thead>
                                            <tr>
                                                <th class=""image""></th>
                                                <th class=""title"">Tên sản phẩm</th>
                                                <th class=""qty"">Số lượng</th>
                                                <th class=""price"">Giá tiền</th>
                                                <th class=""remove""></th>
                                            </tr>
                                        </thead>
                                    </table>
                                    <div class=""scrollable"">
             ");
            WriteLiteral(@"                           <table class=""table table-striped"">
                                            <tbody>
                                                <tr>
                                                    <td class=""image"">
                                                        <a href=""ProductDetail.html"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf31cb76d5a306ecfb6febd079d0cb0320cba66716380", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </a>
                                                    </td>
                                                    <td class=""title"">
                                                        <a href=""ProductDetail.html"">
                                                            Sen bắp cải cỡ lớn 15-12cm
                                                        </a>
                                                    </td>
                                                    <td class=""qty"">
                                                        <div class=""qtys"">
                                                            <button class=""left-qty""><i class=""fa fa-angle-left""></i></button>
                                                            <input value=""1"" class=""tc item-quantity"">
                                                            <button class=""right-qty""><i class=""fa fa-angle-right""></i></button>
                         ");
            WriteLiteral(@"                               </div>
                                                    </td>
                                                    <td class=""price"">
                                                        <div>
                                                            <span class=""strike-through"">180,000đ</span>
                                                        </div>
                                                        <div>
                                                            <span>150,000đ</span>
                                                        </div>
                                                    </td>
                                                    <td class=""remove"">
                                                        <a href=""#"">
                                                            <i class=""fa fa-times""></i>
                                                        </a>
                                                    </td>");
            WriteLiteral(@"
                                                </tr>
                                                <tr>
                                                    <td class=""image"">
                                                        <a href=""ProductDetail.html"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf31cb76d5a306ecfb6febd079d0cb0320cba66719967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </a>
                                                    </td>
                                                    <td class=""title"">
                                                        <a href=""ProductDetail.html"">
                                                            Sen bắp cải cỡ lớn 15-12cm
                                                        </a>
                                                    </td>
                                                    <td class=""qty"">
                                                        <div class=""qtys"">
                                                            <button class=""left-qty""><i class=""fa fa-angle-left""></i></button>
                                                            <input value=""1"" class=""tc item-quantity"">
                                                            <button class=""right-qty""><i class=""fa fa-angle-right""></i></button>
                         ");
            WriteLiteral(@"                               </div>
                                                    </td>
                                                    <td class=""price"">
                                                        <div>
                                                            <span class=""strike-through"">180,000đ</span>
                                                        </div>
                                                        <div>
                                                            <span>150,000đ</span>
                                                        </div>
                                                    </td>
                                                    <td class=""remove"">
                                                        <a href=""#"">
                                                            <i class=""fa fa-times""></i>
                                                        </a>
                                                    </td>");
            WriteLiteral(@"
                                                </tr>
                                                <tr>
                                                    <td class=""image"">
                                                        <a href=""ProductDetail.html"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf31cb76d5a306ecfb6febd079d0cb0320cba66723554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </a>
                                                    </td>
                                                    <td class=""title"">
                                                        <a href=""ProductDetail.html"">
                                                            Sen bắp cải cỡ lớn 15-12cm
                                                        </a>
                                                    </td>
                                                    <td class=""qty"">
                                                        <div class=""qtys"">
                                                            <button class=""left-qty""><i class=""fa fa-angle-left""></i></button>
                                                            <input value=""1"" class=""tc item-quantity"">
                                                            <button class=""right-qty""><i class=""fa fa-angle-right""></i></button>
                         ");
            WriteLiteral(@"                               </div>
                                                    </td>
                                                    <td class=""price"">
                                                        <div>
                                                            <span class=""strike-through"">180,000đ</span>
                                                        </div>
                                                        <div>
                                                            <span>150,000đ</span>
                                                        </div>
                                                    </td>
                                                    <td class=""remove"">
                                                        <a href=""#"">
                                                            <i class=""fa fa-times""></i>
                                                        </a>
                                                    </td>");
            WriteLiteral(@"
                                                </tr>
                                                <tr>
                                                    <td class=""image"">
                                                        <a href=""ProductDetail.html"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf31cb76d5a306ecfb6febd079d0cb0320cba66727141", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </a>
                                                    </td>
                                                    <td class=""title"">
                                                        <a href=""ProductDetail.html"">
                                                            Sen bắp cải cỡ lớn 15-12cm
                                                        </a>
                                                    </td>
                                                    <td class=""qty"">
                                                        <div class=""qtys"">
                                                            <button class=""left-qty""><i class=""fa fa-angle-left""></i></button>
                                                            <input value=""1"" class=""tc item-quantity"">
                                                            <button class=""right-qty""><i class=""fa fa-angle-right""></i></button>
                         ");
            WriteLiteral(@"                               </div>
                                                    </td>
                                                    <td class=""price"">
                                                        <div>
                                                            <span class=""strike-through"">180,000đ</span>
                                                        </div>
                                                        <div>
                                                            <span>150,000đ</span>
                                                        </div>
                                                    </td>
                                                    <td class=""remove"">
                                                        <a href=""#"">
                                                            <i class=""fa fa-times""></i>
                                                        </a>
                                                    </td>");
            WriteLiteral(@"
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <div class=""modal-note"">
                                                <textarea placeholder=""Viết ghi chú"" id=""note"" name=""note"" rows=""5""></textarea>
                                            </div>
                                        </div>
                                        <div class=""col-sm-6"">
                                            <div class=""total-price-modal"">
                                                Tổng cộng : <span class=""item-total"">180,000₫</span>
                                            </div>
                                        </div>
                                    </div>
               ");
            WriteLiteral(@"                     <div class=""row"" style=""margin-top:10px;"">
                                        <div class=""col-lg-6"">
                                            <div class=""comeback"">
                                                <a href=""/collections/all"">
                                                    <i class=""fa fa-caret-left mr10""></i>Tiếp tục mua hàng
                                                </a>
                                            </div>
                                        </div>
                                        <div class=""col-lg-6 text-right"">
                                            <div class=""buttons btn-modal-cart"">
                                                <button type=""submit"" class=""button-default"" id=""checkout"" name=""checkout"">
                                                    Đặt hàng
                                                </button>
                                            </div>

                               ");
            WriteLiteral("             <div class=\"buttons btn-modal-cart\">\r\n                                                <button type=\"submit\" class=\"button-default\" id=\"update-cart-modal\"");
            BeginWriteAttribute("name", " name=\"", 15405, "\"", 15412, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    Cập nhật
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </li>
");
#nullable restore
#line 236 "D:\học tập\Khóa MVC CORE 3.1\github\vuonsendaMVC\vuonsendaMVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <div class=\"col-md-12\">\r\n        <div class=\"buttonMain\">\r\n            <div class=\"btn\">\r\n");
            WriteLiteral("                    Xem thêm\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
