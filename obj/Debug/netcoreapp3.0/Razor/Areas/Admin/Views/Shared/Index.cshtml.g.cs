#pragma checksum "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b0ce3af5e3f7464d46160385d5e83b8fe987315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Index.cshtml")]
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
#line 1 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml"
using Prototype.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b0ce3af5e3f7464d46160385d5e83b8fe987315", @"/Areas/Admin/Views/Shared/Index.cshtml")]
    public class Areas_Admin_Views_Shared_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PrototypeUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml"
  
    ViewBag.Title = "All Users;";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""mySidenav"" class=""sidenav"">

    <a class=""nav-link text-white"" asp-controller=""Home"" asp-action=""Index"">Index</a>
    <a class=""nav-link text-white"" asp-area=""Admin"" asp-controller=""Home"" asp-action=""ListUsers"">List Users</a>
    <a href=""#"">Clients</a>
    <a href=""#"">Contact</a>
</div>


<h1>All Users </h1>

");
#nullable restore
#line 26 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a asp-area=\"Identity\" asp-page=\"/Account/Register\" class=\"btn btn-primary mb-3\" style=\"width:auto\">\r\n        Add New User\r\n    </a>\r\n");
#nullable restore
#line 31 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml"

    foreach (var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <div class=\" = \" card-header>\r\n                User Id ; ");
#nullable restore
#line 36 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml"
                     Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 39 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml"
                                  Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                <a href=\"#\" class=\" = \" btn btn-danger\">Edit</a>\r\n                <a href=\"#\" class=\" = \" btn btn-danger\">Delete</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 46 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card"">
        <div class="" = "" card-header>
            No Users Created Yet
        </div>
        <div class=""card-body"">
            <h5 class=""card-title"">User the Button To Create a User</h5>
        </div>
        <a asp-action=""Register"" asp-controller=""Home"" class=""btn btn-primary mb-3"" style=""width:auto"">
            Add New User
        </a>

    </div>
");
#nullable restore
#line 62 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Shared\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PrototypeUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
