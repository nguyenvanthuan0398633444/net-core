#pragma checksum "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b067f01ff92934ea377c9ab5dfb5291dfa83aee8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UI_Details), @"mvc.1.0.view", @"/Views/UI/Details.cshtml")]
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
#line 1 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b067f01ff92934ea377c9ab5dfb5291dfa83aee8", @"/Views/UI/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9efaef26aec2547e2386d918b3bb348586dc73c2", @"/Views/_ViewImports.cshtml")]
    public class Views_UI_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fromLoginUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/UI/Add.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
   ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_UI1.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css\">\n<style>\n    ul li {\n        display: inline;\n    }\n</style>\n<div class=\"container\">\n    <input hidden id=\"ProductId\"");
            BeginWriteAttribute("value", " value=\"", 423, "\"", 440, 1);
#nullable restore
#line 13 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
WriteAttributeValue("", 431, Model.Id, 431, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <input hidden id=\"BrandId\"");
            BeginWriteAttribute("value", " value=\"", 475, "\"", 497, 1);
#nullable restore
#line 14 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
WriteAttributeValue("", 483, Model.BrandId, 483, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <input hidden id=\"CategoryId\"");
            BeginWriteAttribute("value", " value=\"", 535, "\"", 560, 1);
#nullable restore
#line 15 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
WriteAttributeValue("", 543, Model.CategoryId, 543, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <input hidden id=\"UserId\"");
            BeginWriteAttribute("value", " value=\"", 594, "\"", 658, 1);
#nullable restore
#line 16 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
WriteAttributeValue("", 602, HttpContextAccessor.HttpContext.Session.GetString("Id"), 602, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 17 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
     if (@Model.Description != null)
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
                                                                                            }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<input hidden id=\"gameid1\" value=\"1\" />");
#nullable restore
#line 21 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <h1 style=\"font-size: 4em; line-height: 1.1; color: #29292f;\" class=\"col-md-8 blog-left\">\n        ");
#nullable restore
#line 24 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
   Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </h1>\n    <p style=\"font-size: 2em; line-height: 1.1; color: #29292f;\" class=\"col-md-8 blog-left\">\n       Giá: ");
#nullable restore
#line 27 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
       Write(Convert.ToDecimal(Model.Price).ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND\n    </p>\n\n    <div class=\"col-md-8 blog-left\">\n        <div id=\"slideimages\"></div>\n        <div id=\"addcheck\"></div>\n        <h2>");
#nullable restore
#line 33 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
       Write(Model.NumberofVote);

#line default
#line hidden
#nullable disable
            WriteLiteral("/5  <i class=\"fas fa-star\"></i></h2> (");
#nullable restore
#line 33 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
                                                                Write(Model.NumberVote);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Vote)
    </div>

</div>
<div class=""container"">
    <div class=""blog"">
        <div class=""container"">
            <div class=""col-md-8 blog-left"">
                <div class=""blog-info"">
                    <div class=""blog-info-text"">
                        <hr />
                        ");
#nullable restore
#line 44 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
                   Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <div class=""comment-icons"">
                        <h3>
                            <ul>
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i>  ");
#nullable restore
#line 51 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
                                                                        Write(Model.DateofSale);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </a>\n                                </li>\n                                <li class=\"mx-2\">\n                                    <a href=\"#\">\n                                        <i class=\"fas fa-star\"></i>  ");
#nullable restore
#line 56 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
                                                                Write(Model.NumberofVote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </a>\n                                </li>\n                                <li>\n                                    <a href=\"#\">\n                                        <i class=\"far fa-comment\"></i>  ");
#nullable restore
#line 61 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
                                                                   Write(Model.NumberofComment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>

                            </ul>
                        </h3>
                    </div>

                </div>
                <div class=""response"">
                    <h4>Comment (");
#nullable restore
#line 71 "C:\Users\hoangtx\Desktop\PageReview\PageReview\PageReview.View\Views\UI\Details.cshtml"
                            Write(Model.NumberofComment);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h4>\n                    <div id=\"formRep\" class=\"coment-form\">\n                        <h4>Bình luận</h4>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b067f01ff92934ea377c9ab5dfb5291dfa83aee812003", async() => {
                WriteLiteral(@"
                            <input hidden id=""SaveId"" value=""0"">
                            <input hidden id=""CommentId"" value=""0"">
                            <textarea type=""text"" style=""width:100%"" id=""text"" placeholder=""Bình Luận""></textarea>
                            <a class=""btn btn-primary"" value=""Phản hồi"" onclick=""Post()"">Bình Luận</a>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div id=""add"">
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal"" id=""loginUser"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h3 class=""modal-title "" style=""font-size: 30px;color:#FF6F61"">ĐĂNG NHẬP</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
            </div>
            <!-- Modal body -->
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b067f01ff92934ea377c9ab5dfb5291dfa83aee814284", async() => {
                WriteLiteral(@"
                    <div class=""row form-group"" style=""margin-left: 20px;"">
                        <label for=""EmailLogin"" class=""col-3"">Tên đăng nhập:</label>
                        <div class=""col-9"">
                            <input type=""text"" class=""form-control"" placeholder=""Tên đăng nhập""
                                   id=""UserName"" name=""UserName""
                                   data-rule-required=""true""
                                   data-msg-required=""Tên đăng nhập không được để trống""
                                   data-rule-maxlength=""100""
                                   data-msg-maxlength=""Tên đăng nhập không hợp lệ"">
                        </div>
                    </div>
                    <div class=""row form-group"" style=""margin-left: 20px;"">
                        <label for=""LoginPassword"" class=""col-3"">Mật khẩu:</label>
                        <div class=""col-9"">
                            <input type=""password"" class=""form-control"" placeholder=""Mật khẩu""
      ");
                WriteLiteral(@"                             id=""PassWord"" name=""PassWord""
                                   data-rule-required=""true""
                                   data-msg-required=""Mật khẩu không được để trống""
                                   data-rule-maxlength=""100""
                                   data-msg-maxlength=""Mật khẩu không hợp lệ"">
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

            <!-- Modal footer -->
            <div class=""modal-footer"">
                <a href=""javascript:;"" class=""btn btn-success"" onclick=""login()"">Đăng nhập</a>
                <a type=""button"" class=""btn btn-danger"" onclick=""closeModal()"">Hủy</a>
            </div>

        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b067f01ff92934ea377c9ab5dfb5291dfa83aee817566", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var slideIndex = 1;
        showDivs(slideIndex);

        function plusDivs(n) {
            showDivs(slideIndex += n);
        }

        function showDivs(n) {
            var i;
            var x = document.getElementsByClassName(""mySlides"");
            if (n > x.length) { slideIndex = 1 }
            if (n < 1) { slideIndex = x.length }
            for (i = 0; i < x.length; i++) {
                x[i].style.display = ""none"";
            }
            x[slideIndex - 1].style.display = ""block"";
        }
        function login() {
        var Obj = {};
        Obj.userName = $('#UserName').val();
        Obj.password = $('#PassWord').val();
            $.ajax({
                url: '/Account/LoginOk',
                method: 'POST',
                data: Obj,
                success: function (response) {
                    if (response == ""success"") {
                        $('#loginUser').hide();
                        location.reload();
                    }
          ");
                WriteLiteral("          else\r\n                        alert(\'Username or password is incorrect.\');\r\n                   \r\n                }\r\n            });\r\n        }\n        function closeModal() {\n            $(\'#loginUser\').hide();\n        }\n    </script>\n");
            }
            );
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductView> Html { get; private set; }
    }
}
#pragma warning restore 1591
