#pragma checksum "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d55de1fe34d742fb00caf2d98817ca5a0443b1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GuitarCollection.Pages.Guitars.Pages_Guitars_Details), @"mvc.1.0.razor-page", @"/Pages/Guitars/Details.cshtml")]
namespace GuitarCollection.Pages.Guitars
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
#line 1 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\_ViewImports.cshtml"
using GuitarCollection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d55de1fe34d742fb00caf2d98817ca5a0443b1a", @"/Pages/Guitars/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c53e2200bab909a9d97e7a3283c63088cbb356d4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Guitars_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml"
  
	ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n\t<h4>Guitar</h4>\r\n\t<hr />\r\n\t<dl class=\"row\">\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 15 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Guitar.GuitarType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 18 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Guitar.GuitarType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 21 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Guitar.GuitarBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 24 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Guitar.GuitarBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 27 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Guitar.NumStrings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 30 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Guitar.NumStrings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 33 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Guitar.StringBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 36 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Guitar.StringBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t</dl>\r\n</div>\r\n<div>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d55de1fe34d742fb00caf2d98817ca5a0443b1a6635", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Details.cshtml"
                           WriteLiteral(Model.Guitar.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d55de1fe34d742fb00caf2d98817ca5a0443b1a8790", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GuitarCollection.Pages.Guitars.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GuitarCollection.Pages.Guitars.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GuitarCollection.Pages.Guitars.DetailsModel>)PageContext?.ViewData;
        public GuitarCollection.Pages.Guitars.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591