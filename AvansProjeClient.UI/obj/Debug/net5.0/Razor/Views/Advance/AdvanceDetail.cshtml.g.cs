#pragma checksum "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "641c1e99988c0bb61f6db28483501ef36ae993ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advance_AdvanceDetail), @"mvc.1.0.view", @"/Views/Advance/AdvanceDetail.cshtml")]
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
#line 1 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\_ViewImports.cshtml"
using AvansProjeClient.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\_ViewImports.cshtml"
using AvansProjeClient.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
using AvansProjeClient.Models.VM.AdvanceVMs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"641c1e99988c0bb61f6db28483501ef36ae993ae", @"/Views/Advance/AdvanceDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e270abb0f24d12beedc4df60bc399e2fe3800628", @"/Views/_ViewImports.cshtml")]
    public class Views_Advance_AdvanceDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
  
    AdvanceDetailsVM data = (AdvanceDetailsVM)TempData["resultAdvanceDetail"];
    var cardDetail = data.AdvanceDetail;
    var historyList = data.AdvanceHistoryList;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"card col-md-6 rounded-card\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title text-primary\">Talep Oluşturma Tarihi:</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                Write(cardDetail.RequestDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n\r\n                <h5 class=\"card-title text-primary\">Alınmak İstenen Tarih:</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                Write(cardDetail.DesiredDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h5 class=\"card-title text-primary\">Proje:</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                Write(cardDetail.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h5 class=\"card-title text-primary\">Açıklama:</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                Write(cardDetail.AdvanceExplanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card col-md-6 rounded-card\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title text-primary\">Talep Edilen Tutar:</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 28 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                Write(cardDetail.AdvanceAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h5 class=\"card-title text-primary\">Onaylanan Tutar:</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                Write(cardDetail.ApprovedAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h5 class=\"card-title text-primary\">Son Durumu:</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 34 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                Write(cardDetail.ApprovalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h5 class=\"card-title text-primary\">Makbuz No:</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 37 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                Write(cardDetail.ReceiptNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h5 class=\"card-title text-primary\">Avans Geri Ödeme Durumu:</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 40 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                Write(cardDetail.PaybackStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>

        <div class=""card col-md-12 mt-2"">
            <div class=""table-responsive"">
                <table class=""table table-bordered table-striped"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">Durum</th>
                            <th scope=""col"">İşlem Zamanı</th>
                            <th scope=""col"">İşlemi Yapan</th>
                            <th scope=""col"">Sonraki Aşama Kullanıcısı</th>
                            <th scope=""col"">Sonraki Durum</th>
                            <th scope=""col"">Onaylanan Tutar</th>
                            <th scope=""col"">Ödeme Yapılacak Tarih</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 59 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                         foreach (AdvanceHistoryVM item in historyList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 62 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                               Write(item.ApprovalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 64 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                     if (item.ApprovedDeclinedDate != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                   Write(item.ApprovedDeclinedDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                                                                            
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 69 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                               Write(item.ApprovedDeclinedName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 70 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                               Write(item.NextApprovalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 71 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                               Write(item.NextApprovedDeclinedName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                               Write(item.ApprovedAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 74 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                     if (item.PaybackDate != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                   Write(item.PaybackDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                                                                                   
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 80 "C:\Users\User\Desktop\AvansProjeClient\AvansProjeClient.UI\Views\Advance\AdvanceDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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