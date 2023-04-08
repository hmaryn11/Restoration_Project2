#pragma checksum "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd7d137bb0b51e8e81f9d69337c19b02e4c34d88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QuesPage), @"mvc.1.0.view", @"/Views/Home/QuesPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd7d137bb0b51e8e81f9d69337c19b02e4c34d88", @"/Views/Home/QuesPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f611db3b046cbb0d52d536e9603f2509b53af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_QuesPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("moveOn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light vlilbtnwidth"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formKiller"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
   //create a list of range 1-4 in random order
    int count = 4; // number of random numbers to generate

    Random rand = new Random();
    List<int> numList = new List<int>();

    while (numList.Count < count)
    {
        int num = rand.Next(1, 5); // generate random number within range
        if (!numList.Contains(num))
        {
            numList.Add(num); // add to list if not already present
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
   
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
            BeginWriteAttribute("class", " class=\"", 1489, "\"", 1530, 3);
            WriteAttributeValue("", 1497, "displayDiv", 1497, 10, true);
            WriteAttributeValue(" ", 1507, "vertEvnSpc", 1508, 11, true);
#nullable restore
#line 40 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
WriteAttributeValue(" ", 1518, BGtxtColor, 1519, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1531, "\"", 1578, 2);
            WriteAttributeValue("", 1539, "background-color:", 1539, 17, true);
#nullable restore
#line 40 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
WriteAttributeValue("", 1556, ViewBag.Topic.BGColor, 1556, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"topicDiv\">\r\n        <h3 class=\"marginTxtDiv\">");
#nullable restore
#line 42 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
                            Write(ViewBag.Topic.TopicName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 42 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
                                                       Write(ViewBag.Question.PointValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <h1>");
#nullable restore
#line 44 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
   Write(ViewBag.Question.FullQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"frSqrBtn\">\r\n");
#nullable restore
#line 47 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
         for (int i = 0; i <= 3; i++)
        {
            foreach (var answer in ViewBag.Answers)
            {
                if (numList[i] == answer.AnswerNum)
                {
                    var ansClass = "incorrect";
                    if (answer.Corr_Wrong == true)
                    {
                        ansClass = "correct";
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button");
            BeginWriteAttribute("class", " class=\"", 2271, "\"", 2318, 4);
#nullable restore
#line 59 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
WriteAttributeValue("", 2279, ansClass, 2279, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2288, "btn", 2289, 4, true);
            WriteAttributeValue(" ", 2292, "lilbtnheight", 2293, 13, true);
#nullable restore
#line 59 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
WriteAttributeValue(" ", 2305, DivtxtColor, 2306, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 2319, "\"", 2367, 2);
            WriteAttributeValue("", 2327, "background-color:", 2327, 17, true);
#nullable restore
#line 59 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
WriteAttributeValue("", 2344, ViewBag.Topic.DivColor, 2344, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2368, "\"", 2400, 3);
            WriteAttributeValue("", 2378, "selectAns(\'", 2378, 11, true);
#nullable restore
#line 59 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
WriteAttributeValue("", 2389, ansClass, 2389, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2398, "\')", 2398, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
                                                                                                                                                         Write(answer.FullAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 60 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
                }
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <h3 id=\"resultTxt\"></h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd7d137bb0b51e8e81f9d69337c19b02e4c34d8811753", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2593, "\"", 2629, 1);
#nullable restore
#line 67 "C:\Users\Maryn\source\repos\Restoration_Project\Restoration Project\Views\Home\QuesPage.cshtml"
WriteAttributeValue("", 2601, ViewBag.Question.QuestionId, 2601, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"QuestionId\" />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd7d137bb0b51e8e81f9d69337c19b02e4c34d8812485", async() => {
                    WriteLiteral("Continue Forward");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
