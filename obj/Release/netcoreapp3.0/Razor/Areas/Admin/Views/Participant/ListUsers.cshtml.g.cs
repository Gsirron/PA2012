#pragma checksum "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Participant\ListUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c79d3a3045fb7d83c15de036741f1fcbdc25d6dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Participant_ListUsers), @"mvc.1.0.view", @"/Areas/Admin/Views/Participant/ListUsers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79d3a3045fb7d83c15de036741f1fcbdc25d6dc", @"/Areas/Admin/Views/Participant/ListUsers.cshtml")]
    public class Areas_Admin_Views_Participant_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable< Prototype.Areas.Admin.Models.Participant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Participant\ListUsers.cshtml"
  
    
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <h2>");
#nullable restore
#line 9 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Participant\ListUsers.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

<p>

</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Participant Email
            </th>

            <th>
                Participant Data
            </th>

            <th></th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 30 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Participant\ListUsers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Participant\ListUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Participant_Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Participant\ListUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Participant_Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a asp-page=\"/Edit\">Edit</a> |\r\n                    <a asp-page=\"/Details\">Details</a> |\r\n                    <a asp-page=\"/Delete\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 45 "F:\Unistuff\PX\Project\Prototype\Areas\Admin\Views\Participant\ListUsers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    \r\n</table>\r\n<a class=\"btn btn-primary mb-3 text-white\" style=\"width:auto\">\r\n    Export to CSV\r\n</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable< Prototype.Areas.Admin.Models.Participant>> Html { get; private set; }
    }
}
#pragma warning restore 1591