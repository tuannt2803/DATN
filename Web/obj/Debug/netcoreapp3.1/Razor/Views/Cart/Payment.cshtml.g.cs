#pragma checksum "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3fd14be34bfbae9cfd035eebffcfa2e1a66bb3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Payment), @"mvc.1.0.view", @"/Views/Cart/Payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3fd14be34bfbae9cfd035eebffcfa2e1a66bb3e", @"/Views/Cart/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.DTOs.OrderRequestViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Nhập vào họ và tên của bạn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Nhập vào số điện thoại của bạn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Nhập vào email của bạn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Nhập vào địa chỉ chi tiết của bạn (số nhà, tên đường, huyện, tỉnh)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Nhập vào ghi chú đặt hàng"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
  
    ViewData["Title"] = "Payment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
  
    var listItem = (List<CartItem>)ViewBag.ListProductsInCart;
    var totalAll = (decimal)0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .your-order-area .Place-order > button {
        background-color: #2e9ed5;
        color: #fff;
        display: block;
        font-weight: 700;
        letter-spacing: 1px;
        line-height: 1;
        padding: 18px 20px;
        text-align: center;
        text-transform: uppercase;
        border-radius: 50px;
        z-index: 9;
        width: 100%;
        border: #fff;
    }
</style>
<hr />
<div class=""checkout-area mt-60px mb-40px"">
    <div class=""container"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3fd14be34bfbae9cfd035eebffcfa2e1a66bb3e7919", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 31 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-lg-7"">
                    <div class=""billing-info-wrap"">
                        <h3>Thông tin giao hàng</h3>
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12"">
                                <div class=""billing-info mb-20px"">
                                    <label>Họ và tên <span class=""text-red"">*</span></label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3fd14be34bfbae9cfd035eebffcfa2e1a66bb3e8906", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 40 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerFullName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""billing-info mb-20px"">
                                    <label>Số điện thoại <span class=""text-red"">*</span></label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3fd14be34bfbae9cfd035eebffcfa2e1a66bb3e11346", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 46 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerPhone);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""billing-info mb-20px"">
                                    <label>Email</label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3fd14be34bfbae9cfd035eebffcfa2e1a66bb3e13742", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 52 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerEmail);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""billing-info mb-20px"">
                                    <label>Địa chỉ <span class=""text-red"">*</span></label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3fd14be34bfbae9cfd035eebffcfa2e1a66bb3e15851", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 58 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerAddress);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""text-right"">
                            <label>Các trường có dấu <span class=""text-red"">*</span> không được bỏ trống</label>
                        </div>
                        <div class=""additional-info-wrap"">
                            <h4>Thông tin thêm</h4>
                            <div class=""additional-info"">
                                <label>Ghi chú đặt hàng</label>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3fd14be34bfbae9cfd035eebffcfa2e1a66bb3e18535", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 69 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerNote);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-5"">
                    <div class=""your-order-area"">
                        <h3>Chi tiết đơn hàng</h3>
                        <div class=""your-order-wrap gray-bg-4"">
                            <div class=""your-order-product-info"">
                                <div class=""your-order-top"">
                                    <ul>
                                        <li>Sản phẩm</li>
                                        <li>Thành tiền</li>
                                    </ul>
                                </div>
                                <div class=""your-order-middle"">
                                    <ul>
");
#nullable restore
#line 87 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
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
                WriteLiteral("                                            <li><span class=\"order-middle-left\">");
#nullable restore
#line 100 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
                                                                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" X ");
#nullable restore
#line 100 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
                                                                                                Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> <span class=\"order-price\">");
#nullable restore
#line 100 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
                                                                                                                                                Write(total.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</span></li>\r\n");
#nullable restore
#line 101 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
                                            totalAll += total;
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </ul>
                                </div>
                                <div class=""your-order-bottom"">
                                    <ul>
                                        <li class=""your-order-shipping"">Phí ship</li>
                                        <li>Miễn phí</li>
                                    </ul>
                                </div>
                                <div class=""your-order-total"">
                                    <ul>
                                        <li class=""order-total"">Tổng tiền</li>
                                        <li>");
#nullable restore
#line 114 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
                                       Write(totalAll.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" đ</li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""payment-method"">
                                <div class=""payment-accordion element-mrg"">
                                    <div class=""panel-group"" id=""accordion"">
                                        <div class=""panel payment-accordion"">
                                            <div class=""panel-heading"" id=""method-one"">
                                                <h4 class=""panel-title"">
                                                    <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#method1"">
                                                        Chuyển khoản ngân hàng
                                                    </a>
                                                </h4>
                                            </div>
                                            <div id=""method1"" class=""panel-");
                WriteLiteral(@"collapse collapse show"">
                                                <div class=""panel-body"">
                                                    <p>
                                                        Vui lòng chuyển khoản thanh toán trước khi đặt hàng về tài khoản sau: <br />
                                                        <b>- 10763989 - Ngân hàng Á Châu ACB - TuNga Computer<br /></b>
                                                        <b>- 03233733301 - Ngân hàng Tiền Phong TPBank - TuNga Computer <br /></b>
                                                        <b>- 10463755014 - Ngân hàng TMCP Kỹ thương Việt Nam Techcombank - TuNga Computer <br /></b>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""panel payment-accordion"">
                                     ");
                WriteLiteral(@"       <div class=""panel-heading"" id=""method-three"">
                                                <h4 class=""panel-title"">
                                                    <a class=""collapsed"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#method3"">
                                                        COD
                                                    </a>
                                                </h4>
                                            </div>
                                            <div id=""method3"" class=""panel-collapse collapse"">
                                                <div class=""panel-body"">
                                                    <p>Quý khách sẽ thanh toán bằng tiền mặt khi nhận hàng. Vui lòng bấm ""<b>Đặt hàng</b>"" để hoàn tất</p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
     ");
                WriteLiteral(@"                           </div>
                            </div>
                        </div>
                        <div class=""Place-order mt-25"">
                            <button type=""submit"" class=""btn-hover"">Đặt hàng</button>
                        </div>
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Views\Cart\Payment.cshtml"
AddHtmlAttributeValue("", 768, Url.Action("Payment", "Cart"), 768, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.DTOs.OrderRequestViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
