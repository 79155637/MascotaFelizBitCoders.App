#pragma checksum "C:\WebTic\MascotaFelizBitCoders.App\MascotaFeliz.App.FrontEnd\Pages\Mascotas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f655da7d1714b4f545acb93566aa7ebd1a3f25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.FrontEnd.Pages.Mascotas.Pages_Mascotas_Details), @"mvc.1.0.razor-page", @"/Pages/Mascotas/Details.cshtml")]
namespace MascotaFeliz.App.FrontEnd.Pages.Mascotas
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
#line 1 "C:\WebTic\MascotaFelizBitCoders.App\MascotaFeliz.App.FrontEnd\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f655da7d1714b4f545acb93566aa7ebd1a3f25", @"/Pages/Mascotas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f61529ad7174ebf84a554cdb38517f05330d9b", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Mascotas_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h2>Datos Detallados de Mascota: ");
#nullable restore
#line 5 "C:\WebTic\MascotaFelizBitCoders.App\MascotaFeliz.App.FrontEnd\Pages\Mascotas\Details.cshtml"
                            Write(Model.Mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("  con IDENTIFICACIÓN: ");
#nullable restore
#line 5 "C:\WebTic\MascotaFelizBitCoders.App\MascotaFeliz.App.FrontEnd\Pages\Mascotas\Details.cshtml"
                                                                       Write(Model.Mascota.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    Nombre: ");
#nullable restore
#line 7 "C:\WebTic\MascotaFelizBitCoders.App\MascotaFeliz.App.FrontEnd\Pages\Mascotas\Details.cshtml"
       Write(Model.Mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Color: ");
#nullable restore
#line 10 "C:\WebTic\MascotaFelizBitCoders.App\MascotaFeliz.App.FrontEnd\Pages\Mascotas\Details.cshtml"
      Write(Model.Mascota.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Raza: ");
#nullable restore
#line 13 "C:\WebTic\MascotaFelizBitCoders.App\MascotaFeliz.App.FrontEnd\Pages\Mascotas\Details.cshtml"
     Write(Model.Mascota.Raza);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Genero ");
#nullable restore
#line 16 "C:\WebTic\MascotaFelizBitCoders.App\MascotaFeliz.App.FrontEnd\Pages\Mascotas\Details.cshtml"
      Write(Model.Mascota.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    FechaNacimiento: ");
#nullable restore
#line 19 "C:\WebTic\MascotaFelizBitCoders.App\MascotaFeliz.App.FrontEnd\Pages\Mascotas\Details.cshtml"
                Write(Model.Mascota.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n");
            WriteLiteral("</div>\r\n<div>\r\n");
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73f655da7d1714b4f545acb93566aa7ebd1a3f255809", async() => {
                WriteLiteral("Volver a la Lista de Mascotas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.FrontEnd.Pages.Mascotas.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.FrontEnd.Pages.Mascotas.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.FrontEnd.Pages.Mascotas.DetailsModel>)PageContext?.ViewData;
        public MascotaFeliz.App.FrontEnd.Pages.Mascotas.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591