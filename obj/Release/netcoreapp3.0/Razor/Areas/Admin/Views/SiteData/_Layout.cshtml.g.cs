#pragma checksum "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\SiteData\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "678f19b6b7c47b887f3a6afc595c45b68d37f898"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SiteData__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/SiteData/_Layout.cshtml")]
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
#line 1 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\_ViewImports.cshtml"
using Prototype;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\_ViewImports.cshtml"
using Prototype.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\SiteData\_Layout.cshtml"
using System.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678f19b6b7c47b887f3a6afc595c45b68d37f898", @"/Areas/Admin/Views/SiteData/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a285dd65e684806d857970f39ee2bf05b1dcc282", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SiteData__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\SiteData\_Layout.cshtml"
   
    ViewData["Title"] = "_Layout";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Site Index</h1>\r\n<div>\r\n\r\n    \r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 14 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\SiteData\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
