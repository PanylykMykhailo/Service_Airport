#pragma checksum "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75c4397e2f3536bd12cba6c6e79858cf54787487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TicketReserved), @"mvc.1.0.view", @"/Views/Home/TicketReserved.cshtml")]
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
#line 1 "C:\Users\misha\source\repos\Airport\Airport\Views\_ViewImports.cshtml"
using Airport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\misha\source\repos\Airport\Airport\Views\_ViewImports.cshtml"
using Airport.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\misha\source\repos\Airport\Airport\Views\_ViewImports.cshtml"
using Airport.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\misha\source\repos\Airport\Airport\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75c4397e2f3536bd12cba6c6e79858cf54787487", @"/Views/Home/TicketReserved.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ac973795ecfef4f5fd7cb16ecbbc8945357e04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TicketReserved : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Airport.ViewModels.AddViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Renewal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
 if (Model.schedule_Out != null && Model.schedule_In == null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-row\">\r\n        <div class=\"col-md-6 mb-3\">\r\n            <label class=\"control-label\">Модель літаку</label>\r\n            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 290, "\"", 334, 1);
#nullable restore
#line 9 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 304, Model.schedule_Out.Name_Board, 304, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n\r\n        </div>\r\n        <div class=\"col-md-6 mb-3\">\r\n            <label class=\"control-label\">Місто відправлення</label>\r\n            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 524, "\"", 576, 1);
#nullable restore
#line 14 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 538, Model.schedule_Out.CityStart.CityName, 538, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n        </div>\r\n        <div class=\"col-md-6 mb-3\">\r\n            <label class=\"control-label\">Місто прибуття</label>\r\n            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 760, "\"", 813, 1);
#nullable restore
#line 18 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 774, Model.schedule_Out.CityFinish.CityName, 774, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n        </div>\r\n        <div class=\"col-md-6 mb-3\">\r\n            <label class=\"control-label\">Час відправлення</label>\r\n            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 999, "\"", 1047, 1);
#nullable restore
#line 22 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 1013, Model.schedule_Out.TimeOutAirport, 1013, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n        </div>\r\n        <div class=\"col-md-6 mb-3\">\r\n            <label class=\"control-label\">Максимальне чило пасажирів</label>\r\n            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1243, "\"", 1290, 1);
#nullable restore
#line 26 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 1257, Model.schedule_Out.Max_Passenger, 1257, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n        </div>\r\n        <div class=\"col-md-6 mb-3\">\r\n            <label class=\"control-label\">Вільні місця</label>\r\n            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1472, "\"", 1515, 1);
#nullable restore
#line 30 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 1486, Model.schedule_Out.FreePlace, 1486, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n        </div>\r\n        <div class=\"col-md-6 mb-3\">\r\n            <label class=\"control-label\">Статус поїздки</label>\r\n            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1699, "\"", 1739, 1);
#nullable restore
#line 34 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 1713, Model.schedule_Out.States, 1713, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n        </div>\r\n\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75c4397e2f3536bd12cba6c6e79858cf547874878671", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <div class=""form-check"">
                <input class=""form-check-input "" type=""checkbox"" value=""1"" id=""value"" required>
                <label class=""form-check-label"" for=""invalidCheck3"">
                    Все добре
                </label>
                <div class=""invalid-feedback"">
                    Потрібно підтвердити перед відправкою
                </div>
            </div>
        </div>
        <button class=""btn btn-primary"" type=""submit"">Все вірно</button>
        ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
        }
else if (Model.schedule_Out == null && Model.schedule_In != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-row\">\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label class=\"control-label\">Модель літаку</label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2670, "\"", 2713, 1);
#nullable restore
#line 58 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 2684, Model.schedule_In.Name_Board, 2684, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label class=\"control-label\">Місто відправлення</label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2919, "\"", 2970, 1);
#nullable restore
#line 63 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 2933, Model.schedule_In.CityStart.CityName, 2933, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label class=\"control-label\">Місто прибуття</label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3170, "\"", 3222, 1);
#nullable restore
#line 67 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 3184, Model.schedule_In.CityFinish.CityName, 3184, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label class=\"control-label\">Час відправлення</label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3424, "\"", 3470, 1);
#nullable restore
#line 71 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 3438, Model.schedule_In.TimeinAirport, 3438, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label class=\"control-label\">Максимальне чило пасажирів</label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3682, "\"", 3728, 1);
#nullable restore
#line 75 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 3696, Model.schedule_In.Max_Passenger, 3696, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label class=\"control-label\">Вільні місця</label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3926, "\"", 3968, 1);
#nullable restore
#line 79 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 3940, Model.schedule_In.FreePlace, 3940, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label class=\"control-label\">Статус поїздки</label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4168, "\"", 4207, 1);
#nullable restore
#line 83 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
WriteAttributeValue("", 4182, Model.schedule_In.States, 4182, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n            </div>\r\n\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75c4397e2f3536bd12cba6c6e79858cf5478748715491", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <div class=""form-check"">
                    <input class=""form-check-input "" type=""checkbox"" value=""2"" id=""value"" required>
                    <label class=""form-check-label"" for=""invalidCheck3"">
                        Все добре
                    </label>
                    <div class=""invalid-feedback"">
                        Потрібно підтвердити перед відправкою
                    </div>
                </div>
            </div>
            <button class=""btn btn-primary"" type=""submit"">Все вірно</button>
        ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 101 "C:\Users\misha\source\repos\Airport\Airport\Views\Home\TicketReserved.cshtml"
        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Airport.ViewModels.AddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591