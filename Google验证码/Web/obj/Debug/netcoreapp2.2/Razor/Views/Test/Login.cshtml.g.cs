#pragma checksum "F:\资料\资料\demo\Google验证码\Web\Views\Test\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ab24dcbdf399c9a01d78738a644852786135ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Login), @"mvc.1.0.view", @"/Views/Test/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Login.cshtml", typeof(AspNetCore.Views_Test_Login))]
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
#line 1 "F:\资料\资料\demo\Google验证码\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "F:\资料\资料\demo\Google验证码\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#line 1 "F:\资料\资料\demo\Google验证码\Web\Views\Test\Login.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 2 "F:\资料\资料\demo\Google验证码\Web\Views\Test\Login.cshtml"
using reCAPTCHA.AspNetCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ab24dcbdf399c9a01d78738a644852786135ad", @"/Views/Test/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.AccountViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "F:\资料\资料\demo\Google验证码\Web\Views\Test\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(190, 64, true);
            WriteLiteral("\r\n<h3>登录</h3>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-xs-6\">\r\n");
            EndContext();
#line 14 "F:\资料\资料\demo\Google验证码\Web\Views\Test\Login.cshtml"
         if (ViewContext.ModelState.IsValid == false)
        {

#line default
#line hidden
            BeginContext(320, 102, true);
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <strong>Error</strong>\r\n                ");
            EndContext();
            BeginContext(422, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ab24dcbdf399c9a01d78738a644852786135ad5973", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 18 "F:\资料\资料\demo\Google验证码\Web\Views\Test\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(477, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 20 "F:\资料\资料\demo\Google验证码\Web\Views\Test\Login.cshtml"
        }

#line default
#line hidden
            BeginContext(510, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(518, 1018, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ab24dcbdf399c9a01d78738a644852786135ad7884", async() => {
                BeginContext(593, 936, true);
                WriteLiteral(@"
            <input type=""hidden"" id=""googleToken"" name=""googleToken"" />
            <div class=""form-group"">
                <label for=""username"" class=""col-sm-2 control-label"">用户名</label>
                <div class=""col-sm-10"">
                    <input type=""text"" class=""form-control"" id=""username"" name=""username"" placeholder=""用户名"">
                </div>
            </div>
            <div class=""form-group"">
                <label for=""password"" class=""col-sm-2 control-label"">密码</label>
                <div class=""col-sm-10"">
                    <input type=""password"" class=""form-control"" id=""password"" name=""password"" placeholder=""请输入密码"">
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-sm-offset-2 col-sm-10"">
                    <button type=""submit"" class=""btn btn-default"">登录</button>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1536, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1579, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1592, "\"", 1670, 2);
                WriteAttributeValue("", 1598, "https://www.recaptcha.net/recaptcha/api.js?render=", 1598, 50, true);
#line 46 "F:\资料\资料\demo\Google验证码\Web\Views\Test\Login.cshtml"
WriteAttributeValue("", 1648, options.Value.SiteKey, 1648, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1671, 121, true);
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\">\r\n        grecaptcha.ready(function () {\r\n            grecaptcha.execute(\'");
                EndContext();
                BeginContext(1793, 21, false);
#line 49 "F:\资料\资料\demo\Google验证码\Web\Views\Test\Login.cshtml"
                           Write(options.Value.SiteKey);

#line default
#line hidden
                EndContext();
                BeginContext(1814, 174, true);
                WriteLiteral("\', { action: \'login\' }).then(function (token) {\r\n                //将Token写入隐藏域等等\r\n                $(\"#googleToken\").val(token);\r\n            });\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RecaptchaSettings> options { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.AccountViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
