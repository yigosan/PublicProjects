#pragma checksum "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52368ef0453f404e4f2536182d4150ac0e5a1444"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52368ef0453f404e4f2536182d4150ac0e5a1444", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CuriousDriveWebClient.LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("loginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
  
    ViewBag.Title = "Log in - Curious Drive";

#line default
#line hidden
            BeginContext(102, 60, true);
            WriteLiteral("\r\n<div class=\"row col-lg-10 col-12\" style=\"float:right\">\r\n\r\n");
            EndContext();
#line 9 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
     using (Html.BeginForm("Login", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form", defaultbutton = "LogIn" }))
    {

#line default
#line hidden
            BeginContext(311, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(319, 4989, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "176cc9b9b9964715822bb6ed56b7518f", async() => {
                BeginContext(377, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(392, 23, false);
#line 12 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(415, 550, true);
                WriteLiteral(@"

            <div class=""col-lg-12 col-12"">
                <br />
                <br />
                <br />
                <br />
            </div>

            <div class=""col-lg-12 card d-none d-md-block"">

                <div class=""col-lg-12"">
                    <br />
                    <br />
                    <br />
                    <br />
                </div>

                <div class=""row"">
                    <div class=""col-lg-7"" style=""border-right:2px solid #F2F2F2;"">
                        ");
                EndContext();
                BeginContext(965, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "941b7a9770014398852ce8fd1c036137", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1051, 153, true);
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-lg-5\">\r\n                        <div class=\"col-lg-12\">\r\n                            ");
                EndContext();
                BeginContext(1205, 116, false);
#line 37 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                       Write(Html.TextBoxFor(m => m.EmailAddress, new { id = "txtEmailAddress", placeholder = "email", @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1321, 228, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-lg-12\">\r\n                            <br />\r\n                        </div>\r\n                        <div class=\"col-lg-12\">\r\n                            ");
                EndContext();
                BeginContext(1550, 112, false);
#line 43 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                       Write(Html.PasswordFor(m => m.Password, new { id = "txtPassword", placeholder = "password", @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1662, 504, true);
                WriteLiteral(@"
                        </div>                       
                       
                        <div class=""col-lg-12"">
                            <br />
                        </div>
                        <div class=""col-lg-12"">
                            <button id=""LogIn"" class=""btn btn-primary"" type=""submit"" name=""submitType"" value=""Login"">Login</button>
                            
                            <span style=""font-weight:bold"">
                                ");
                EndContext();
                BeginContext(2167, 50, false);
#line 53 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                           Write(Html.ActionLink("Register", "Register", "Account"));

#line default
#line hidden
                EndContext();
                BeginContext(2217, 174, true);
                WriteLiteral("\r\n                            </span>\r\n                            \r\n                            <span style=\"float:right;font-weight:bold\">\r\n                                ");
                EndContext();
                BeginContext(2392, 64, false);
#line 57 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                           Write(Html.ActionLink("Forgot Password?", "ForgotPassword", "Account"));

#line default
#line hidden
                EndContext();
                BeginContext(2456, 356, true);
                WriteLiteral(@"
                            </span>

                        </div>
                        <div class=""col-lg-12"">
                            <hr />
                        </div>
                        <div class=""col-lg-12"">
                            <br />
                        </div>
                        <div class=""col-lg-12"">
");
                EndContext();
#line 68 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                             foreach (var item in Model.AllSchemeProvider)
                            {
                                

#line default
#line hidden
#line 70 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                                 if (item == "Facebook")
                                {

#line default
#line hidden
                BeginContext(3012, 111, true);
                WriteLiteral("                                    <button class=\"btn btn-social btn-facebook\" type=\"submit\" name=\"submitType\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3123, "\"", 3136, 1);
#line 72 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
WriteAttributeValue("", 3131, item, 3131, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3137, 150, true);
                WriteLiteral(">\r\n                                        <span class=\"fa fa-facebook\"></span> Sign in with Facebook\r\n                                    </button>\r\n");
                EndContext();
#line 75 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                                }

#line default
#line hidden
#line 76 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                                 if (item == "Google")
                                {

#line default
#line hidden
                BeginContext(3413, 109, true);
                WriteLiteral("                                    <button class=\"btn btn-social btn-google\" type=\"submit\" name=\"submitType\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3522, "\"", 3535, 1);
#line 78 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
WriteAttributeValue("", 3530, item, 3530, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3536, 151, true);
                WriteLiteral(">\r\n                                        <span class=\"fa fa-google-plus\"></span> Sign in with Google\r\n                                    </button>\r\n");
                EndContext();
#line 81 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                                }

#line default
#line hidden
#line 81 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                                 

                            }

#line default
#line hidden
                BeginContext(3755, 488, true);
                WriteLiteral(@"                        </div>
                    </div>
                </div>                

                <div class=""col-lg-12"">
                    <br />
                    <br />
                    <br />
                    <br />
                </div>

            </div>

            <div class=""col-12 card d-md-none d-block"">

                <div id=""divSmallLogin"" class=""col-xs-12"">
                    <div class=""col-12"">
                        ");
                EndContext();
                BeginContext(4244, 92, false);
#line 101 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                   Write(Html.TextBoxFor(m => m.EmailAddress, new { placeholder = "email", @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(4336, 198, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-12\">\r\n                        <br />\r\n                    </div>\r\n                    <div class=\"col-12\">\r\n                        ");
                EndContext();
                BeginContext(4535, 92, false);
#line 107 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { placeholder = "password", @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(4627, 295, true);
                WriteLiteral(@"
                    </div>
                    <div class=""col-12"">
                        <br />
                    </div>
                    <div class=""col-12"">
                        <input id=""smallLogIn"" class=""btn btn-primary"" type=""submit"" name=""submitType"" value=""Login"" />
");
                EndContext();
                BeginContext(5013, 288, true);
                WriteLiteral(@"                    </div>
                    <div class=""col-12"">
                        <br />
                    </div>
                </div>              
            </div>

            <div class=""col-lg-12 col-12"">
                <br />
            </div>

        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5308, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 127 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
    }

#line default
#line hidden
            BeginContext(5317, 510, true);
            WriteLiteral(@"
</div>

<script type=""text/javascript"">

    var ButtonKeys = { ""EnterKey"": 13 };
    $(function () {
        $(""#Login"").keypress(function (e) {
            if (e.which == ButtonKeys.EnterKey) {
                var defaultButtonId = $(this).attr(""defaultbutton"");
                $(""#"" + defaultButtonId).click();
                return false;
            }
        });
    });

    $(function () {
        $(""#smallLogIn"").click(function () {

            $.ajax({
                url: '");
            EndContext();
            BeginContext(5828, 30, false);
#line 148 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Account\Login.cshtml"
                 Write(Url.Action("Login", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(5858, 283, true);
            WriteLiteral(@"',
                type: ""post"",
                dataType: ""html"",
                contentType: 'application/json; charset=utf-8',
                error: function () {
                    alert(""error"");
                }
            });
        });
    });

</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CuriousDriveWebClient.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
