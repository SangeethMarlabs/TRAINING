#pragma checksum "D:\SAN\TRAINING\Day12\Codes\Marlabs_PartialView_Ex1\Marlabs_PartialView_Ex1\Views\Products\GetProdctsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fd6b13c46f7c75883ec4210f11bcfe40c4abaca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_GetProdctsList), @"mvc.1.0.view", @"/Views/Products/GetProdctsList.cshtml")]
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
#line 1 "D:\SAN\TRAINING\Day12\Codes\Marlabs_PartialView_Ex1\Marlabs_PartialView_Ex1\Views\_ViewImports.cshtml"
using Marlabs_PartialView_Ex1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SAN\TRAINING\Day12\Codes\Marlabs_PartialView_Ex1\Marlabs_PartialView_Ex1\Views\_ViewImports.cshtml"
using Marlabs_PartialView_Ex1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd6b13c46f7c75883ec4210f11bcfe40c4abaca", @"/Views/Products/GetProdctsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1af12e4e1da2cf26f4f24a5695cb769663c5c48", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_GetProdctsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\SAN\TRAINING\Day12\Codes\Marlabs_PartialView_Ex1\Marlabs_PartialView_Ex1\Views\Products\GetProdctsList.cshtml"
  
    ViewData["Title"] = "GetProdctsList";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd6b13c46f7c75883ec4210f11bcfe40c4abaca3466", async() => {
                WriteLiteral("\r\n    <title>\r\n        Marlabs Products\r\n    </title>\r\n");
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
            WriteLiteral(@"
<h1>Marlabs</h1>
<h2>Products List</h2>
<p>

    Xiaomi Corporation, registered in Asia as Xiaomi Inc., is a Chinese designer and manufacturer of consumer electronics and 
    related software, home appliances, and household items. Behind Samsung, it is the second largest manufacturer of 
    smartphones, most of which run the MIUI operating system, (software development). In 2020, the company sold 146.3 
    million smartphones and its MIUI operating system has over 500 million monthly active users.
    [3] It also is a major manufacturer of appliances including televisions, flashlights, 
    unmanned aerial vehicles, and air purifiers using its Internet of Things and Xiaomi Smart 
    Home product ecosystems. The name ""Xiaomi"" literally means millet and rice, and is based on 
    the Buddhist concept of starting from the bottom before aiming for the top.
</p>
");
#nullable restore
#line 23 "D:\SAN\TRAINING\Day12\Codes\Marlabs_PartialView_Ex1\Marlabs_PartialView_Ex1\Views\Products\GetProdctsList.cshtml"
Write(Html.Partial("ProductsPartialView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "D:\SAN\TRAINING\Day12\Codes\Marlabs_PartialView_Ex1\Marlabs_PartialView_Ex1\Views\Products\GetProdctsList.cshtml"
Write(Html.Partial("SharedFooter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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