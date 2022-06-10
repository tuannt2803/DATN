#pragma checksum "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "add07a81d4f17fc910c998e413b0e8d303f106f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add07a81d4f17fc910c998e413b0e8d303f106f7", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Giỏ hàng của bạn";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
  
    var listItem = (List<CartItem>)ViewBag.ListProductsInCart;
    var totalAll = (decimal)0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<div class=\"cart-main-area mtb-60px\">\r\n    <div class=\"container\">\r\n        <h3 class=\"cart-page-title\">Danh sách sản phẩm đã chọn</h3>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 col-md-8 col-sm-12 col-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "add07a81d4f17fc910c998e413b0e8d303f106f74275", async() => {
                WriteLiteral("\r\n                    <div class=\"table-content table-responsive cart-table-content\">\r\n");
#nullable restore
#line 17 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                         if (listItem?.Count > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <table>
                                <thead>
                                    <tr>
                                        <th>Hình ảnh</th>
                                        <th>Tên sản phẩm</th>
                                        <th>Giá</th>
                                        <th>Số lượng</th>
                                        <th>Thành tiền</th>
                                        <th>&nbsp</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 31 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                     foreach (var item in listItem)
                                    {
                                        var total = (decimal)0;
                                        {
                                            if (item.Product.IsPromote)
                                            {
                                                total = (decimal)(item.Product.PromotionPrice * item.Quantity);
                                            }
                                            else
                                            {
                                                total = (decimal)(item.Product.Price * item.Quantity);
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <td class=\"product-thumbnail\">\r\n                                                <a");
                BeginWriteAttribute("href", " href=\"", 2191, "\"", 2265, 1);
#nullable restore
#line 46 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2198, Url.Action("ProductDetails", "Home", new { id = item.Product.Id }), 2198, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img style=\"max-height: 100px;\"");
                BeginWriteAttribute("src", " src=\"", 2298, "\"", 2332, 1);
#nullable restore
#line 46 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2304, item.Product.MainImageThumb, 2304, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2333, "\"", 2339, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                                            </td>\r\n                                            <td class=\"product-name\"><a");
                BeginWriteAttribute("href", " href=\"", 2469, "\"", 2543, 1);
#nullable restore
#line 48 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2476, Url.Action("ProductDetails", "Home", new { id = item.Product.Id }), 2476, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 48 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                                                                                                                              Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                            <td class=\"product-price-cart\">\r\n");
#nullable restore
#line 50 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                                 if (item.Product.IsPromote)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <span class=\"amount\">");
#nullable restore
#line 52 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                                                    Write(item.Product.PromotionPrice.GetValueOrDefault(0).ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</span>\r\n");
#nullable restore
#line 53 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <span class=\"amount\">");
#nullable restore
#line 56 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                                                    Write(item.Product.Price.GetValueOrDefault(0).ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</span>\r\n");
#nullable restore
#line 57 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            </td>
                                            <td class=""product-quantity"">
                                                <div class=""cart-plus-minus"">
                                                    <div id=""dec"" class=""dec qtybutton"">-</div>
                                                    <input class=""cart-plus-minus-box txtQuantity"" data-id=""");
#nullable restore
#line 62 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                                                                                       Write(item.Product.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" type=\"text\" name=\"qtybutton\"");
                BeginWriteAttribute("value", " value=\"", 3730, "\"", 3752, 1);
#nullable restore
#line 62 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3738, item.Quantity, 3738, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                    <div id=""inc"" class=""inc qtybutton"">+</div>
                                                </div>
                                            </td>
                                            <td class=""product-subtotal"">");
#nullable restore
#line 66 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                                                    Write(total.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</td>\r\n                                            <td class=\"product-remove\">\r\n");
                WriteLiteral("                                                <a href=\"#\" data-id=\"");
#nullable restore
#line 69 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                                                Write(item.Product.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" aria-label=\"Xóa sản phẩm\" class=\"btn-delete\"><i class=\"fa fa-times\"></i></a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 72 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                        totalAll += total;
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </tbody>\r\n                            </table>\r\n");
#nullable restore
#line 76 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span>Chưa có sản phẩm nào trong giỏ hàng!</span>\r\n");
#nullable restore
#line 80 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-12\">\r\n                            <div class=\"cart-shiping-update-wrapper\">\r\n");
#nullable restore
#line 85 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                 if (listItem?.Count > 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <div class=""cart-shiping-update"">
                                        <a href=""/"" style=""background: #2e9ed5; color: #fff;"">Tiếp tục mua hàng</a>
                                    </div>
                                    <div class=""cart-clear"">
                                        <button id=""btnUpdate"" style=""background: #cc8212; color: #fff;"">Cập nhật giỏ hàng</button>
                                        <a role=""button"" style=""color: #fff; background: #a20c0c;"" id=""btnDeleteAll"">Xóa giỏ hàng</a>
                                    </div>
");
#nullable restore
#line 94 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"cart-shiping-update\">\r\n                                        <a href=\"/\" style=\"background: #2e9ed5; color: #fff;\">Tiếp tục mua hàng</a>\r\n                                    </div>\r\n");
#nullable restore
#line 100 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                <div class=""grand-totall"">
                    <div class=""title-wrap"">
                        <h4 class=""cart-bottom-title section-bg-gary-cart"">Cart Total</h4>
                    </div>
                    <h5>Tổng tiền sản phẩm <span>");
#nullable restore
#line 111 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
                                            Write(totalAll.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</span></h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 6659, "\"", 6696, 1);
#nullable restore
#line 112 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Index.cshtml"
WriteAttributeValue("", 6666, Url.Action("Payment", "Cart"), 6666, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Tiến hành đặt hàng</a>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    $(""#dec"").click(function () {
        var crdt = $(""#quantity"").val();
        if (crdt > 0) {
            crdt--;
        }
        $(""#quantity"").val(crdt);
    });
    $(""#inc"").click(function () {
        var crdt = $(""#quantity"").val();
        crdt++;
        $(""#quantity"").val(crdt);
    });
</script>
<script>
    $('#btnContinue').off('click').on('click', function () {
        window.location.href = ""/"";
    });
    $('#btnPayment').off('click').on('click', function () {
        window.location.href = ""/payment"";
    });
    $('#btnUpdate').off('click').on('click', function () {
        var listProduct = $('.txtQuantity');
        var cartList = [];
        $.each(listProduct, function (i, item) {
            cartList.push({
                Quantity: $(item).val(),
                Product: {
                    ID: $(item).data('id')
                },
   ");
            WriteLiteral(@"             Length: {
                    ID: $(item).data('length')
                },
                Color: {
                    ID: $(item).data('color')
                },
            });
        });

        $.ajax({
            url: '/Cart/Update',
            data: { cartModel: JSON.stringify(cartList) },
            dataType: 'json',
            type: 'POST',
            success: function (res) {
                if (res.status == true) {
                    window.location.href = ""/cart"";
                }
            }
        })
    });

    $('#btnDeleteAll').off('click').on('click', function () {
        $.ajax({
            url: '/Cart/DeleteAll',
            dataType: 'json',
            type: 'POST',
            success: function (res) {
                if (res.status == true) {
                    window.location.href = ""/cart"";
                }
            }
        })
    });

    $('.btn-delete').off('click').on('click', function (e) {
        e.preve");
            WriteLiteral(@"ntDefault();
        $.ajax({
            data: { id: $(this).data('id') },
            url: '/Cart/Delete',
            dataType: 'json',
            type: 'POST',
            success: function (res) {
                if (res.status == true) {
                    window.location.href = ""/cart"";
                }
            }
        })
    });
</script>");
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