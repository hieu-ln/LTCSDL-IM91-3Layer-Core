#pragma checksum "E:\Teaching\IT\OU\HK211\LTCSDL\Code\IM91_3Layer\LTCSDL-IM91-3Layer\LTCSDL-IM91-3Layer\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "726b501985363feec9108a8e10f38084a7bf6eb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LTCSDL_IM91_3Layer.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace LTCSDL_IM91_3Layer.Pages
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
#line 1 "E:\Teaching\IT\OU\HK211\LTCSDL\Code\IM91_3Layer\LTCSDL-IM91-3Layer\LTCSDL-IM91-3Layer\Pages\_ViewImports.cshtml"
using LTCSDL_IM91_3Layer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"726b501985363feec9108a8e10f38084a7bf6eb3", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b4567b1e9ede395fd673320211731c053a6f3f1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Teaching\IT\OU\HK211\LTCSDL\Code\IM91_3Layer\LTCSDL-IM91-3Layer\LTCSDL-IM91-3Layer\Pages\Index.cshtml"
  
    ViewData["Title"] = "Xin chào lớp IM91 dễ thương !!!";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Lớp IM91 thật dễ thương !!!</h1>
    <p>Danh sách cách Category lấy được:</p>
    <table class=""table-bordered"">
        <tr>
            <th>ID</th>
            <th>Category Name</th>
            <th>Description</th>
        </tr>
");
#nullable restore
#line 16 "E:\Teaching\IT\OU\HK211\LTCSDL\Code\IM91_3Layer\LTCSDL-IM91-3Layer\LTCSDL-IM91-3Layer\Pages\Index.cshtml"
         foreach (var cat in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "E:\Teaching\IT\OU\HK211\LTCSDL\Code\IM91_3Layer\LTCSDL-IM91-3Layer\LTCSDL-IM91-3Layer\Pages\Index.cshtml"
               Write(cat.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n                <td>");
#nullable restore
#line 20 "E:\Teaching\IT\OU\HK211\LTCSDL\Code\IM91_3Layer\LTCSDL-IM91-3Layer\LTCSDL-IM91-3Layer\Pages\Index.cshtml"
               Write(cat.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n                <td>");
#nullable restore
#line 21 "E:\Teaching\IT\OU\HK211\LTCSDL\Code\IM91_3Layer\LTCSDL-IM91-3Layer\LTCSDL-IM91-3Layer\Pages\Index.cshtml"
               Write(cat.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "E:\Teaching\IT\OU\HK211\LTCSDL\Code\IM91_3Layer\LTCSDL-IM91-3Layer\LTCSDL-IM91-3Layer\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
