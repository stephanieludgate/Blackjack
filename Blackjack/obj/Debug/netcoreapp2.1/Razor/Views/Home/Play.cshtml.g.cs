#pragma checksum "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d2833b9d8d08a2cba7952d01f89c562b953c1b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Play), @"mvc.1.0.view", @"/Views/Home/Play.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Play.cshtml", typeof(AspNetCore.Views_Home_Play))]
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
#line 1 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\_ViewImports.cshtml"
using Blackjack;

#line default
#line hidden
#line 2 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\_ViewImports.cshtml"
using Blackjack.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2833b9d8d08a2cba7952d01f89c562b953c1b8", @"/Views/Home/Play.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a1b0cef721572e71b53677cb84b55266a86f394", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Play : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blackjack.Models.Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Back.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("shift"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default mt-3 playButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Hit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Stand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Start", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
  
    if (Context.Request.Method == "POST")
    {
        ViewData["Title"] = "POST";
    }
    else
    {
        ViewData["Title"] = "GET";
    }

#line default
#line hidden
            BeginContext(193, 262, true);
            WriteLiteral(@"
<div class=""contentBox col-md-10 col-md-offset-1 my-5 p-4 bg-light text-dark border border-dark rounded-lg"" id=""casinoBox"">
    <div class=""row"">
        <div class=""col-sm-10"">
            <h3 style=""margin-top: 0px !important;"">
                Dealer ( ");
            EndContext();
#line 18 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
                          if (Model.GameState == GameState.PLAY)
                {
                    

#line default
#line hidden
            BeginContext(541, 5, true);
            WriteLiteral("&gt; ");
            EndContext();
            BeginContext(555, 39, false);
#line 20 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
                                  Write(Model.Dealer.Hand.DealerConcealedHand());

#line default
#line hidden
            EndContext();
#line 20 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
                                                                               }
                else
                { 

#line default
#line hidden
            BeginContext(638, 29, false);
#line 22 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
             Write(Model.Dealer.Hand.SumOfHand());

#line default
#line hidden
            EndContext();
#line 22 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
                                                }

#line default
#line hidden
            BeginContext(668, 110, true);
            WriteLiteral("  )\r\n            </h3>\r\n        </div>\r\n        <div class=\"col-sm-2 text-center\" id=\"balance\"><h6>Balance : $");
            EndContext();
            BeginContext(779, 46, false);
#line 25 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
                                                                 Write(Html.DisplayFor(model => model.Player.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(825, 58, true);
            WriteLiteral("</h6></div>\r\n    </div>\r\n\r\n\r\n    <div id=\"dealersCards\">\r\n");
            EndContext();
#line 30 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
         foreach (var item in Model.Dealer.Hand.Cards)
        {
            if (item == Model.Dealer.Hand.Cards.ElementAt(0))
            {
                if (Model.GameState == GameState.PLAY)
                {

#line default
#line hidden
            BeginContext(1103, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1123, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0bacc4f64d44f97b7f1a397061e059f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1167, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1229, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1249, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb8b95a6b6f447429a446f77baf23924", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1259, "~/images/", 1259, 9, true);
#line 40 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
AddHtmlAttributeValue("", 1268, item.ImagePath, 1268, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1300, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(1369, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1385, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b47f303ffe24963b539c76d35c5f222", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1395, "~/images/", 1395, 9, true);
#line 45 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
AddHtmlAttributeValue("", 1404, item.ImagePath, 1404, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1450, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1478, 48, true);
            WriteLiteral("    </div>\r\n    <div class=\"row middle-row\">\r\n\r\n");
            EndContext();
#line 51 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
         if (!Model.DealerMove && Model.GameState == GameState.PLAY)
        {


#line default
#line hidden
            BeginContext(1609, 45, true);
            WriteLiteral("            <div class=\"col-sm-5 text-right\">");
            EndContext();
            BeginContext(1654, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acaea684c6e44e79a603216509ac435d", async() => {
                BeginContext(1736, 3, true);
                WriteLiteral("Hit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1743, 81, true);
            WriteLiteral("</div>\r\n            <div class=\"col-sm-2 text-center\">\r\n                Betting $");
            EndContext();
            BeginContext(1825, 35, false);
#line 56 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
                    Write(Html.DisplayFor(model => model.Bet));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 74, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-5\">\r\n                ");
            EndContext();
            BeginContext(1934, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "756f301c94d0424689797e196b940253", async() => {
                BeginContext(2018, 5, true);
                WriteLiteral("Stand");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2027, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 61 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
        }
        else
        {
            if (Model.GameState == GameState.WIN)
            {

#line default
#line hidden
            BeginContext(2151, 90, true);
            WriteLiteral("                <div class=\"text-center\">\r\n                <h4>WIN!</h4>\r\n                ");
            EndContext();
            BeginContext(2241, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29915bf1c38242e7b15aa9db32218275", async() => {
                BeginContext(2314, 11, true);
                WriteLiteral("Play Again!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2329, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 70 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
        }
        else if (Model.GameState == GameState.LOSE)
        {

#line default
#line hidden
            BeginContext(2426, 87, true);
            WriteLiteral("            <div class=\"text-center\">\r\n                <h4>LOST!</h4>\r\n                ");
            EndContext();
            BeginContext(2513, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14b0eab3eb8d4dfe89f6d1209bff771f", async() => {
                BeginContext(2586, 10, true);
                WriteLiteral("Try Again!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2600, 24, true);
            WriteLiteral("\r\n\r\n            </div>\r\n");
            EndContext();
#line 78 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2642, 22, true);
            WriteLiteral("    </div>\r\n\r\n    <h3>");
            EndContext();
            BeginContext(2665, 47, false);
#line 82 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
   Write(Html.DisplayFor(model => model.Player.Username));

#line default
#line hidden
            EndContext();
            BeginContext(2712, 3, true);
            WriteLiteral(" ( ");
            EndContext();
            BeginContext(2716, 29, false);
#line 82 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
                                                      Write(Model.Player.Hand.SumOfHand());

#line default
#line hidden
            EndContext();
            BeginContext(2745, 38, true);
            WriteLiteral(" )</h3>\r\n    <div id=\"playersCards\">\r\n");
            EndContext();
#line 84 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
         foreach (var item in Model.Player.Hand.Cards)
        {
            if (item == Model.Player.Hand.Cards.ElementAt(0))
            {

#line default
#line hidden
            BeginContext(2928, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2944, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f1bac0051499429a9822ba59b1ceba4b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2954, "~/images/", 2954, 9, true);
#line 88 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
AddHtmlAttributeValue("", 2963, item.ImagePath, 2963, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2995, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 89 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3045, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3061, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "259db4ab2668425b9dea654989dde214", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3071, "~/images/", 3071, 9, true);
#line 92 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
AddHtmlAttributeValue("", 3080, item.ImagePath, 3080, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 93 "C:\Users\steph\source\repos\Blackjack\Blackjack\Views\Home\Play.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(3154, 26, true);
            WriteLiteral("    </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blackjack.Models.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
