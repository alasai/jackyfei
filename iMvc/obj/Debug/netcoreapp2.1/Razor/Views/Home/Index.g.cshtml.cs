#pragma checksum "F:\github\jackyfei\iMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05c8b459728d10f4afe840e15b4d5081d4b6e6b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 22 "F:\github\jackyfei\iMvc\Views\Home\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05c8b459728d10f4afe840e15b4d5081d4b6e6b8", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(336, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 24 "F:\github\jackyfei\iMvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(472, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<h4>Name:");
            EndContext();
            BeginContext(502, 15, false);
#line 30 "F:\github\jackyfei\iMvc\Views\Home\Index.cshtml"
    Write(_stu.Value.Name);

#line default
#line hidden
            EndContext();
            BeginContext(517, 15, true);
            WriteLiteral("</h4>\r\n<h4>Age:");
            EndContext();
            BeginContext(533, 14, false);
#line 31 "F:\github\jackyfei\iMvc\Views\Home\Index.cshtml"
   Write(_stu.Value.Age);

#line default
#line hidden
            EndContext();
            BeginContext(547, 16, true);
            WriteLiteral("</h4>\r\n\r\n<div>\r\n");
            EndContext();
#line 34 "F:\github\jackyfei\iMvc\Views\Home\Index.cshtml"
     foreach (var s in _stu.Value.Students)
    {

#line default
#line hidden
            BeginContext(615, 19, true);
            WriteLiteral("        <span>Name:");
            EndContext();
            BeginContext(635, 6, false);
#line 36 "F:\github\jackyfei\iMvc\Views\Home\Index.cshtml"
              Write(s.Name);

#line default
#line hidden
            EndContext();
            BeginContext(641, 27, true);
            WriteLiteral("</span>\r\n        <span>Age:");
            EndContext();
            BeginContext(669, 5, false);
#line 37 "F:\github\jackyfei\iMvc\Views\Home\Index.cshtml"
             Write(s.Age);

#line default
#line hidden
            EndContext();
            BeginContext(674, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 38 "F:\github\jackyfei\iMvc\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(690, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptionsSnapshot<iMvc.StudentClass> _stu { get; private set; }
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
