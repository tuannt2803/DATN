#pragma checksum "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e313dd608e652f6a5ec6ab5549d58a1ad385afed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e313dd608e652f6a5ec6ab5549d58a1ad385afed", @"/Areas/Administrator/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administrator_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.Models.Users>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Danh sách tài khoản";
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 297, "\"", 325, 1);
#nullable restore
#line 11 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
WriteAttributeValue("", 304, Url.Action("Create"), 304, 21, false);

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
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""min-width: 150px;"">Tên đăng nhập</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""max-width: 150px;"">Họ tê");
            WriteLiteral(@"n nhân viên</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""max-width: 50px;"">Giới tính</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""max-width: 50px;"">Ngày sinh</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""max-width: 50px;"">Địa chỉ</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""max-width: 50px;"">Số điện thoại</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" style=""max-width: 50px;"">Email</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"">Thao tác</th>
                                    </tr>
             ");
            WriteLiteral("                   </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 33 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                     if (Model != null)
                                    {
                                        if (Model.Count() > 0)
                                        {
                                            var id = 1;
                                            foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr role=\"row\">\r\n                                                    <td>");
#nullable restore
#line 41 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                                   Write(id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 42 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                                   Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 43 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 44 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                                     if (item.Gender == 1)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>Nam</td>\r\n");
#nullable restore
#line 47 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                                    }
                                                    else if (item.Gender == 2)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>Nữ</td>\r\n");
#nullable restore
#line 51 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>Khác</td>\r\n");
#nullable restore
#line 55 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"

                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>");
#nullable restore
#line 57 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                                   Write(item.Birthday?.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 58 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 59 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 60 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
                                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 4306, "\"", 4353, 1);
#nullable restore
#line 62 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
WriteAttributeValue("", 4313, Url.Action("Edit", new { id = item.Id}), 4313, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <i class=""fa fa-edit""></i>
                                                        </a>
                                                        &nbsp;
                                                        <a onclick=""return confirm('Bạn có muốn xóa dữ liệu không?')""");
            BeginWriteAttribute("href", " href=\"", 4688, "\"", 4737, 1);
#nullable restore
#line 66 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
WriteAttributeValue("", 4695, Url.Action("Delete", new { id = item.Id}), 4695, 42, false);

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
#line 71 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Users\Index.cshtml"
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
            ""buttons"": [""copy"", ""csv"", ""excel"", ""pdf"", ""print"", ""colvis""]
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.Models.Users>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591