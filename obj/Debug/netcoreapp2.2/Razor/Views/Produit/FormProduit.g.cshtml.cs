#pragma checksum "H:\Project_Catalogue_Produits\Views\Produit\FormProduit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "819a20d2ec0f07b52b4471dad17e63eeb5cfe478"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produit_FormProduit), @"mvc.1.0.view", @"/Views/Produit/FormProduit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produit/FormProduit.cshtml", typeof(AspNetCore.Views_Produit_FormProduit))]
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
#line 1 "H:\Project_Catalogue_Produits\Views\_ViewImports.cshtml"
using Project_Catalogue_Produits;

#line default
#line hidden
#line 2 "H:\Project_Catalogue_Produits\Views\_ViewImports.cshtml"
using Project_Catalogue_Produits.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819a20d2ec0f07b52b4471dad17e63eeb5cfe478", @"/Views/Produit/FormProduit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88479e7e6c92af34b607f99b381ed467bbe08ca0", @"/Views/_ViewImports.cshtml")]
    public class Views_Produit_FormProduit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_Catalogue_Produits.Service.Produit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveProduit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\Project_Catalogue_Produits\Views\Produit\FormProduit.cshtml"
  
    ViewData["Title"] = "FormProduit";

#line default
#line hidden
            BeginContext(99, 63, true);
            WriteLiteral("\r\n<h1>FormProduit</h1>\r\n<div class=\"container col-md-10\">\r\n    ");
            EndContext();
            BeginContext(162, 766, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819a20d2ec0f07b52b4471dad17e63eeb5cfe4784194", async() => {
                BeginContext(207, 48, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(256, 67, false);
#line 10 "H:\Project_Catalogue_Produits\Views\Produit\FormProduit.cshtml"
       Write(Html.LabelFor(p => p.Designation, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(323, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(338, 68, false);
#line 11 "H:\Project_Catalogue_Produits\Views\Produit\FormProduit.cshtml"
       Write(Html.TextBoxFor(p => p.Designation, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(406, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(421, 81, false);
#line 12 "H:\Project_Catalogue_Produits\Views\Produit\FormProduit.cshtml"
       Write(Html.ValidationMessageFor(p => p.Designation, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(502, 64, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(567, 60, false);
#line 15 "H:\Project_Catalogue_Produits\Views\Produit\FormProduit.cshtml"
       Write(Html.LabelFor(p => p.Prix, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(627, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(642, 61, false);
#line 16 "H:\Project_Catalogue_Produits\Views\Produit\FormProduit.cshtml"
       Write(Html.TextBoxFor(p => p.Prix, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(703, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(718, 74, false);
#line 17 "H:\Project_Catalogue_Produits\Views\Produit\FormProduit.cshtml"
       Write(Html.ValidationMessageFor(p => p.Prix, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(792, 129, true);
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">VALIDER</button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(928, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_Catalogue_Produits.Service.Produit> Html { get; private set; }
    }
}
#pragma warning restore 1591
