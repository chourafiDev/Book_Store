#pragma checksum "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f43afb63905f82636d4db8560e4ae972ee1de23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListOfBooks), @"mvc.1.0.view", @"/Views/Home/ListOfBooks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f43afb63905f82636d4db8560e4ae972ee1de23", @"/Views/Home/ListOfBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552e57ad1a6ad9fd180dcdef927f304904765f9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListOfBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book_Store.ViewModels.SearchIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetBooksByGenre", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex mx-auto ml-auto bg-white p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
  
    ViewData["Title"] = "Book Store - List Of Books";

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f43afb63905f82636d4db8560e4ae972ee1de236533", async() => {
                WriteLiteral("Home");
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
                    <li class=""breadcrumb-item active""> <i class='bx bx-chevron-right'></i> <span> Book List </span></li>
                </ol>
            </div>
        </div>
    </div>
</div>
<hr class=""m-0 custom"">
<!--=================================
Breadcrumb -->

<!--=================================
Listing – grid view -->
<section class=""space-ptb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""section-title mb-3 mb-lg-4"">
                    <h2><span class=""text-primary"">(");
#nullable restore
#line 33 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                               Write(ViewBag.CountBooks);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</span> Results</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 mb-5 mb-lg-0"">
                <div class=""sidebar"">
                    <div class=""widget"">
                        <div class=""widget-title widget-collapse"">
                            <h6>Genres List</h6>
                            <a class=""ml-auto"" data-toggle=""collapse"" href=""#type-property"" role=""button"" aria-expanded=""false"" aria-controls=""type-property""> <i class=""fas fa-chevron-down""></i> </a>
                        </div>
                        <div class=""collapse show"" id=""type-property"">
                            <ul class=""list-unstyled mb-0 pt-3"">
");
#nullable restore
#line 47 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                 foreach (var genre in Model.Genres)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f43afb63905f82636d4db8560e4ae972ee1de239694", async() => {
#nullable restore
#line 49 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                                                            Write(genre.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("<span class=\"ml-auto\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                                          WriteLiteral(genre.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</li>\r\n");
#nullable restore
#line 50 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                    <div class=""widget"">
                        <div class=""widget-title"">
                            <h6>Recently listed Books</h6>
                        </div>
");
#nullable restore
#line 58 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                         foreach (var Books in Model.BooksResent)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"recent-list-item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f43afb63905f82636d4db8560e4ae972ee1de2313165", async() => {
                WriteLiteral("\r\n                                    <img class=\"img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 2666, "\"", 2731, 2);
                WriteAttributeValue("", 2672, "data:image\\/*;base64,", 2672, 21, true);
#nullable restore
#line 62 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
WriteAttributeValue("", 2693, Convert.ToBase64String(Books.Image), 2693, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Recent Books\">\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                                                 WriteLiteral(Books.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                <div class=\"recent-list-item-info\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f43afb63905f82636d4db8560e4ae972ee1de2316320", async() => {
#nullable restore
#line 65 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                                                                                    Write(Books.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                                                                  WriteLiteral(Books.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                    <b class=\"text-primary\">Genre: ");
#nullable restore
#line 66 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                              Write(Books.Genres.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                    <span class=\"text-primary\">$");
#nullable restore
#line 67 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                           Write(Books.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 70 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-9\">\r\n                <div class=\"book-list\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 77 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                         foreach (var item in Model.Books)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4 mb-5\">\r\n                                <div class=\"item\">\r\n                                    <div class=\"image w-100\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f43afb63905f82636d4db8560e4ae972ee1de2320922", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 3840, "\"", 3904, 2);
                WriteAttributeValue("", 3846, "data:image\\/*;base64,", 3846, 21, true);
#nullable restore
#line 82 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
WriteAttributeValue("", 3867, Convert.ToBase64String(item.Image), 3867, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"book\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                    </div>\r\n                                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f43afb63905f82636d4db8560e4ae972ee1de2323956", async() => {
#nullable restore
#line 84 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</h4>\r\n                                    <p>Genre: ");
#nullable restore
#line 85 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                         Write(item.Genres.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"item-footer d-flex justify-content-between align-items-center\">\r\n                                        <b>$");
#nullable restore
#line 87 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                        <div class=\"d-flex\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f43afb63905f82636d4db8560e4ae972ee1de2327544", async() => {
                WriteLiteral("<i class=\'bx bx-show font-lg border icon-show-deails\'  title=\"Show Details\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            <a href=""#"" class=""mr-2""><i class='bx bx-heart font-lg border' title=""Favourite""></i></a>
                                            <span class=""badge rounded-pill bg-warning text-dark my-auto""><i class='bx bxs-star'></i> ");
#nullable restore
#line 91 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                                                                                                                                 Write(item.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 96 "D:\PROGRAMMING\ABDELMONAIME PROJECT\STAGE PROJECT\Book Store\Book Store\Views\Home\ListOfBooks.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--=================================
Listing – grid view -->



<!--=================================
newsletter -->
<section class=""py-5 bg-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5"">
                <h3 class=""text-white text-center mb-0 font-xl"">Sign up to our newsletter to get the latest news and offers.</h3>
            </div>
            <div class=""col-md-7 mt-3 mt-md-0"">
                <div class=""newsletter"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f43afb63905f82636d4db8560e4ae972ee1de2331860", async() => {
                WriteLiteral(@"
                        <div class=""form-group mb-0 w-75"">
                            <input type=""email"" class=""form-control"" placeholder=""Enter email"">
                        </div>
                        <button type=""submit"" class=""btn btn-primary btn-notified"">Get notified</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--=================================\r\nnewsletter -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book_Store.ViewModels.SearchIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
