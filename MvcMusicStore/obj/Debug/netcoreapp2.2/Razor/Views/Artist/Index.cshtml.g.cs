#pragma checksum "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef96e48594ef47000443e8ea4523148ca19c9b22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artist_Index), @"mvc.1.0.view", @"/Views/Artist/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Artist/Index.cshtml", typeof(AspNetCore.Views_Artist_Index))]
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
#line 1 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\_ViewImports.cshtml"
using MvcMusicStore;

#line default
#line hidden
#line 2 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\_ViewImports.cshtml"
using MvcMusicStore.Models;

#line default
#line hidden
#line 2 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 3 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 4 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
using MvcMusicStore.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef96e48594ef47000443e8ea4523148ca19c9b22", @"/Views/Artist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3d7d6c215ab91880cc81299f2cd15c4126a9bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Artist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcMusicStore.Models.Artist>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "album", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(323, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
  
    ViewData["Title"] = viewLocalizer["Artists Listing"];

#line default
#line hidden
            BeginContext(391, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(396, 17, false);
#line 12 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(413, 29, true);
            WriteLiteral(".</h2>\r\n\r\n<p>IViewLocalizer: ");
            EndContext();
            BeginContext(443, 65, false);
#line 14 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
              Write(viewLocalizer["Use this area to provide additional information."]);

#line default
#line hidden
            EndContext();
            BeginContext(508, 25, true);
            WriteLiteral("</p>\r\n<p>IHtmlLocalizer: ");
            EndContext();
            BeginContext(534, 65, false);
#line 15 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
              Write(htmlLocalizer["Use this area to provide additional information."]);

#line default
#line hidden
            EndContext();
            BeginContext(599, 27, true);
            WriteLiteral("</p>\r\n<p>IStringLocalizer: ");
            EndContext();
            BeginContext(627, 67, false);
#line 16 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
                Write(stringLocalizer["Use this area to provide additional information."]);

#line default
#line hidden
            EndContext();
            BeginContext(694, 53, true);
            WriteLiteral("</p>\r\n\r\n<dl>\r\n    <dt>IStringLocalization of phrase \'");
            EndContext();
            BeginContext(748, 25, false);
#line 19 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
                                  Write(ViewData["initialString"]);

#line default
#line hidden
            EndContext();
            BeginContext(773, 17, true);
            WriteLiteral("\':</dt>\r\n    <dd>");
            EndContext();
            BeginContext(791, 22, false);
#line 20 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
   Write(ViewData["Translated"]);

#line default
#line hidden
            EndContext();
            BeginContext(813, 43, true);
            WriteLiteral("</dd>\r\n    <dd>Shared Controller Resource: ");
            EndContext();
            BeginContext(857, 38, false);
#line 21 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
                               Write(ViewData["SharedControllerTranslated"]);

#line default
#line hidden
            EndContext();
            BeginContext(895, 36, true);
            WriteLiteral("</dd>\r\n    <dt>IHtmlLoclization of \'");
            EndContext();
            BeginContext(932, 23, false);
#line 22 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
                        Write(ViewData["initialHTML"]);

#line default
#line hidden
            EndContext();
            BeginContext(955, 17, true);
            WriteLiteral("\':</dt>\r\n    <dd>");
            EndContext();
            BeginContext(973, 26, false);
#line 23 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
   Write(ViewData["TranslatedHtml"]);

#line default
#line hidden
            EndContext();
            BeginContext(999, 81, true);
            WriteLiteral("</dd>\r\n    <dt>Phrases unknown to Localization tables (added \'?\'):</dt>\r\n    <dd>");
            EndContext();
            BeginContext(1081, 25, false);
#line 25 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
   Write(ViewData["unknownString"]);

#line default
#line hidden
            EndContext();
            BeginContext(1106, 15, true);
            WriteLiteral("</dd>\r\n    <dd>");
            EndContext();
            BeginContext(1122, 23, false);
#line 26 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
   Write(ViewData["unknownHTML"]);

#line default
#line hidden
            EndContext();
            BeginContext(1145, 25, true);
            WriteLiteral("</dd>\r\n</dl>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1170, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef96e48594ef47000443e8ea4523148ca19c9b2210831", async() => {
                BeginContext(1193, 24, true);
                WriteLiteral("Create New Artist Record");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1221, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1314, 40, false);
#line 36 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1489, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1549, 255, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef96e48594ef47000443e8ea4523148ca19c9b2213200", async() => {
                BeginContext(1712, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1739, 39, false);
#line 49 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1778, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-artistId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
                               WriteLiteral(item.ArtistId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["artistId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-artistId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["artistId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
                                 WriteLiteral(item.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["artistName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-artistName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["artistName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1804, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                    ");
            EndContext();
            BeginContext(1873, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef96e48594ef47000443e8ea4523148ca19c9b2217063", async() => {
                BeginContext(1924, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
                                           WriteLiteral(item.ArtistId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1932, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1956, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef96e48594ef47000443e8ea4523148ca19c9b2219464", async() => {
                BeginContext(2010, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
                                              WriteLiteral(item.ArtistId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2021, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2045, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef96e48594ef47000443e8ea4523148ca19c9b2221871", async() => {
                BeginContext(2098, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
                                             WriteLiteral(item.ArtistId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2108, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 59 "C:\Users\HankR\Desktop\CP-All\Web Tech\webtech backup\MvcMusicStore_Localization\MvcMusicStore\Views\Artist\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2163, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResources> stringLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> htmlLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer viewLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcMusicStore.Models.Artist>> Html { get; private set; }
    }
}
#pragma warning restore 1591
