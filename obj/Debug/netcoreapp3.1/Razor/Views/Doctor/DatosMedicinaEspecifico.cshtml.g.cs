#pragma checksum "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "160398d2df34df2e67d72b1460a649269b20c3aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_DatosMedicinaEspecifico), @"mvc.1.0.view", @"/Views/Doctor/DatosMedicinaEspecifico.cshtml")]
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
#line 1 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\_ViewImports.cshtml"
using DocWeb_Prueba;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\_ViewImports.cshtml"
using DocWeb_Prueba.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"160398d2df34df2e67d72b1460a649269b20c3aa", @"/Views/Doctor/DatosMedicinaEspecifico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d130e08d4d5cf34f967f7c4aa61361befe68e8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_DatosMedicinaEspecifico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DocWeb_Prueba.Models.Medicina>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Doctor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "datosMedicinaEspecificos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
  
    ViewBag.Title = "Doctor Page";
    Layout = "~/Views/_LayoutDoctor.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Administrador</h2>\r\n<div class=\"card mb-4\">\r\n    <div class=\"card-body\">\r\n        <!-- Grid row -->\r\n        <div class=\"row\">\r\n            <!-- Grid column -->\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "160398d2df34df2e67d72b1460a649269b20c3aa5217", async() => {
                WriteLiteral(@"
                <div class=""input-group md-form form-sm form-2 pl-0"" margin=""50px"">
                    <input class=""form-control my-0 py-1 pl-3 purple-border"" type=""text"" name=""nombreMedicina"" placeholder=""Nombre de Medicina..."" aria-label=""Search"" />
                    <span class=""input-group-addon waves-effect purple lighten-2"" id=""basic-addon1""></span>
                    <button type=""submit"" class=""btn btn-primary"" value=""btn"" name=""grabar"" data-toggle=""modal"" data-target=""#exampleModal"">Buscar</button>
                    <span class=""text-danger"">");
#nullable restore
#line 18 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
                                         Write(ViewData["Error_Mensaje"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </div>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <!-- Grid column -->
        </div>
        <!-- Grid row -->
        <!--Table-->
        <table class=""table table-striped"">
            <!--Table head-->
            <thead>
                <tr>
                    <th>Codigo de Medicina</th>
                    <th>Nombre de Medicina</th>
                    <th>Receta Medica</th>
                    <th>Cantidad</th>
                    <th>Precio</th>
                    <th>Tipo</th>
                    <th>Clinica ID</th>
                </tr>
            </thead>
            <!--Table head-->
            <!--Table body-->
            <tbody>
");
#nullable restore
#line 42 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
                 foreach (var img in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
                       Write(img.id_medicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
                       Write(img.nombre_medicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
                       Write(img.receta_medica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
                       Write(img.cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
                       Write(img.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
                       Write(img.tipoNombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
                       Write(img.id_clinica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\david\OneDrive\Escritorio\2020-02\Multiplataforma\DocWeb_Prueba\DocWeb_Prueba\Views\Doctor\DatosMedicinaEspecifico.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <!--Table body-->\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DocWeb_Prueba.Models.Medicina>> Html { get; private set; }
    }
}
#pragma warning restore 1591
