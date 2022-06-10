#pragma checksum "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f6e5d24ef12ba0b7358e5da647973c95662562d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewsDetail), @"mvc.1.0.view", @"/Views/Home/NewsDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f6e5d24ef12ba0b7358e5da647973c95662562d", @"/Views/Home/NewsDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_NewsDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.DTOs.NewsViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
  
    ViewData["Title"] = "Chi tiết tin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
  
    var listRandomCategoryNews = (List<Entities.DTOs.CategoryNewsViewModel>)ViewBag.ListRandomCategoryNews;
    var listHotNewses = (List<Entities.DTOs.NewsViewModel>)ViewBag.ListHotNewses;
    var listRecentNews = (List<Entities.DTOs.NewsViewModel>)ViewBag.ListRecentNews;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""shop-category-area single-blog"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-9 order-lg-last col-md-12 order-md-first"">
                <div class=""blog-posts"">
                    <div class=""single-blog-post blog-grid-post"">
                        <div class=""blog-post-media"">
                            <div class=""blog-image single-blog"">
                                <a href=""#""><img");
            BeginWriteAttribute("src", " src=\"", 870, "\"", 893, 1);
#nullable restore
#line 19 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
WriteAttributeValue("", 876, Model.LargeImage, 876, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height: 400px;\" alt=\"blog\"></a>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"blog-post-content-inner\">\r\n                            <h4 class=\"blog-title\"><a href=\"#\">");
#nullable restore
#line 23 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <ul class=\"blog-page-meta\">\r\n                                <li>\r\n                                    <a href=\"#\"><i class=\"ion-person\"></i> ");
#nullable restore
#line 26 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                                                      Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\"><i class=\"ion-calendar\"></i> ");
#nullable restore
#line 29 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                                                        Write(Model.PostedDate?.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n                            </ul>\r\n                            <p>\r\n                                ");
#nullable restore
#line 33 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                           Write(Model.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                        <hr />\r\n                        <div class=\"single-post-content\">\r\n                            ");
#nullable restore
#line 38 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                       Write(Html.Raw(Model.NewsContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <!-- single blog post -->
                </div>
                <div class=""blog-single-tags-share d-sm-flex justify-content-between"">
                    <div class=""blog-single-share d-flex"">
                        <span class=""title"">Share:</span>
                        <ul class=""social"">
                            <li>
                                <a href=""#""><i class=""ion-social-facebook""></i></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""ion-social-twitter""></i></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""ion-social-google""></i></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""ion-social-instagram""></i></a>
                            </li>
                        <");
            WriteLiteral(@"/ul>
                    </div>
                </div>
                <div class=""blog-related-post"">
                    <div class=""row"">
                        <div class=""col-md-12 text-center"">
                            <!-- Section Title -->
                            <div class=""section-title underline-shape"">
                                <h2>Tin tức khác</h2>
                            </div>
                            <!-- Section Title -->
                        </div>
                    </div>
                    <div class=""row"">
");
#nullable restore
#line 73 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                         if (listRecentNews.Count > 0)
                        {
                            foreach (var ran in listRecentNews)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-4 mb-res-md-30px mb-res-sm-30px"">
                                    <div class=""blog-post-media"">
                                        <div class=""blog-image single-blog"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 3969, "\"", 4025, 1);
#nullable restore
#line 80 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
WriteAttributeValue("", 3976, Url.Action("News", "Home", new { id = @ran.Id }), 3976, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 4031, "\"", 4052, 1);
#nullable restore
#line 80 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
WriteAttributeValue("", 4037, ran.ThumbImage, 4037, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""max-height: 150px;"" alt=""blog""></a>
                                        </div>
                                    </div>
                                    <div class=""blog-post-content-inner"">
                                        <h4 class=""blog-title""><a href=""blog-single-left-sidebar.html"">");
#nullable restore
#line 84 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                                                                                  Write(ran.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                        <ul class=\"blog-page-meta\">\r\n                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4558, "\"", 4614, 1);
#nullable restore
#line 87 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
WriteAttributeValue("", 4565, Url.Action("News", "Home", new { id = @ran.Id }), 4565, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"ion-person\"></i> ");
#nullable restore
#line 87 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                                                                                                                  Write(ran.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4811, "\"", 4867, 1);
#nullable restore
#line 90 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
WriteAttributeValue("", 4818, Url.Action("News", "Home", new { id = @ran.Id }), 4818, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"ion-calendar\"></i> ");
#nullable restore
#line 90 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                                                                                                                    Write(ran.PostedDate?.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n                                        </ul>\r\n                                        <p>");
#nullable restore
#line 93 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                      Write(ran.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 96 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
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
#line 111 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                 if (listRandomCategoryNews.Count > 0)
                                {
                                    foreach (var ran in listRandomCategoryNews)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 6104, "\"", 6160, 1);
#nullable restore
#line 115 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
WriteAttributeValue("", 6111, Url.Action("News", "Home", new { id = @ran.Id }), 6111, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 115 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                                                                                   Write(ran.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> (");
#nullable restore
#line 115 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                                                                                                            Write(ran.NewsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></a></li>\r\n");
#nullable restore
#line 116 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
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
#line 127 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                             if (listRecentNews.Count > 0)
                            {
                                foreach (var ran in listRecentNews)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"recent-single-post d-flex\">\r\n                                        <div class=\"thumb-side\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 7076, "\"", 7137, 1);
#nullable restore
#line 133 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
WriteAttributeValue("", 7083, Url.Action("NewsDetail", "Home", new { id = ran.Id }), 7083, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 7143, "\"", 7164, 1);
#nullable restore
#line 133 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
WriteAttributeValue("", 7149, ran.ThumbImage, 7149, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7165, "\"", 7171, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        </div>\r\n                                        <div class=\"media-side\">\r\n                                            <h5><a href=\"#\">");
#nullable restore
#line 136 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                                       Write(ran.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h5>\r\n                                            <span class=\"date\">");
#nullable restore
#line 137 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
                                                          Write(ran.PostedDate?.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 140 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Home\NewsDetail.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.DTOs.NewsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
