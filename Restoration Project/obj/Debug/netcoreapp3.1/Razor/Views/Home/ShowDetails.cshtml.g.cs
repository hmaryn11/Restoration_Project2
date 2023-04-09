#pragma checksum "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\ShowDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "933d13b2e7e096748aef9e4a38f2f718f2587cc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowDetails), @"mvc.1.0.view", @"/Views/Home/ShowDetails.cshtml")]
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
#line 1 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\_ViewImports.cshtml"
using Restoration_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\_ViewImports.cshtml"
using Restoration_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\_ViewImports.cshtml"
using Restoration_Project.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"933d13b2e7e096748aef9e4a38f2f718f2587cc1", @"/Views/Home/ShowDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f611db3b046cbb0d52d536e9603f2509b53af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light vlilbtnwidth"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\ShowDetails.cshtml"
  
    var BGtxtColor = "text-dark";
    if (ViewBag.Topic.BGColor == "mediumblue" || ViewBag.Topic.BGColor == "orangered")
    {
        BGtxtColor = "text-light";
    }

    var DivtxtColor = "text-dark";
    if (ViewBag.Topic.DivColor == "mediumblue" || ViewBag.Topic.DivColor == "orangered")
    {
        DivtxtColor = "text-light";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 697, "\"", 738, 3);
            WriteAttributeValue("", 705, "displayDiv", 705, 10, true);
            WriteAttributeValue(" ", 715, "vertEvnSpc", 716, 11, true);
#nullable restore
#line 20 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\ShowDetails.cshtml"
WriteAttributeValue(" ", 726, BGtxtColor, 727, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 739, "\"", 786, 2);
            WriteAttributeValue("", 747, "background-color:", 747, 17, true);
#nullable restore
#line 20 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\ShowDetails.cshtml"
WriteAttributeValue("", 764, ViewBag.Topic.BGColor, 764, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"topicDiv\">\r\n        <h4 class=\"marginTxtDiv\">");
#nullable restore
#line 22 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\ShowDetails.cshtml"
                            Write(ViewBag.Topic.TopicName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 22 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\ShowDetails.cshtml"
                                                       Write(ViewBag.Question.PointValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <h2>");
#nullable restore
#line 24 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\ShowDetails.cshtml"
   Write(ViewBag.Question.FullQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div");
            BeginWriteAttribute("style", " style=\"", 978, "\"", 1026, 2);
            WriteAttributeValue("", 986, "background-color:", 986, 17, true);
#nullable restore
#line 25 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\ShowDetails.cshtml"
WriteAttributeValue("", 1003, ViewBag.Topic.DivColor, 1003, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1027, "\"", 1061, 2);
            WriteAttributeValue("", 1035, "smldisplayDiv", 1035, 13, true);
#nullable restore
#line 25 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\ShowDetails.cshtml"
WriteAttributeValue(" ", 1048, DivtxtColor, 1049, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <p>");
#nullable restore
#line 26 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\ShowDetails.cshtml"
      Write(ViewBag.Question.Explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n    </div>\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933d13b2e7e096748aef9e4a38f2f718f2587cc18056", async() => {
                WriteLiteral("Return to Dashboard");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
