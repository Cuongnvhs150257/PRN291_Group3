#pragma checksum "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03910bae682fa2f6a679b55a4fc047a7aa1b9c48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 2 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
using PRNAssG8.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03910bae682fa2f6a679b55a4fc047a7aa1b9c48", @"/Views/Product/Detail.cshtml")]
    #nullable restore
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("align-items:center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
  
    DateTime Datenow = DateTime.Now;
    DateTime date = ViewBag.product.Date;
    DateTime dateto = date.AddDays(2);
    double minP = ViewBag.product.Price + 20;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03910bae682fa2f6a679b55a4fc047a7aa1b9c485358", async() => {
                WriteLiteral(@"
<title>Page Title</title>
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css"">
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
<style>
    .all{
        padding: 20px ;
        margin:auto;
        width:80%;
    
    }
    .alll{
        padding: 20px ;
 
        border: 1px solid;

    }
    .allr{
        padding: 20px ;
     border: 1px solid; 
     text-align:center;
   

    }
    table, th, td {
  border: 1px solid;
}
</style>
<script>
    function myFunction() {
        var dao = document.getElementById(""p"").value;
        if(dao> ");
#nullable restore
#line 50 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
           Write(ViewBag.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("+19)\r\n            alert(\"successful auction!!!\")\r\n    }\r\n// Set the date we\'re counting down to\r\nvar countDownDate = new Date(");
#nullable restore
#line 54 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                        Write(dateto.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 54 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                     Write(dateto.Month);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 54 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                                   Write(dateto.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 54 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                                               Write(dateto.Hour);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 54 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                                                            Write(dateto.Minute);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 54 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                                                                           Write(dateto.Second);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ).getTime();

// Update the count down every 1 second
var x = setInterval(function() {
  // Get today's date and time
  var now = new Date().getTime();
    
  // Find the distance between now and the count down date
  var distance = countDownDate - now - (31*(1000 * 60 * 60 * 24));
    
  // Time calculations for days, hours, minutes and seconds
  var days = Math.floor(distance / (1000 * 60 * 60 * 24));
  var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
  var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
  var seconds = Math.floor((distance % (1000 * 60)) / 1000);
    
  // Output the result in an element with id=""demo""
  document.getElementById(""time"").innerHTML = days + ""d "" + hours + ""h ""
  + minutes + ""m "" + seconds + ""s "";
    
  // If the count down is over, write some text 
  if (distance < 0) {
    clearInterval(x);
    document.getElementById(""time"").innerHTML = ""EXPIRED"";
  }else if(distance >(2*(1000 * 60 * 60 * 24))){
   ");
                WriteLiteral("    clearInterval(x);\r\n    document.getElementById(\"time\").innerHTML = \"COME BACK LATER\";\r\n  }\r\n\r\n}, 100);\r\n</script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03910bae682fa2f6a679b55a4fc047a7aa1b9c4810221", async() => {
                WriteLiteral("\r\n    <div class=\"all\">\r\n        \r\n       <div class=\"container\">\r\n         <div class=\"row\">\r\n           <div class=\"col-8 alll\" >\r\n            <div >\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "03910bae682fa2f6a679b55a4fc047a7aa1b9c4810667", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2824, "~/img/product/", 2824, 14, true);
#nullable restore
#line 93 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 2838, ViewBag.product.Image, 2838, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <h1 style=\"font-family:Times New Roman, Times, serif;\">");
#nullable restore
#line 97 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                                                  Write(ViewBag.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" -\r\n");
#nullable restore
#line 98 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                 foreach(var c in ViewBag.cate)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                     if (@ViewBag.product.CategoryId == @c.CategoryId)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                   Write(c.CategoryName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                       
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </h1><br />\r\n\r\n                <div class=\"input-group\">\r\n                    <span class=\"input-group-text\">Time</span>\r\n                 <span  class=\"border\" style=\"font-size:20px; padding: 5px;\">");
#nullable restore
#line 109 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                                                        Write(date.ToString("dd/MMM/yyyy - HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" to ");
#nullable restore
#line 109 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                                                                                                 Write(date.AddDays(2).ToString("dd/MMM/yyyy - HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>  \r\n                 <span  class=\"input-group-text\" id=\"time\"></span>\r\n             </div><br />\r\n\r\n");
#nullable restore
#line 113 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                 if(@Datenow.Date >= @date.Date && @Datenow.Date <= @date.AddDays(2).Date )
                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03910bae682fa2f6a679b55a4fc047a7aa1b9c4815190", async() => {
                    WriteLiteral("\r\n\r\n                         <div class=\"input-group\">\r\n");
#nullable restore
#line 119 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                            foreach(Reservation r in ViewBag.res)
                           {
                              if(r.ReservationId==9){

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            <input type=\"text\" name=\"check\" value=\"1\" style=\"display:none;\" />\r\n");
#nullable restore
#line 123 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                        }
                                        if (r.ReservationId != 3)
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            <input type=\"text\" name=\"check\" value=\"0\" style=\"display:none;\" />\r\n");
#nullable restore
#line 127 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                          <input type=""text"" name=""ReservationId"" value=""9"" style=""display:none;"" />    
                         <input type=""text"" name=""UserId"" value=""9"" style=""display:none;"" /> 
                         <input type=""text"" name=""ProductId""");
                    BeginWriteAttribute("value", " value=\"", 4839, "\"", 4873, 1);
#nullable restore
#line 131 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 4847, ViewBag.product.ProductId, 4847, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" style=\"display:none;\" /> \r\n                         <input type=\"text\" name=\"Time\"");
                    BeginWriteAttribute("value", " value=\"", 4957, "\"", 4973, 1);
#nullable restore
#line 132 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 4965, Datenow, 4965, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" style=\"display:none;\" /> \r\n                        <span class=\"input-group-text\">Price</span>\r\n                        <input  type=\"number\" id=\"p\"");
                    BeginWriteAttribute("value", " value=\"", 5123, "\"", 5153, 1);
#nullable restore
#line 134 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 5131, ViewBag.product.Price, 5131, 22, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("min", "  min=\"", 5154, "\"", 5166, 1);
#nullable restore
#line 134 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 5161, minP, 5161, 5, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"NewPrice\"><span class=\"input-group-text\">$</span>  \r\n                         <button type=\"submit\"  onclick=\"myFunction()\"><i class=\"bi bi-shift-fill\"></i></button>   \r\n                        </div>\r\n\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 139 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                 if(@Datenow.Date < @date.Date || @Datenow.Date > @date.AddDays(2).Date){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"input-group\">\r\n                        <span class=\"input-group-text\">Price</span>\r\n                        <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 5677, "\"", 5707, 1);
#nullable restore
#line 143 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 5685, ViewBag.product.Price, 5685, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly><span class=\"input-group-text\">$</span>  \r\n                        </div>\r\n");
#nullable restore
#line 145 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <br />\r\n\r\n                <p>");
#nullable restore
#line 148 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
              Write(ViewBag.product.Detail);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
            </div>

            </div>
            <div class=""col-4 allr"">
                    <table width=100% height=auto>
                        <tr>
                            <th colspan=3>auction activities</th>
                        </tr>
                        <tr>
                            <th>Auctioneer's name</th>
                            <th>Price</th>
                            <th>Time</th>
                           
                        </tr>
");
#nullable restore
#line 163 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                         foreach(Reservation r in ViewBag.re){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n");
#nullable restore
#line 165 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                             foreach(User u in ViewBag.user){
                                if(@r.UserId==@u.UserId){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>");
#nullable restore
#line 167 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                   Write(u.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 168 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>");
#nullable restore
#line 170 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                           Write(r.NewPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 171 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                           Write(r.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                           \r\n                        </tr>\r\n");
#nullable restore
#line 174 "D:\IT\PRN211\PRNAssG8\PRNAssG8\Views\Product\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </table>\r\n                </div>\r\n      </div>\r\n     </div>\r\n\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
