#pragma checksum "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb21c3236166da264af6094a77fb771e074b2818"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UI_getsbycomment), @"mvc.1.0.view", @"/Views/UI/getsbycomment.cshtml")]
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
#line 1 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\_ViewImports.cshtml"
using PageReview.View;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\_ViewImports.cshtml"
using PageReview.View.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\_ViewImports.cshtml"
using PageReview.View.Models.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\_ViewImports.cshtml"
using PageReview.View.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb21c3236166da264af6094a77fb771e074b2818", @"/Views/UI/getsbycomment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9efaef26aec2547e2386d918b3bb348586dc73c2", @"/Views/_ViewImports.cshtml")]
    public class Views_UI_getsbycomment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<ProductView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UI", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("example-image-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-lightbox", new global::Microsoft.AspNetCore.Html.HtmlString("example-set"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-title", new global::Microsoft.AspNetCore.Html.HtmlString("Click the right half of the image to move forward."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
   ViewData["Title"] = "Product theo số lượng bình luận";
    Layout = "~/Views/Shared/_UI1.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\n    ul li {\n        display: inline;\n    }\r\n    #background {\r\n        background: url(\"/images/notfound.png\") no-repeat center;\r\n        height: 1000px;\r\n    }\n</style>\n");
#nullable restore
#line 15 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
 if (ViewBag.Muccomment == 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Product với 0- 10 bình luận</h2> ");
#nullable restore
#line 17 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
                                     }
            else if (ViewBag.Muccoment == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>Product có 10 - 25 bình luận</h2>\n");
#nullable restore
#line 21 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
            }
else if (ViewBag.Muccoment == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>Product có 25 - 40 bình luận</h2>\n");
#nullable restore
#line 25 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
            }
else if (ViewBag.Muccoment == 4)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>Product với 40 bình luận trở lên</h2>\n");
#nullable restore
#line 29 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 31 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
         if (Model.Count != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"gallery-bottom\">\n    <div class=\"row\">\n");
#nullable restore
#line 35 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
     foreach (var item in Model)
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
     if (!item.Deleted)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-4 gallery-grid\">\n        <div style=\"height: 140px;\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb21c3236166da264af6094a77fb771e074b28188492", async() => {
                WriteLiteral("\n                <img class=\"example-image\"");
                BeginWriteAttribute("src", " src=\"", 1280, "\"", 1305, 2);
                WriteAttributeValue("", 1286, "/images/", 1286, 8, true);
#nullable restore
#line 42 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
WriteAttributeValue("", 1294, item.Image, 1294, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1306, "\"", 1312, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 200px; text-align: center;height: 140px;\" />\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div style=\"width: 200px;\n    overflow: hidden;\n    white-space: nowrap;\n    text-overflow: ellipsis;\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb21c3236166da264af6094a77fb771e074b281811962", async() => {
                WriteLiteral("<label>");
#nullable restore
#line 49 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
                                                                                  Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\n            <ul>\n                <li>\n                    <a href=\"#\">\n                        <i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 53 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
                                                       Write(item.DateofSale.ToString().Substring(0, 10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </a>\n                </li>\n                <li class=\"mx-2\">\n                    <a href=\"#\">\n                        <i class=\"fas fa-star\"></i> ");
#nullable restore
#line 58 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
                                               Write(item.NumberofVote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </a>\n                </li>\n                <li>\n                    <a href=\"#\">\n                        <i class=\"far fa-comment\"></i> ");
#nullable restore
#line 63 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
                                                  Write(item.NumberofComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </a>\n                </li>\n\n            </ul>\n            <p>");
#nullable restore
#line 68 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
          Write(string.Format("{0:#,0}", @item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</p>\n        </div>");
#nullable restore
#line 69 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
               } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"clearfix\"></div>\n    </div>\n</div>\n");
#nullable restore
#line 73 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
        }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"background\">Không tìm thấy kết quả nào phù hợp</div>");
#nullable restore
#line 76 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>");
#nullable restore
#line 77 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\getsbycomment.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action($"GetsbyComment", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<ProductView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
