#pragma checksum "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\SiteData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c172fdadce8bace6677f792565ab63fba10e4d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SiteData_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SiteData/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c172fdadce8bace6677f792565ab63fba10e4d3", @"/Areas/Admin/Views/SiteData/Index.cshtml")]
    public class Areas_Admin_Views_SiteData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Prototype.Models.SiteData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\SiteData\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card mb-3\">\r\n    <div class=\"card-header\">\r\n        Current Website Link\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h1 class=\"card-title\">\r\n            ");
#nullable restore
#line 14 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\SiteData\Index.cshtml"
       Write(Html.DisplayFor(model => model.Website_Link));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </h1>
    </div>
    <div class=""card-footer"">
        <a href=""#"" class="" btn btn-danger"">Edit</a>
    </div>
</div>

<div class=""card mb-3"">
    <div class=""card-header"">
        Participate Phase
    </div>
    <div class=""card-body"">
        <h1 class=""card-title"">
            ");
#nullable restore
#line 28 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\SiteData\Index.cshtml"
       Write(Html.DisplayFor(model => model.Participate_Phase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        <a href=\"#\" class=\" btn btn-danger\">Edit</a>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prototype.Models.SiteData> Html { get; private set; }
    }
}
#pragma warning restore 1591