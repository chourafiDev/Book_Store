#pragma checksum "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dfa66d4e077c43f9131fc5bb5cbcde6c3b5b800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
#line 1 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\_ViewImports.cshtml"
using Book_Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\_ViewImports.cshtml"
using Book_Store.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\_ViewImports.cshtml"
using Book_Store.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dfa66d4e077c43f9131fc5bb5cbcde6c3b5b800", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552e57ad1a6ad9fd180dcdef927f304904765f9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "_FormLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--=================================
Breadcrumb -->
<div class=""bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <ol class=""breadcrumb my-auto"">
                    <li class=""breadcrumb-item"">  <i class='bx bx-home'></i> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfa66d4e077c43f9131fc5bb5cbcde6c3b5b8004191", async() => {
                WriteLiteral("Go To List");
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
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active""> <i class='bx bx-chevron-right'></i> <span> Book Details </span></li>
                </ol>
            </div>
        </div>
    </div>
</div>
<hr class=""m-0 custom"">
<!--=================================
Breadcrumb -->


<!--=================================
Book Details -->
<section id=""book_details"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4 my-5"">
                <img");
            BeginWriteAttribute("src", " src=\"", 919, "\"", 984, 2);
            WriteAttributeValue("", 925, "data:image\\/*;base64,", 925, 21, true);
#nullable restore
#line 32 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml"
WriteAttributeValue("", 946, Convert.ToBase64String(Model.Image), 946, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"custom-shadow3 w-75 mx-auto img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 1035, "\"", 1053, 1);
#nullable restore
#line 32 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml"
WriteAttributeValue("", 1041, Model.Title, 1041, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"col-md-8 my-5\">\r\n                <div class=\"detail-content\">\r\n                    <div class=\"deatil-head d-flex justify-content-between\">\r\n                        <h1>");
#nullable restore
#line 37 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <h6 class=\"rate ml-3 d-flex justify-content-center align-items-center\"><i class=\'bx bxs-star mr-2\'></i> ");
#nullable restore
#line 38 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml"
                                                                                                                           Write(Model.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <div class=\"detail-body\">\r\n                        <p>\r\n                            ");
#nullable restore
#line 42 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n\r\n                        <div class=\"mt-5\">\r\n                            <a href=\"#\" class=\"btn btn-primary custom-shadow2 mr-4\">Buy ");
#nullable restore
#line 46 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml"
                                                                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"$</a>
                            <a href=""#"" class=""btn btn-warning custom-shadow2""><i class='bx bx-heart mr-1'></i> Add To Book Shelf</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <h4 class=""mt-5"">Book Details:</h4>
        <div class=""details-info border custom-shadow p-3 mt-4"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <b>Genre:</b>
                    <p class=""text-muted"">");
#nullable restore
#line 58 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml"
                                     Write(Model.Genres.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <b>Price:</b>\r\n                    <p class=\"text-muted\">");
#nullable restore
#line 62 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml"
                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <b>Total Pages:</b>\r\n                    <p class=\"text-muted\">");
#nullable restore
#line 66 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Books\Details.cshtml"
                                     Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <div class=""col-md-3"">
                    <b>Originally Published:</b>
                    <p class=""text-muted"">11/05/2021</p>
                </div>
            </div>
        </div>
    </div>
</section>
<!--=================================
Book Details -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
