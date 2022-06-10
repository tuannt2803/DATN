#pragma checksum "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "862b78ea0234c2946d6ca5fa0afb8604ab3ed022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_News), @"mvc.1.0.view", @"/Views/Home/News.cshtml")]
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
#line 1 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"862b78ea0234c2946d6ca5fa0afb8604ab3ed022", @"/Views/Home/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
  
    ViewData["Title"] = "Tin tức";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
  
    var newses = (Entities.Common.PaginationModel<List<Entities.DTOs.NewsViewModel>>)ViewBag.ListMainNews;
    var countPage = (newses.Pagination.Total % newses.Pagination.Size > 1) ? newses.Pagination.Total / newses.Pagination.Size + 1 :
        newses.Pagination.Total / newses.Pagination.Size + 1;
    var currentCategoryId = newses.Data.FirstOrDefault() != null ? newses.Data.FirstOrDefault().currentCategoryId : 1;
    var currentPage = newses.Pagination.Offset + 1;
    bool isNext = (currentPage < countPage);
    bool isPrev = (currentPage > 1);
    string currentOrder = ViewBag.CurrentOrder?.ToString();
    var currentCategory = ViewBag.CurrentCategory.ToString();

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
  
    var listRandomCategoryNews = (List<Entities.DTOs.CategoryNewsViewModel>)ViewBag.ListRandomCategoryNews;
    var listHotNewses = (List<Entities.DTOs.NewsViewModel>)ViewBag.ListHotNewses;
    var listRecentNews = (List<Entities.DTOs.NewsViewModel>)ViewBag.ListRecentNews;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""shop-category-area blog-grid"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-9 order-lg-last col-md-12 order-md-first"">
                <div class=""blog-posts"">
                    <div class=""row"">
");
#nullable restore
#line 28 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                         if (newses.Data.Count > 0)
                        {
                            foreach (var ran in newses.Data)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-6 mb-res-sm-30px"">
                                    <div class=""single-blog-post blog-grid-post"">
                                        <div class=""blog-post-media"">
                                            <div class=""blog-image"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 1842, "\"", 1903, 1);
#nullable restore
#line 36 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 1849, Url.Action("NewsDetail", "Home", new { id = ran.Id }), 1849, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1909, "\"", 1930, 1);
#nullable restore
#line 36 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 1915, ran.ThumbImage, 1915, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""blog""></a>
                                            </div>
                                        </div>
                                        <div class=""blog-post-content-inner mt-30"">
                                            <h4 class=""blog-title""><a");
            BeginWriteAttribute("href", " href=\"", 2203, "\"", 2264, 1);
#nullable restore
#line 40 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 2210, Url.Action("NewsDetail", "Home", new { id = ran.Id }), 2210, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                                                                                                               Write(ran.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                            <ul class=\"blog-page-meta\">\r\n                                                <li>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2468, "\"", 2529, 1);
#nullable restore
#line 43 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 2475, Url.Action("NewsDetail", "Home", new { id = ran.Id }), 2475, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"ion-person\"></i> ");
#nullable restore
#line 43 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                                                                                                                           Write(ran.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n                                                <li>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2738, "\"", 2799, 1);
#nullable restore
#line 46 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 2745, Url.Action("NewsDetail", "Home", new { id = ran.Id }), 2745, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"ion-calendar\"></i> ");
#nullable restore
#line 46 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                                                                                                                             Write(ran.PostedDate?.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n                                            </ul>\r\n                                            <p>\r\n                                                ");
#nullable restore
#line 50 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                           Write(ran.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                            <a class=\"read-more-btn\"");
            BeginWriteAttribute("href", " href=\"", 3211, "\"", 3272, 1);
#nullable restore
#line 52 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 3218, Url.Action("NewsDetail", "Home", new { id = ran.Id }), 3218, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"> Chi tiết <i class=""ion-android-arrow-dropright-circle""></i></a>
                                        </div>
                                    </div>
                                    <!-- single blog post -->
                                </div>
");
#nullable restore
#line 57 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <!--  Pagination Area Start -->\r\n                <div class=\"pro-pagination-style text-center\">\r\n                    <ul>\r\n");
#nullable restore
#line 64 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                         if (isPrev)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a class=\"prev\"");
            BeginWriteAttribute("href", " href=\"", 3930, "\"", 4020, 1);
#nullable restore
#line 67 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 3937, Url.Action("News", "Home", new { id = currentCategoryId, page = (currentPage-1) }), 3937, 83, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"ion-ios-arrow-left\"></i></a>\r\n                            </li>\r\n");
#nullable restore
#line 69 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                         for (int i = 1; i <= countPage; i++)
                        {
                            if (currentPage == i)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <a class=\"active\"");
            BeginWriteAttribute("href", " href=\"", 4387, "\"", 4463, 1);
#nullable restore
#line 75 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 4394, Url.Action("News", "Home", new { id = currentCategoryId, page = i }), 4394, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 76 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 79 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4764, "\"", 4840, 1);
#nullable restore
#line 83 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 4771, Url.Action("News", "Home", new { id = currentCategoryId, page = i }), 4771, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 84 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 87 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                         if (isNext)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a class=\"next\"");
            BeginWriteAttribute("href", " href=\"", 5173, "\"", 5263, 1);
#nullable restore
#line 92 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 5180, Url.Action("News", "Home", new { id = currentCategoryId, page = (currentPage+1) }), 5180, 83, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"ion-ios-arrow-right\"></i></a>\r\n                            </li>\r\n");
#nullable restore
#line 94 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
                <!--  Pagination Area End -->
            </div>
            <!-- Sidebar Area Start -->
            <div class=""col-lg-3 order-lg-first col-md-12 order-md-last mb-res-md-60px mb-res-sm-60px"">
                <div class=""left-sidebar"">
                    <!-- Sidebar single item -->
                    <div class=""sidebar-widget mt-40"">
                        <div class=""main-heading"">
                            <h2>Danh mục</h2>
                        </div>
                        <div class=""category-post"">
                            <ul>
");
#nullable restore
#line 109 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                 if (listRandomCategoryNews.Count > 0)
                                {
                                    foreach (var ran in listRandomCategoryNews)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 6273, "\"", 6329, 1);
#nullable restore
#line 113 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 6280, Url.Action("News", "Home", new { id = @ran.Id }), 6280, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 113 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                                                                                   Write(ran.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> (");
#nullable restore
#line 113 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                                                                                                            Write(ran.NewsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></a></li>\r\n");
#nullable restore
#line 114 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                    <!-- Sidebar single item -->
                    <div class=""sidebar-widget mt-40"">
                        <div class=""main-heading"">
                            <h2>Bài viết gần đây</h2>
                        </div>
                        <div class=""recent-post-widget"">
");
#nullable restore
#line 125 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                             if (listRecentNews.Count > 0)
                            {
                                foreach (var ran in listRecentNews)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"recent-single-post d-flex\">\r\n                                        <div class=\"thumb-side\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 7245, "\"", 7306, 1);
#nullable restore
#line 131 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 7252, Url.Action("NewsDetail", "Home", new { id = ran.Id }), 7252, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 7312, "\"", 7333, 1);
#nullable restore
#line 131 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
WriteAttributeValue("", 7318, ran.ThumbImage, 7318, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7334, "\"", 7340, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        </div>\r\n                                        <div class=\"media-side\">\r\n                                            <h5><a href=\"#\">");
#nullable restore
#line 134 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                                       Write(ran.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h5>\r\n                                            <span class=\"date\">");
#nullable restore
#line 135 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                                          Write(ran.PostedDate?.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 138 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\News.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!-- Sidebar Area End -->\r\n        </div>\r\n    </div>\r\n</div>");
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
