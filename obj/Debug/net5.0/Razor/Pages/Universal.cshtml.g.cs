#pragma checksum "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57c57cfe85dcae862c00550ad384879074a771d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Final_Project.Pages.Pages_Universal), @"mvc.1.0.razor-page", @"/Pages/Universal.cshtml")]
namespace Final_Project.Pages
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
#line 1 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\_ViewImports.cshtml"
using Final_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c57cfe85dcae862c00550ad384879074a771d3", @"/Pages/Universal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4e01f086f23dffc917b0fe0d92d51f11a37614f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Universal : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
  
    ViewData["Title"] = "Universal Music Group";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Universal Music Group</h1>\r\n<p>");
#nullable restore
#line 7 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
Write(Model.RecordLabels[0].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
           Write(Html.DisplayNameFor(model => model.Artists[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
           Write(Html.DisplayNameFor(model => model.Artists[0].Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
           Write(Html.DisplayNameFor(model => model.Artists[0].Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
           Write(Html.DisplayNameFor(model => model.Artists[0].RecordLabel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
         foreach(var artist in Model.Artists){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 29 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
                 if(artist.RecordLabelID == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th scope=\"row\">");
#nullable restore
#line 31 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
                           Write(Html.DisplayFor(modelItem => artist.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
               Write(Html.DisplayFor(modelItem => artist.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
               Write(Html.DisplayFor(modelItem => artist.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
               Write(Html.DisplayFor(modelItem => artist.RecordLabel.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\micha\OneDrive - West Texas A and M University\Advanced Business Programming\Final Project\Final-Project\Pages\Universal.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversalModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UniversalModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UniversalModel>)PageContext?.ViewData;
        public UniversalModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
