#pragma checksum "F:\2020-2021_HK2\điện toán đám mây\Cloud-Computing-Final-Project-main\cloudcomputing\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0e73b5247f005b6d59c1c9b683305acf8da6690"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "F:\2020-2021_HK2\điện toán đám mây\Cloud-Computing-Final-Project-main\cloudcomputing\Views\_ViewImports.cshtml"
using cloudcomputing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\2020-2021_HK2\điện toán đám mây\Cloud-Computing-Final-Project-main\cloudcomputing\Views\_ViewImports.cshtml"
using cloudcomputing.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e73b5247f005b6d59c1c9b683305acf8da6690", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cffaf298204da6cd6e471decb52260c21d1e9140", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "F:\2020-2021_HK2\điện toán đám mây\Cloud-Computing-Final-Project-main\cloudcomputing\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0e73b5247f005b6d59c1c9b683305acf8da66903474", async() => {
                WriteLiteral("\n    <h1>Login</h1>\n    <h2>\n        <input id=\"username\" type=\"text\" autocomplete=\"off\"");
                BeginWriteAttribute("value", " value=\"", 181, "\"", 189, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"username...\" />\n    </h2>\n    <h3>\n        <input id=\"password\" type=\"password\" autocomplete=\"off\"");
                BeginWriteAttribute("value", " value=\"", 302, "\"", 310, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"password...\" />\n    </h3>\n    <h4>\n        <button onclick=\"login()\" class=\"btn btn-outline-primary\">Login</button>\n    </h4>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<script>\n    let _listUsers = ");
#nullable restore
#line 22 "F:\2020-2021_HK2\điện toán đám mây\Cloud-Computing-Final-Project-main\cloudcomputing\Views\Home\Login.cshtml"
                Write(Html.Raw(ViewBag.ListUser));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    
    function login() {
        var _userName = $(""#username"").val();
        var _passWord = $(""#password"").val();

        for (var i = 0; i < _listUsers.length; i++) {
            if (_userName == _listUsers[i].Username) {
                if (_passWord == _listUsers[i].Password) {
                    localStorage.setItem(""username"", _userName);
                    window.location.href = ""/trang-chu"";
                    break;

                } else {
                    alert(""Login failed *"");
                }
            } else {
                if (i == _listUsers.length - 1) {
                    alert(""Login failed"");
                } 
            }  
        }
    }
</script>
");
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
