#pragma checksum "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e4cead5b5039be46270f571871e13fcbfdf7f81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_HistoryNew), @"mvc.1.0.view", @"/Views/Table/HistoryNew.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Table/HistoryNew.cshtml", typeof(AspNetCore.Views_Table_HistoryNew))]
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
#line 1 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\_ViewImports.cshtml"
using WaterHistoryApp;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\_ViewImports.cshtml"
using WaterHistoryApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e4cead5b5039be46270f571871e13fcbfdf7f81", @"/Views/Table/HistoryNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e270210ba7ad02675e734df8df5e3da3a178ca9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_HistoryNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WaterHistoryApp.Models.History>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 58, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <br />\r\n    <p>История за: ");
            EndContext();
            BeginContext(98, 37, false);
#line 5 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
              Write(Model.DateTime.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(135, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
     using (Html.BeginForm("HistoryNew", "Table", FormMethod.Post))
    {
        

#line default
#line hidden
            BeginContext(228, 23, false);
#line 9 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(264, 31, false);
#line 11 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
   Write(Html.HiddenFor(m => m.DateTime));

#line default
#line hidden
            EndContext();
            BeginContext(299, 332, true);
            WriteLiteral(@"        <br />
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>События</th>
                    <th>Значения</th>
                </tr>
            </thead>
            <tbody>

                <tr>
                    <td>Сезон</td>
                    <td>");
            EndContext();
            BeginContext(632, 30, false);
#line 25 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.Season));

#line default
#line hidden
            EndContext();
            BeginContext(662, 128, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Температурный режим</td>\r\n                    <td>");
            EndContext();
            BeginContext(791, 30, false);
#line 30 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.Season));

#line default
#line hidden
            EndContext();
            BeginContext(821, 133, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n\r\n                    <td>Количество сотрудников</td>\r\n                    <td>");
            EndContext();
            BeginContext(955, 30, false);
#line 36 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.Season));

#line default
#line hidden
            EndContext();
            BeginContext(985, 122, true);
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>День недели</td>\r\n                    <td>");
            EndContext();
            BeginContext(1108, 31, false);
#line 42 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.DayWeek));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 142, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Наличие запасов с предыдущего дня</td>\r\n                    <td>");
            EndContext();
            BeginContext(1282, 34, false);
#line 47 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.PreviouDay));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 141, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Времени привоза воды поставщиком</td>\r\n                    <td>");
            EndContext();
            BeginContext(1458, 36, false);
#line 52 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.TimeDelivery));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 153, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Количества диспенсеров в работе и на ремонте</td>\r\n                    <td>");
            EndContext();
            BeginContext(1648, 36, false);
#line 57 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.NumberRepeir));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 122, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Количества помп</td>\r\n                    <td>");
            EndContext();
            BeginContext(1807, 35, false);
#line 61 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.NumberPumps));

#line default
#line hidden
            EndContext();
            BeginContext(1842, 166, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Наличием альтернативных источников (вендинговые автоматы)</td>\r\n                    <td>");
            EndContext();
            BeginContext(2009, 31, false);
#line 66 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.Vending));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 139, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Продолжительности рабочего дня</td>\r\n                    <td>");
            EndContext();
            BeginContext(2180, 36, false);
#line 71 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.WorkingHours));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 130, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Неопределенных причин</td>\r\n                    <td>");
            EndContext();
            BeginContext(2347, 40, false);
#line 76 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.UncertainReasons));

#line default
#line hidden
            EndContext();
            BeginContext(2387, 135, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th>Итог потраченой воды ( л )</th>\r\n                    <td>");
            EndContext();
            BeginContext(2523, 32, false);
#line 81 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
                   Write(Html.TextBoxFor(m => m.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2555, 72, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n            </tbody>\r\n        </table>\r\n");
            EndContext();
            BeginContext(2629, 91, true);
            WriteLiteral("        <button type=\"submit\" class=\"btn btn-primary btn-lg btn-block\">Сохранить</button>\r\n");
            EndContext();
#line 88 "C:\Users\User\source\repos\WaterHistoryApp\WaterHistoryApp\Views\Table\HistoryNew.cshtml"
}

#line default
#line hidden
            BeginContext(2723, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WaterHistoryApp.Models.History> Html { get; private set; }
    }
}
#pragma warning restore 1591
