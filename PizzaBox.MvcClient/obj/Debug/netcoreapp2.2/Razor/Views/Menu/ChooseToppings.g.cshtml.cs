#pragma checksum "/Users/Oscar/revature/Project0/PizzaBox.MvcClient/Views/Menu/ChooseToppings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec8be5f0ff24e036a8bb3b5836d509ad9bb8184"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_ChooseToppings), @"mvc.1.0.view", @"/Views/Menu/ChooseToppings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/ChooseToppings.cshtml", typeof(AspNetCore.Views_Menu_ChooseToppings))]
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
#line 1 "/Users/Oscar/revature/Project0/PizzaBox.MvcClient/Views/_ViewImports.cshtml"
using PizzaBox.MvcClient;

#line default
#line hidden
#line 2 "/Users/Oscar/revature/Project0/PizzaBox.MvcClient/Views/_ViewImports.cshtml"
using PizzaBox.MvcClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec8be5f0ff24e036a8bb3b5836d509ad9bb8184", @"/Views/Menu/ChooseToppings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c31778b929ff312ee8188cffcffd40266a033ef2", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_ChooseToppings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Domain.Models.Pizza>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Menu/ChooseToppings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 41, true);
            WriteLiteral("\n<h1>Here is our Menu Choices:</h1>\n<ul>\n");
            EndContext();
            BeginContext(77, 1209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ec8be5f0ff24e036a8bb3b5836d509ad9bb81844045", async() => {
                BeginContext(128, 1151, true);
                WriteLiteral(@"
  <fieldset name=""radiobutton"">
    <label><input type =""radio"" name=""Size.Name"" value=""Small"">Small</label><br>
    <label><input type =""radio"" name=""Size.Name"" value=""Medium"">Medium</label><br>
    <label><input type =""radio"" name=""Size.Name"" value=""Large"">Large</label><br>
  </fieldset>
  <fieldset name=""radiobutton"">
    <label><input type =""radio"" name=""Crust.Name"" value=""Deep Dish"">Deep Dish (+ $1.00)</label><br>
    <label><input type =""radio"" name=""Crust.Name"" value=""Stuffed"">Stuffed (+ $1.00)</label><br>
    <label><input type =""radio"" name=""Crust.Name"" value=""Thin"">Thin</label><br>
    <label><input type =""radio"" name=""Crust.Name"" value=""Traditional"">Traditional</label><br>
  </fieldset>
  <fieldset name=""radiobutton"">
    <label><input type =""radio"" name=""Topping.Name"" value=""Pepperoni"">Pepperoni</label><br>
    <label><input type =""radio"" name=""Topping.Name"" value=""Cheese"">Cheese</label><br>
    <label><input type =""radio"" name=""Topping.Name"" value=""Mushrooms"">Mushrooms</label><br>
    <label><in");
                WriteLiteral("put type =\"radio\" name=\"Topping.Name\" value=\"Olives\">Olives</label><br>\n  </fieldset>\n\n\n\n  <button type=\"submit\">Next</button>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1286, 6, true);
            WriteLiteral("\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Domain.Models.Pizza> Html { get; private set; }
    }
}
#pragma warning restore 1591
