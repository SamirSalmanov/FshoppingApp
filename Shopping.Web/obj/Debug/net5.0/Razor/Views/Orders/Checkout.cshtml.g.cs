#pragma checksum "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be438b877698dbc3f66bb391a9a92b13576dce23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Checkout), @"mvc.1.0.view", @"/Views/Orders/Checkout.cshtml")]
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
#line 1 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\_ViewImports.cshtml"
using Shopping.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\_ViewImports.cshtml"
using Shopping.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\_ViewImports.cshtml"
using Shopping.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be438b877698dbc3f66bb391a9a92b13576dce23", @"/Views/Orders/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"307e35433f4ab5757a77b4fb4780eb3d51a05f52", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckoutVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- breadcrumb-area start -->
<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""row breadcrumb_box  align-items-center"">
                    <div class=""col-lg-6 col-md-6 col-sm-12 text-center text-md-left"">
                        <h2 class=""breadcrumb-title"">Shop</h2>
                    </div>
                    <div class=""col-lg-6  col-md-6 col-sm-12"">
                        <!-- breadcrumb-list start -->
                        <ul class=""breadcrumb-list text-center text-md-right"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"">Checkout</li>
                        </ul>
                        <!-- breadcrumb-list end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- breadcrumb-area end -->
<!-- checkout area start");
            WriteLiteral(" -->\r\n");
#nullable restore
#line 30 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
 if (Model != null && Model.Products != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""checkout-area pt-100px pb-100px"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-7"">
                    <div class=""billing-info-wrap"">
                        <h3>Billing Details</h3>
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>First Name</label>
                                    <input readonly");
            BeginWriteAttribute("value", " value=\"", 1647, "\"", 1685, 1);
#nullable restore
#line 42 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
WriteAttributeValue("", 1655, Model.SUsers.Result.Firstname, 1655, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" />
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>Last Name</label>
                                    <input readonly");
            BeginWriteAttribute("value", " value=\"", 2018, "\"", 2055, 1);
#nullable restore
#line 48 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
WriteAttributeValue("", 2026, Model.SUsers.Result.Lastname, 2026, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" />
                                </div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""billing-info mb-4"">
                                    <label>Street Address</label>
                                    <input id=""Address"" placeholder=""Apartment, suite, unit etc."" type=""text"" />
                                </div>
                            </div>

                            <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>Phone</label>
                                    <input id=""PhoneNumber""");
            BeginWriteAttribute("value", " value=\"", 2769, "\"", 2809, 1);
#nullable restore
#line 61 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
WriteAttributeValue("", 2777, Model.SUsers.Result.PhoneNumber, 2777, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" />
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>Email Address</label>
                                    <input readonly type=""text""");
            BeginWriteAttribute("value", " value=\"", 3158, "\"", 3196, 1);
#nullable restore
#line 67 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
WriteAttributeValue("", 3166, Model.SUsers.Result.Firstname, 3166, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
                                </div>
                            </div>
                        </div>
                        <div class=""additional-info-wrap"">
                            <h4>Additional information</h4>
                            <div class=""additional-info"">
                                <label>Order notes</label>
                                <textarea placeholder=""Notes about your order, e.g. special notes for delivery. "" name=""message""></textarea>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-5 mt-md-30px mt-lm-30px "">
                    <div class=""your-order-area"">
                        <h3>Your order</h3>
                        <div class=""your-order-wrap gray-bg-4"">
                            <div class=""your-order-product-info"">
                                <div class=""your-order-top"">
                                    <ul>
               ");
            WriteLiteral(@"                         <li>Product</li>
                                        <li>Total</li>
                                    </ul>
                                </div>
                                <div class=""your-order-middle"">
                                    <ul>
");
#nullable restore
#line 93 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
                                          
                                            decimal total = 0;
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
                                         foreach (var product in Model.Products)
                                        {
                                            int quantiy = Model.ProductIds.Where(x => x == product.ID).Count();
                                            total += quantiy * product.Price;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><span class=\"order-middle-left\">");
#nullable restore
#line 100 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
                                                                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" X ");
#nullable restore
#line 100 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
                                                                                           Write(quantiy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"order-price\">");
#nullable restore
#line 100 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
                                                                                                                                      Write(quantiy*product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼</span></li>\r\n");
#nullable restore
#line 101 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </div>
                                <div class=""your-order-bottom"">
                                    <ul>
                                        <li class=""your-order-shipping"">Shipping</li>
                                        <li>Free shipping</li>
                                    </ul>
                                </div>
                                <div class=""your-order-total"">
                                    <ul>
                                        <li class=""order-total"">Total</li>
                                        <li>");
            WriteLiteral("</li>\r\n                                        <li>");
#nullable restore
#line 114 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
                                       Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ₼</li>

                                    </ul>
                                </div>
                            </div>
                            <div class=""payment-method"">
                                <div class=""payment-accordion element-mrg"">
                                    <div id=""faq"" class=""panel-group"">
                                        <div class=""panel panel-default single-my-account m-0"">
                                            <div class=""panel-heading my-account-title"">
                                                <h4 class=""panel-title"">
                                                    <a data-bs-toggle=""collapse"" href=""#my-account-1"" class=""collapsed"" aria-expanded=""true"">Direct bank transfer</a>
                                                </h4>
                                            </div>
                                            <div id=""my-account-1"" class=""panel-collapse collapse show"" data-bs-parent=""#faq"">

                      ");
            WriteLiteral(@"                          <div class=""panel-body"">
                                                    <p>Please send a check to Store Name, Store Street, Store Town, Store State / County, Store Postcode.</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""panel panel-default single-my-account m-0"">
                                            <div class=""panel-heading my-account-title"">
                                                <h4 class=""panel-title""><a data-bs-toggle=""collapse"" href=""#my-account-2"" aria-expanded=""false"" class=""collapsed"">Check payments</a></h4>
                                            </div>
                                            <div id=""my-account-2"" class=""panel-collapse collapse"" data-bs-parent=""#faq"">

                                                <div class=""panel-body"">
                                ");
            WriteLiteral(@"                    <p>Please send a check to Store Name, Store Street, Store Town, Store State / County, Store Postcode.</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""panel panel-default single-my-account m-0"">
                                            <div class=""panel-heading my-account-title"">
                                                <h4 class=""panel-title""><a data-bs-toggle=""collapse"" href=""#my-account-3"">Cash on delivery</a></h4>
                                            </div>
                                            <div id=""my-account-3"" class=""panel-collapse collapse"" data-bs-parent=""#faq"">

                                                <div class=""panel-body"">
                                                    <p>Please send a check to Store Name, Store Street, Store Town, Store State / County, Store Postcode.<");
            WriteLiteral(@"/p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""Place-order mt-25"">
                            <a class=""btn-hover"" href=""#"">Place Order</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 169 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Cart area start -->
                    <div class=""empty-cart-area pb-100px pt-100px"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""cart-heading"">
                                        <h2>Your cart item</h2>
                                    </div>
                                    <div class=""empty-text-contant text-center"">
                                        <i class=""icon-handbag""></i>
                                        <h1>There are no more items in your cart</h1>
                                        <a class=""empty-cart-btn"" href=""/"">
                                            <i class=""ion-ios-arrow-left""> </i> Continue shopping
                                        </a>
                                    </div>
                                </div>
                            </div>
                  ");
            WriteLiteral("      </div>\r\n                    </div>\r\n    <!-- Cart area end -->\r\n");
#nullable restore
#line 192 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Orders\Checkout.cshtml"
 }

#line default
#line hidden
#nullable disable
            DefineSection("Script", async() => {
                WriteLiteral(@" 
<script>
    $("".Place-order .btn-hover"").click(function (e) {
        e.preventDefault()
        $.ajax({
            url: ""/Orders/PlacedProduct"",
            method: ""Post"",
            data: {
                Address: $(""#Address"").val(),
                PhoneNumber: $(""#PhoneNumber"").val()
            },
            success: function () {
                Swal.fire(
                    'Mehsul sifaris olundu',
                    'Sizinle Tezlikle elaqe saxlanildi!',
                    'success'
                )
                setTimeout(function () {
                    window.location.reload()
                },1500)
            }
        })
    })
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
