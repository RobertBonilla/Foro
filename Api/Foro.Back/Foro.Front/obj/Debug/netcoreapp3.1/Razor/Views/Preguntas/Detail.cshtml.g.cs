#pragma checksum "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "117d61040d5ee61d60f6942a508f05478fa4db59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Preguntas_Detail), @"mvc.1.0.view", @"/Views/Preguntas/Detail.cshtml")]
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
#line 1 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\_ViewImports.cshtml"
using Foro.Front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\_ViewImports.cshtml"
using Foro.Front.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"117d61040d5ee61d60f6942a508f05478fa4db59", @"/Views/Preguntas/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87caa266752c1f8053c05408c9a608c36d21c67d", @"/Views/_ViewImports.cshtml")]
    public class Views_Preguntas_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmRespuesta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
  
    ViewData["Title"] = "Pregunta [Detalle]";
    Foro.Front.Models.Dto.DetallePregunta data = (Foro.Front.Models.Dto.DetallePregunta)ViewData["ListaModel"];
    Foro.Front.Models.Dto.PreguntaDto Pregunta = data.Pregunta;
    Foro.Front.Models.Domain.Usuario userSession = (ViewData["UserModel"] != null) ? (Foro.Front.Models.Domain.Usuario)ViewData["UserModel"] : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Pregunta</h1>\r\n    <input type=\"hidden\" class=\"form-control\" id=\"idPreguntaVal\" readonly");
            BeginWriteAttribute("value", " value=\"", 525, "\"", 553, 1);
#nullable restore
#line 10 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
WriteAttributeValue("", 533, Pregunta.idPregunta, 533, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n<div>\r\n    <div class=\"card border-primary mb-3\">\r\n        <div class=\"card-header\">\r\n            [");
#nullable restore
#line 15 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
        Write(Pregunta.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 15 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                          Write(Pregunta.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")]
        </div>
        <div class=""card-body"">
            <div class=""mb-3"">
                <label for=""titulo"" class=""form-label"">Titulo</label>
                <input type=""text"" class=""form-control"" id=""titulo"" aria-describedby=""titulo"" readonly");
            BeginWriteAttribute("value", " value=\"", 958, "\"", 982, 1);
#nullable restore
#line 20 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
WriteAttributeValue("", 966, Pregunta.titulo, 966, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"descripcion\" class=\"form-label\">Descripcion</label>\r\n                <textarea class=\"form-control\" id=\"descripcion\" rows=\"3\" readonly>");
#nullable restore
#line 24 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                                                                             Write(Pregunta.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n            <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 26 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                                                      Write(Pregunta.fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n            <p class=\"card-text\">\r\n                <small class=\"text-muted\">\r\n");
#nullable restore
#line 29 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                     if (Pregunta.activo)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Pregunta Abierta</span>\r\n");
#nullable restore
#line 32 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Pregunta Cerrada</span>\r\n");
#nullable restore
#line 36 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </small>\r\n            </p>\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <a class=\"btn btn-secondary\" href=\"/\">Regresar</a>\r\n");
#nullable restore
#line 42 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
             if (Pregunta.activo && userSession != null && Pregunta.idUsuario != userSession.idUsuario)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\" class=\"btn btn-outline-success\" data-toggle=\"modal\" data-target=\"#ResponderModal\">Responder</button>\r\n");
#nullable restore
#line 45 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
             if (Pregunta.activo && userSession !=null && Pregunta.idUsuario == userSession.idUsuario)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\" class=\"btn btn-outline-danger\" data-toggle=\"modal\" data-target=\"#CerrarModal\">Cerrar Pregunta</button>\r\n");
#nullable restore
#line 49 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Respuestas</h1>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 57 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
     foreach (var ListaModel in data.ListaRespuesta)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-info mb-3\">\r\n            <div class=\"card-header\">\r\n                [");
#nullable restore
#line 61 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
            Write(ListaModel.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 61 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                                Write(ListaModel.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(")]\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <p class=\"card-text \">");
#nullable restore
#line 64 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                                 Write(ListaModel.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                <small class=\"text-muted\">[Fecha = ");
#nullable restore
#line 67 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                                              Write(ListaModel.fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("]</small>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div class=""modal fade"" id=""ResponderModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ResponderModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""ResponderModalLabel"">Nueva Respuesta</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "117d61040d5ee61d60f6942a508f05478fa4db5912515", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""txtRespuesta"">Respuesta</label>
                        <textarea class=""form-control"" id=""txtRespuesta"" rows=""3"" required placeholder=""Ingrese su Respuesta""></textarea>
                    </div>
                    <button type=""submit"" class=""btn btn-primary"" onclick=""Responder();"">Responder</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>                
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""CerrarModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""CerrarModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""CerrarModalLabel"">CONFIRMACION</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ESTA SEGURO QUE DESEA CERRAR LA PREGUNTA?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</b");
            WriteLiteral(@"utton>
                <button type=""button"" class=""btn btn-danger"" onclick=""CerrarPregunta();"">Cerrar</button>
            </div>
        </div>
    </div>
</div>
<script>

    function Responder() {
        var form = document.getElementById('frmRespuesta');
        if (form.checkValidity()) {        
            var urlResponder = '");
#nullable restore
#line 120 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                           Write(Url.Action("Responder", "Preguntas"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            var idPregunta = document.getElementById('idPreguntaVal').value;
            var respuesta = document.getElementById('txtRespuesta').value;
            console.log(""Ejecutando"");
            $.ajax({
                url: urlResponder,
                type: 'POST',
                data: { idPregunta: idPregunta, descripcion: respuesta},
                success: function (result) {
                    var response = JSON.parse(result);
                    if (response.Status.HttpCode == 200) {
                        //alert(response.Item);
                        location.reload();
                    }
                    else {
                        alert(response.Status.Message);
                    }
                },
                error: function (httpResponse, e) {
                    console.log(e);
                    alert(""Error en el proceso"");
                },
                complete: function (result) {
                }
            });
        }
  ");
            WriteLiteral("  }\r\n\r\n    function CerrarPregunta() {\r\n        var urlResponder = \'");
#nullable restore
#line 149 "C:\Users\crobe\Documents\GIT\BAC\Foro\Api\Foro.Back\Foro.Front\Views\Preguntas\Detail.cshtml"
                       Write(Url.Action("CerrarPregunta", "Preguntas"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        var idPregunta = document.getElementById('idPreguntaVal').value;
        console.log(""Ejecutando"");
        $.ajax({
            url: urlResponder,
            type: 'POST',
            data: { idPregunta: idPregunta},
            success: function (result) {
                var response = JSON.parse(result);
                if (response.Status.HttpCode == 200) {
                    //alert(response.Item);
                    location.reload();
                }
                else {
                    alert(response.Status.Message);
                }
            },
            error: function (httpResponse, e) {
                console.log(e);
                alert(""Error en el proceso"");
            },
            complete: function (result) {
            }
        });
    }
</script>");
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
