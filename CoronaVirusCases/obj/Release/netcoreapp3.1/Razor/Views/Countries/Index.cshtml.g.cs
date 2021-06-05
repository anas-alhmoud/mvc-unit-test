#pragma checksum "D:\repos\CoronaVirusCases\CoronaVirusCases\Views\Countries\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d6c73327a28e4e9f96e5279cb41f3b9496c96a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Countries_Index), @"mvc.1.0.view", @"/Views/Countries/Index.cshtml")]
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
#line 1 "D:\repos\CoronaVirusCases\CoronaVirusCases\Views\_ViewImports.cshtml"
using CoronaVirusCases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\CoronaVirusCases\CoronaVirusCases\Views\_ViewImports.cshtml"
using CoronaVirusCases.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6c73327a28e4e9f96e5279cb41f3b9496c96a8", @"/Views/Countries/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39084e8eb01ff8d72aa11d20e903cb231dc2b38e", @"/Views/_ViewImports.cshtml")]
    public class Views_Countries_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\repos\CoronaVirusCases\CoronaVirusCases\Views\Countries\Index.cshtml"
  
    GlobalModel globalCases = (GlobalModel) ViewData["GlobalCases"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center"" style=""color: white; padding-top:200px"">Global Corona Virus Cases</h2>

<div class=""container"">
    <div class=""row row-cols-1 row-cols-md-2 g-4 text-center"">
        <div class=""col-6 mt-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""mb-0"">
                        Total Confirmed: <span style=""color: #e4c857"">");
#nullable restore
#line 13 "D:\repos\CoronaVirusCases\CoronaVirusCases\Views\Countries\Index.cshtml"
                                                                 Write(globalCases.TotalConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </h5>\r\n                    <h5 class=\"mb-0\">\r\n                        New Confirmed: <span style=\"color: #e4c857\">");
#nullable restore
#line 16 "D:\repos\CoronaVirusCases\CoronaVirusCases\Views\Countries\Index.cshtml"
                                                               Write(globalCases.NewConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </h5>
                </div>
            </div>
        </div>
        <div class=""col-6 mt-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""mb-0"">
                        Total Deaths: <span style=""color:red"">");
#nullable restore
#line 25 "D:\repos\CoronaVirusCases\CoronaVirusCases\Views\Countries\Index.cshtml"
                                                         Write(globalCases.TotalDeaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </h5>\r\n                    <h5 class=\"mb-0\">\r\n                        New Deaths: <span style=\"color:red\">");
#nullable restore
#line 28 "D:\repos\CoronaVirusCases\CoronaVirusCases\Views\Countries\Index.cshtml"
                                                       Write(globalCases.NewDeaths);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </h5>
                </div>
            </div>
        </div>
        </div>
        <div class=""col-14 mt-4 text-center"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""mb-0"">
                        Total Recovered: <span style=""color:#8ACA2B"">");
#nullable restore
#line 38 "D:\repos\CoronaVirusCases\CoronaVirusCases\Views\Countries\Index.cshtml"
                                                                Write(globalCases.TotalRecovered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </h5>\r\n                    <h5 class=\"mb-0\">\r\n                        New Recovered: <span style=\"color:#8ACA2B\">");
#nullable restore
#line 41 "D:\repos\CoronaVirusCases\CoronaVirusCases\Views\Countries\Index.cshtml"
                                                              Write(globalCases.NewRecovered);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </h5>
                </div>
            </div>
        </div>
    </div>
    <div class=""pt-5 text-center"">
        <a href=""/countries/global"">
            <button class=""btn btn-danger"">Go to map</button>
        </a>
    </div>
</div>");
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
