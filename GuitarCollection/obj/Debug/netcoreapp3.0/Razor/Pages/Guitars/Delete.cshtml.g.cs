#pragma checksum "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dce3fbda5d9d947570d46ac424a9b299e841aca5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GuitarCollection.Pages.Guitars.Pages_Guitars_Delete), @"mvc.1.0.razor-page", @"/Pages/Guitars/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce3fbda5d9d947570d46ac424a9b299e841aca5", @"/Pages/Guitars/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c53e2200bab909a9d97e7a3283c63088cbb356d4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Guitars_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml"
  
	ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n\t<h4>Guitar</h4>\r\n\t<hr />\r\n\t<dl class=\"row\">\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 16 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Guitar.GuitarType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 19 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Guitar.GuitarType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 22 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Guitar.GuitarBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 25 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Guitar.GuitarBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 28 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Guitar.NumStrings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 31 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Guitar.NumStrings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 34 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Guitar.StringBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 37 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Guitar.StringBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t</dl>\r\n\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce3fbda5d9d947570d46ac424a9b299e841aca57357", async() => {
                WriteLiteral("\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dce3fbda5d9d947570d46ac424a9b299e841aca57619", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 42 "C:\Users\Mike\source\repos\GuitarCollection\GuitarCollection\Pages\Guitars\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Guitar.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t<input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce3fbda5d9d947570d46ac424a9b299e841aca59413", async() => {
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
                WriteLiteral("\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GuitarCollection.Pages.Guitars.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GuitarCollection.Pages.Guitars.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GuitarCollection.Pages.Guitars.DeleteModel>)PageContext?.ViewData;
        public GuitarCollection.Pages.Guitars.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
