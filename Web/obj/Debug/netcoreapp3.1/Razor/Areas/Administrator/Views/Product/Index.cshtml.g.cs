#pragma checksum "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0adf1f4e9ebbbef76736f234c43a45fc8ae1efb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Product/Index.cshtml")]
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
#line 1 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0adf1f4e9ebbbef76736f234c43a45fc8ae1efb7", @"/Areas/Administrator/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administrator_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.DTOs.ProductViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Danh sách sản phẩm";
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 305, "\"", 333, 1);
#nullable restore
#line 11 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
WriteAttributeValue("", 312, Url.Action("Create"), 312, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success float-right"">Thêm mới</a>
            </div>
            <!-- /.card-header -->
            <div class=""card-body"">
                <div id=""example1_wrapper"" class=""dataTables_wrapper dt-bootstrap4"">
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <table id=""example1"" class=""table table-bordered table-striped dataTable dtr-inline"" role=""grid"" aria-describedby=""example1_info"">
                                <thead>
                                    <tr role=""row"">
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"">Id</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"">Mã SP</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""min-width: 300px;"">Tên SP</th>
                          ");
            WriteLiteral(@"              <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""max-width: 100px;"">Danh mục</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""max-width: 50px;"">Sản phẩm hot</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""max-width: 50px;"">Hiển thị trang chủ</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"">Đang sales</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"">Giá gốc</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"">Giá sales</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"">Thao tác</th>");
            WriteLiteral("\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 34 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                     if (Model != null)
                                    {
                                        if (Model?.Count() > 0)
                                        {
                                            var id = 1;
                                            foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr role=\"row\">\r\n                                                    <td>");
#nullable restore
#line 42 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                   Write(id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 43 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                   Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 44 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 45 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                   Write(item.ProductCategory?.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                     if (item.IsHot == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>Có</td>\r\n");
#nullable restore
#line 49 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>Không</td>\r\n");
#nullable restore
#line 53 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                     if (item.IsHome == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>Có</td>\r\n");
#nullable restore
#line 57 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>Không</td>\r\n");
#nullable restore
#line 61 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                     if (item.IsPromote == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>Có</td>\r\n");
#nullable restore
#line 65 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>Không</td>\r\n");
#nullable restore
#line 69 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>");
#nullable restore
#line 70 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 71 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                   Write(item.PromotionPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n");
            WriteLiteral("                                                        <a");
            BeginWriteAttribute("href", " href=\"", 5375, "\"", 5428, 1);
#nullable restore
#line 76 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
WriteAttributeValue("", 5382, Url.Action("MoreImages", new { id = item.Id}), 5382, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""tooltip"" data-placement=""top"" title=""Thêm ảnh sản phẩm"">
                                                            &nbsp;
                                                            <i class=""fa fa-camera""></i>
                                                        </a>
                                                        <a");
            BeginWriteAttribute("href", " href=\"", 5779, "\"", 5826, 1);
#nullable restore
#line 80 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
WriteAttributeValue("", 5786, Url.Action("Edit", new { id = item.Id}), 5786, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""tooltip"" data-placement=""top"" title=""Sửa thông tin sản phẩm"">
                                                            &nbsp;
                                                            <i class=""fa fa-edit""></i>
                                                        </a>
                                                        &nbsp;
                                                        <a onclick=""return confirm('Bạn có muốn xóa dữ liệu không?')""");
            BeginWriteAttribute("href", " href=\"", 6303, "\"", 6352, 1);
#nullable restore
#line 85 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
WriteAttributeValue("", 6310, Url.Action("Delete", new { id = item.Id}), 6310, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <i class=""fa fa-trash""></i>
                                                        </a>
                                                    </td>
                                                </tr>
");
#nullable restore
#line 90 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Product\Index.cshtml"
                                                id++;
                                            }
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /.card-body -->
        </div>
        <!-- /.card -->
    </div>
    <!-- /.col -->
</div>

<!-- Page specific script -->
<script>
    $(function () {
        $(""#example1"").DataTable({
            ""paging"": true,
            ""lengthChange"": false,
            ""searching"": true,
            ""ordering"": true,
            ""info"": true,
            ""autoWidth"": false,
            ""responsive"": true,
        }).buttons().container().appendTo('#example1 .col-md-6:eq(0)');
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.DTOs.ProductViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
