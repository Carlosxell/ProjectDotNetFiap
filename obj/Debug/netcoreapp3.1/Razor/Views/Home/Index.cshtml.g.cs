#pragma checksum "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e246079eb187a13ce443c9dd6e628c6752fcefc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\_ViewImports.cshtml"
using DadosSensoresMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\_ViewImports.cshtml"
using DadosSensoresMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e246079eb187a13ce443c9dd6e628c6752fcefc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c273b7ab6093f5f6fb38c585c9bab5e03af1fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DadosSensoresMvc.Models.DadosSensores>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Página Inicial";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"boxContainer\">\r\n\t<div class=\"py-4\">\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e246079eb187a13ce443c9dd6e628c6752fcefc4659", async() => {
                WriteLiteral("\r\n\t\t\tCadastrar\r\n\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</div>\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
     if (Model.Count() < 1)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<p class=\"alert alert-danger w-100 text-center\">Nenhum Dado Cadastrado</p>\r\n");
#nullable restore
#line 19 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<div class=""table-responsive"">
			<table class=""table table-bordered table-hover table-sm"">
				<thead class=""thead-dark"">
					<tr>
						<th scope=""col"">
							<span class=""d-inline-block text-center"">#</span>
						</th>
						<th scope=""col"">Data/Hora</th>
						<th scope=""col"">Temperatura</th>
						<th scope=""col"">Umidade</th>
						<th scope=""col"">Ações</th>
					</tr>
				</thead>

				<tbody>
");
#nullable restore
#line 37 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
                       int count = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
                     foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<th scope=\"row\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 42 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</th>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 44 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
                           Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 45 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
                           Write(item.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral("°C</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 46 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
                           Write(item.Umidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
							<td>
								<div class=""w-100 text-center"">
									<button class=""btn btn-sm btn-outline-danger"" disabled type=""button"">Deletar</button>
									<!--
									<a class=""btn btn-sm btn-link"" asp-area="""" asp-controller=""Editar"" asp-action=""Index"">Editar</a>
									-->
								</div>
							</td>
						</tr>
");
#nullable restore
#line 56 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
						count++;
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t</div>\r\n");
#nullable restore
#line 61 "C:\Users\Usuario\source\repos\DadosSensoresMvc\Views\Home\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DadosSensoresMvc.Models.DadosSensores>> Html { get; private set; }
    }
}
#pragma warning restore 1591
