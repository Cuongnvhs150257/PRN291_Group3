#pragma checksum "C:\Users\s\Documents\GitHub\PRN291_Group3\PRNAssG8\PRNAssG8\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "071830158ace39addb3397499d1814f6d4c1899d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 2 "C:\Users\s\Documents\GitHub\PRN291_Group3\PRNAssG8\PRNAssG8\Views\Admin\Index.cshtml"
using PRNAssG8.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"071830158ace39addb3397499d1814f6d4c1899d", @"/Views/Admin/Index.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgdd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\s\Documents\GitHub\PRN291_Group3\PRNAssG8\PRNAssG8\Views\Admin\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .imgdd{
      width:150px;
      height:auto;
  }
</style>

<div class=""container"">
        <div class=""cart_inner"">
          <div class=""table-responsive"">
            <table class=""table"">
              <thead>
                <tr>
                  <th scope=""col"">Product</th>
                  <th scope=""col"">Bidder</th>
                  <th scope=""col"">Price Origin</th>
                  <th scope=""col"">Auction Price</th>
                </tr>
              </thead>
              <tbody>
");
#nullable restore
#line 31 "C:\Users\s\Documents\GitHub\PRN291_Group3\PRNAssG8\PRNAssG8\Views\Admin\Index.cshtml"
                   foreach (var p in Model)
                    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                  <td>\r\n                    <div class=\"media\">\r\n                      <div class=\"d-flex\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "071830158ace39addb3397499d1814f6d4c1899d4691", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 990, "~/img/product/", 990, 14, true);
#nullable restore
#line 38 "C:\Users\s\Documents\GitHub\PRN291_Group3\PRNAssG8\PRNAssG8\Views\Admin\Index.cshtml"
AddHtmlAttributeValue("", 1004, p.Image, 1004, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                      </div>\r\n                      <div class=\"media-body\">\r\n                        <p>");
#nullable restore
#line 43 "C:\Users\s\Documents\GitHub\PRN291_Group3\PRNAssG8\PRNAssG8\Views\Admin\Index.cshtml"
                      Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                      </div>\r\n                    </div>\r\n                  </td>\r\n                  <td>\r\n                    <h5>");
#nullable restore
#line 48 "C:\Users\s\Documents\GitHub\PRN291_Group3\PRNAssG8\PRNAssG8\Views\Admin\Index.cshtml"
                   Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD</h5>\r\n                  </td>\r\n                  <td>\r\n                    <h5>");
#nullable restore
#line 51 "C:\Users\s\Documents\GitHub\PRN291_Group3\PRNAssG8\PRNAssG8\Views\Admin\Index.cshtml"
                   Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD</h5>\r\n                  </td>\r\n                  <td>\r\n                    <h5>$720.00</h5>\r\n                  </td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\s\Documents\GitHub\PRN291_Group3\PRNAssG8\PRNAssG8\Views\Admin\Index.cshtml"
                
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n              </tbody>\r\n            </table>\r\n          </div>\r\n        </div>\r\n      </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591