#pragma checksum "C:\Users\shrugs\OneDrive\Dojo_Assignment\JavaC#\ASP.NET_Core\DojoSurveyModel\Views\Home\Submission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b145bb1cf7f404b0b097454587590d1452d57d32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Submission), @"mvc.1.0.view", @"/Views/Home/Submission.cshtml")]
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
#line 1 "C:\Users\shrugs\OneDrive\Dojo_Assignment\JavaC#\ASP.NET_Core\DojoSurveyModel\Views\_ViewImports.cshtml"
using DojoSurveyModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shrugs\OneDrive\Dojo_Assignment\JavaC#\ASP.NET_Core\DojoSurveyModel\Views\_ViewImports.cshtml"
using DojoSurveyModel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b145bb1cf7f404b0b097454587590d1452d57d32", @"/Views/Home/Submission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e4289d96fd8ae90127722315813cc45e29f652a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Submission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\shrugs\OneDrive\Dojo_Assignment\JavaC#\ASP.NET_Core\DojoSurveyModel\Views\Home\Submission.cshtml"
  
    ViewData["title"] = "Dojo Survey Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1><b>Submitted Info</b></h1>\r\n<fieldset>\r\n    Name: ");
#nullable restore
#line 6 "C:\Users\shrugs\OneDrive\Dojo_Assignment\JavaC#\ASP.NET_Core\DojoSurveyModel\Views\Home\Submission.cshtml"
     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br></br>\r\n    Location: ");
#nullable restore
#line 7 "C:\Users\shrugs\OneDrive\Dojo_Assignment\JavaC#\ASP.NET_Core\DojoSurveyModel\Views\Home\Submission.cshtml"
         Write(Model.Locations);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br></br>\r\n    Favorite Language: ");
#nullable restore
#line 8 "C:\Users\shrugs\OneDrive\Dojo_Assignment\JavaC#\ASP.NET_Core\DojoSurveyModel\Views\Home\Submission.cshtml"
                  Write(Model.Languages);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br></br>\r\n    Comment: ");
#nullable restore
#line 9 "C:\Users\shrugs\OneDrive\Dojo_Assignment\JavaC#\ASP.NET_Core\DojoSurveyModel\Views\Home\Submission.cshtml"
        Write(Model.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br></br>\r\n</fieldset> \r\n<button button-primary>\r\n    <a href=\"/\">Go Back</a>\r\n</button>");
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
