#pragma checksum "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1fbb27d1d99b08b467efe8d014b1872094c520"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Details), @"mvc.1.0.view", @"/Views/Usuario/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1fbb27d1d99b08b467efe8d014b1872094c520", @"/Views/Usuario/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8908b10a08f497ece5ba40e48d697da6f928b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AgendaMedica_WEB.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h4>Usuário</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 44 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 54 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rua));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 61 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rua));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 67 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 68 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 75 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 82 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 89 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 96 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 97 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            \r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 103 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Administrador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 104 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Administrador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            \r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Medico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 111 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Medico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            \r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Atendente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 118 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Atendente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            \r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 125 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CriadoEm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 126 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.CriadoEm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            \r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f1fbb27d1d99b08b467efe8d014b1872094c52015144", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 134 "D:\Repos_GitHub\ProdutosMicrosoft\AgendaMedica_WEB\AgendaMedica_WEB\Views\Usuario\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f1fbb27d1d99b08b467efe8d014b1872094c52017305", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgendaMedica_WEB.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591