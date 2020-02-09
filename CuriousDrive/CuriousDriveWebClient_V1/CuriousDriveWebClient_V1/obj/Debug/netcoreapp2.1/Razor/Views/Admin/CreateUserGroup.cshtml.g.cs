#pragma checksum "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\CreateUserGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bd808dac7fe20b63d16efed5af6136490c767ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateUserGroup), @"mvc.1.0.view", @"/Views/Admin/CreateUserGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CreateUserGroup.cshtml", typeof(AspNetCore.Views_Admin_CreateUserGroup))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bd808dac7fe20b63d16efed5af6136490c767ef", @"/Views/Admin/CreateUserGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CreateUserGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CuriousDriveWebClient.CreateUserGroupViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("createUserGroupForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\CreateUserGroup.cshtml"
  
    ViewBag.Title = "User Group - Curious Drive";

#line default
#line hidden
            BeginContext(118, 1214, true);
            WriteLiteral(@"
<script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.0.min.js"" type=""text/javascript""></script>
<script src=""https://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/jquery-ui.min.js"" type=""text/javascript""></script>

<link href=""https://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css"" rel=""Stylesheet"" type=""text/css"" />

<script type=""text/javascript"">

    var counterUsers = 0;
    var users = [];

    onLoad();

    function removeUser(userId) {

        for (incrementer = 0; incrementer < users.length; incrementer++) {
            var fields = users[incrementer].split('#')
            if (fields[1] == userId) {

                var div = document.getElementById(""div"" + userId)
                div.parentNode.removeChild(div);
                users.splice(incrementer, 1);

                var txtUserIdText = document.getElementById('txtUserIds').value;
                txtUserIdText = txtUserIdText.replace(userId, '');
                document.getElementById('");
            WriteLiteral("txtUserIds\').value = txtUserIdText;\r\n            }\r\n        }\r\n    }\r\n\r\n    function onLoad() {\r\n\r\n        var str = window.location.href.split(\"=\");\r\n\r\n        $.ajax({\r\n            url : \'");
            EndContext();
            BeginContext(1333, 40, false);
#line 42 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\CreateUserGroup.cshtml"
              Write(Url.Action("GetUserGroupUsers", "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 1867, true);
            WriteLiteral(@"',
            data: ""{ 'aintUserGroupId': '"" + str[1] + ""'}"",
            dataType: ""json"",
            type: ""POST"",
            contentType: ""application/json; charset=utf-8"",
            success: function (llstUserGroupDetail) {

                for (var i = 0; i < llstUserGroupDetail.length; i++) {

                    addGridRow(llstUserGroupDetail[i].iUser.idoUser.displayName, llstUserGroupDetail[i].idoUserGroupDetail.userId)
                }

            },
            error: function (response) {
                //alert(response.responseText);
            },
            failure: function (response) {
                //alert(response.responseText);
            }
        });
    }

    function addGridRow(displayName, userId) {

        var lblExists = false;

        for (incrementer = 0; incrementer < users.length; incrementer++) {
            if (users[incrementer] == displayName + '#' + userId)
                lblExists = true;
        }

        if (!lblExists) {
 ");
            WriteLiteral(@"           var usersGroup = $('#divUsers');
            usersGroup.append('<div class=""col-lg-8 col-sm-12 col-12 row"" id =""div' + userId + '""><div class=""col-lg-8 col-sm-9 col-9 bold-large"">' + displayName + '</div><div class=""col-lg-4 col-lg-4 sm-3 col-3""> <a onclick=""removeUser(' + userId + ')"">  remove  </a></div></div>');

            users.push(displayName + '#' + userId);
            counterUsers++;

            var txtUserIds = $('#txtUserIds').val();
            if (txtUserIds != '')
                $('#txtUserIds').val(txtUserIds + ',' + userId);
            else
                $('#txtUserIds').val(userId);
        }

    }

    $(function () {

            $(""#txtUsers"").autocomplete({

                source: function (request, response) {
                    $.ajax({
                        url : '");
            EndContext();
            BeginContext(3241, 40, false);
#line 95 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\CreateUserGroup.cshtml"
                          Write(Url.Action("AutoCompleteUsers", "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(3281, 1103, true);
            WriteLiteral(@"',
                        data: ""{ 'prefix': '"" + request.term + ""'}"",
                        dataType: ""json"",
                        type: ""POST"",
                        contentType: ""application/json; charset=utf-8"",
                        success: function (data) {
                            response($.map(data, function (item) {
                                return item;
                            }))
                        },
                        error: function (response) {
                            //alert(response.responseText);
                        },
                        failure: function (response) {
                            //alert(response.responseText);
                        }
                    });
                },
                select: function (e, i) {

                    var lblExists = false;

                    addGridRow(i.item.label, i.item.val)

                    this.value = '';
                    return false;
            ");
            WriteLiteral("    },\r\n                minLength: 0\r\n            });\r\n    });\r\n\r\n</script>\r\n\r\n");
            EndContext();
#line 128 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\CreateUserGroup.cshtml"
 using (Html.BeginForm("CreateUserGroup", "Admin", FormMethod.Post, new { @class = "form-horizontal row card", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(4522, 23, false);
#line 130 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\CreateUserGroup.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(4552, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(4556, 2229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ef4ffac06544f1e8bb30552bbd2907e", async() => {
                BeginContext(4647, 588, true);
                WriteLiteral(@"

        <div class=""col-lg-12 col-12"">
            <br />
        </div>

        <div class=""col-lg-12 col-12"">
            <p class=""bold-largest"">Create a User Group</p>
            <p>
                User groups could be tagged in questions and announcements. It's the best way to notify a group of users.
                <br />
                Please enter group name and group descrption. You can select users to the group from 'add users' textbox.
            </p>
            <hr />
        </div>

        <div class=""col-lg-12 col-sm-12 col-12"">
            ");
                EndContext();
                BeginContext(5236, 99, false);
#line 149 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\CreateUserGroup.cshtml"
       Write(Html.TextBoxFor(m => m.groupName, new { @class = "form-control", placeholder = "user group name" }));

#line default
#line hidden
                EndContext();
                BeginContext(5335, 100, true);
                WriteLiteral("\r\n            <br />\r\n        </div>\r\n        <div class=\"col-lg-12 col-sm-12 col-12\">\r\n            ");
                EndContext();
                BeginContext(5436, 109, false);
#line 153 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\CreateUserGroup.cshtml"
       Write(Html.TextAreaFor(m => m.groupDescription, new { @class = "form-control", placeholder = "group description" }));

#line default
#line hidden
                EndContext();
                BeginContext(5545, 1233, true);
                WriteLiteral(@"
            <br />
        </div>
        <div class=""col-lg-4 col-sm-8 col-8"">
            <input class=""form-control"" placeholder=""add users"" type=""text"" id=""txtUsers"" name="""" />
        </div>

        <div id=""usersGroup""></div>

        <div class=""col-lg-12 col-sm-12 col-12"">
            <br />
        </div>

        <div class=""col-lg-12"">
            <div id=""divUsers"" class=""col-lg-12 col-sm-12 col-12 grid"">
                <div class=""col-lg-8 col-sm-12 col-12 grid_header row"">
                    <div class=""col-lg-8 col-sm-9 col-9"">
                        Name
                    </div>
                    <div class=""col-lg-4 col-sm-3 col-3"">
                        Action
                    </div>
                </div>

                <input type=""text"" id=""txtUserIds"" name=""txtUserIds"" hidden />

            </div>
        </div>

        <div class=""col-lg-12 col-sm-12 col-12"">
            <br />
        </div>

        <div class=""col-lg-12 col-sm-12 col");
                WriteLiteral("-12\">\r\n            <button id=\"submitClass\" class=\"btn btn-primary\" type=\"submit\">Submit</button>\r\n        </div>\r\n\r\n        <div class=\"col-lg-12 col-sm-12 col-12\">\r\n            <br />\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6785, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 195 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Admin\CreateUserGroup.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CuriousDriveWebClient.CreateUserGroupViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
