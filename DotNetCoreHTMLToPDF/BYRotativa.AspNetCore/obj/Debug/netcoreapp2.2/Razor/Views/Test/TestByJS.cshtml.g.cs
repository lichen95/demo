#pragma checksum "F:\资料\资料\demo\DotNetCoreHTMLToPDF\BYRotativa.AspNetCore\Views\Test\TestByJS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a86acdcefa1b9e1d543d24de40b918ede97750b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_TestByJS), @"mvc.1.0.view", @"/Views/Test/TestByJS.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/TestByJS.cshtml", typeof(AspNetCore.Views_Test_TestByJS))]
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
#line 1 "F:\资料\资料\demo\DotNetCoreHTMLToPDF\BYRotativa.AspNetCore\Views\_ViewImports.cshtml"
using BYRotativa.AspNetCore;

#line default
#line hidden
#line 2 "F:\资料\资料\demo\DotNetCoreHTMLToPDF\BYRotativa.AspNetCore\Views\_ViewImports.cshtml"
using BYRotativa.AspNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a86acdcefa1b9e1d543d24de40b918ede97750b", @"/Views/Test/TestByJS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"101d06e671b7ed246e7e49a7e1bb03c3ac0b8adb", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_TestByJS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/html2canvas.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsPdf.debug.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pdf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background:#ffd800"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 20, true);
            WriteLiteral("<!DOCTYPE>\r\n<html>\r\n");
            EndContext();
            BeginContext(20, 1145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a86acdcefa1b9e1d543d24de40b918ede97750b5309", async() => {
                BeginContext(26, 1132, true);
                WriteLiteral(@"
    <title>
        html2canvas example
    </title>
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <style type=""text/css"">
        body {
            margin: 0;
            padding: 0;
            background-color: white;
        }

        header, section {
            overflow: hidden;
        }

        ul {
            margin: 0;
            border: 0;
            padding: 0;
        }

        li {
            display: block; /* i.e., suppress marker */
            color: black;
            height: 4em;
            width: 25%;
            margin: 0;
            float: left;
            background-color: green;
            text-align: center;
            line-height: 4em;
        }

        aside {
            width: 20%;
            float: left;
            text-align: center;
        }

            aside a {
                display: block;
                height: 4em;
                color: blue;
            }

        article ");
                WriteLiteral("{\r\n            padding: 2em 0;\r\n            width: 80%;\r\n            float: left;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1165, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1167, 3557, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a86acdcefa1b9e1d543d24de40b918ede97750b7677", async() => {
                BeginContext(1209, 1594, true);
                WriteLiteral(@"
    <header>
        <nav>
            <ul>
                <li>one</li>
                <li>two</li>
                <li>three</li>
                <li>four</li>
            </ul>
        </nav>
    </header>
    <section>
        <aside>
            <h3>it is a title</h3>
            <a href="""">Stone Giant</a>
            <a href="""">link2</a>
            <a href="""">link3</a>
            <a href="""">link4</a>
            <a href="""">link5</a>
            <a href="""">link6</a>
        </aside>
        <article>
            <img src=""./img/Stone.png"">
            <button id=""renderPdf"">DOWNLOAD PDF</button>
            <h2>Stone Giant</h2>
            <p>
                Coming to life as a chunk of stone, Tiny's origins are a mystery on which he continually speculates. He is a Stone Giant now, but what did he used to be? A splinter broken from a Golem's heel? A shard swept from a gargoyle-sculptor's workshop? A fragment of the Oracular Visage of Garthos? A deep curiosity drives him, an");
                WriteLiteral(@"d he travels the world tirelessly seeking his origins, his parentage, his people. As he roams, he gathers weight and size; the forces that weather lesser rocks, instead cause Tiny to grow and ever grow.
            </p>
            <p>
                以一团石头的形式出现的生命体，小小不断思索他的起源，但这始终是个谜。现在的他是个石巨人，但过去是什么呢？从土傀儡的脚后跟掉落的碎片？从制造石像鬼的工房被打扫出来的碎屑？神圣预言石的表层之砂？受到强烈的好奇心驱使，他不知疲倦的环游世界，寻找着他的起源，他的出身，和他的种族。在旅途中，他变得越来越庞大，不过路上的风雨吹打掉了他身上的石头，所以他不停的吸收新的岩石，永远在长大。
            </p>
        </article>
    </section>
    <footer>write by linwalker2017</footer>
    <div>hello,word</div>
");
                EndContext();
#line 91 "F:\资料\资料\demo\DotNetCoreHTMLToPDF\BYRotativa.AspNetCore\Views\Test\TestByJS.cshtml"
     foreach (var item in ViewBag.list)
    {

#line default
#line hidden
                BeginContext(2851, 11, true);
                WriteLiteral("        <p>");
                EndContext();
                BeginContext(2863, 4, false);
#line 93 "F:\资料\资料\demo\DotNetCoreHTMLToPDF\BYRotativa.AspNetCore\Views\Test\TestByJS.cshtml"
      Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(2867, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 94 "F:\资料\资料\demo\DotNetCoreHTMLToPDF\BYRotativa.AspNetCore\Views\Test\TestByJS.cshtml"
    }

#line default
#line hidden
                BeginContext(2880, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(2888, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a86acdcefa1b9e1d543d24de40b918ede97750b10605", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2954, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2960, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a86acdcefa1b9e1d543d24de40b918ede97750b11948", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3026, 1691, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        var downPdf = document.getElementById(""renderPdf"");

        downPdf.onclick = function () {
            html2canvas($('#pdf'), {
                onrendered: function (canvas) {
                    console.log(canvas);
                    //返回图片URL，参数：图片格式和清晰度(0-1)
                    var pageData = canvas.toDataURL('image/jpeg', 1.0);

                    //方向默认竖直，尺寸ponits，格式a4【595.28,841.89]
                    var pdf = new jsPDF('', 'pt', 'a4');

                    //需要dataUrl格式
                    pdf.addImage(pageData, 'JPEG', 0, 0, 595.28, 592.28 / canvas.width * canvas.height);
                    // 修改背景色
                    $('#pdf').css(""background"", ""#fff"")
                    //方法1
                    pdf.save('content.pdf');
                    var datauri = pdf.output('dataurlstring');
                    console.log(datauri);
                    //去掉前面的字符串后，就是文件的加密字符串
                    var base64 = datauri.substring(28);");
                WriteLiteral(@"
                    console.log(base64);
                    //然后把这个字符串送到后台解密
                    //后台：
                    //主要用BASE64Decoder解密，放到文件流里

                    $.ajax({
                        url: ""/test/SavePDF"",
                        type: ""post"",
                        data: { str: base64 },
                        success: function (json) {

                        }
                    })

                    //方法2
                    //pdf.addHTML($('#pdf'), function(json){
                    //    pdf.output(""save"", 'aaa.pdf')
                    //})


                }
            })
        }
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4724, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
