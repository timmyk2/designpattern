#pragma checksum "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5aad714a52bc269ffe0242ba890e30a8e60a85b64806fe449899cc00a78b19ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ModelDienThoais_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ModelDienThoais/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\_ViewImports.cshtml"
using CuaHangDienThoai;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\_ViewImports.cshtml"
using CuaHangDienThoai.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5aad714a52bc269ffe0242ba890e30a8e60a85b64806fe449899cc00a78b19ba", @"/Areas/Admin/Views/ModelDienThoais/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d3e62aa939a7314c85d057392eb2b68dc9d99af67760b3794d59dd5fa2c9f1f6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ModelDienThoais_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CuaHangDienThoai.Models.View.ModelDienThoaisPaging>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DienThoais", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-default active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-primary active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::CuaHangDienThoai.TagHelpers.PageLinkTagHelper __CuaHangDienThoai_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
  
    ViewData["Title"] = "Danh sách mẫu điện thoại";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2 class=\"text-info\" style=\"text-align:center\">Danh sách mẫu điện thoại</h2>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aad714a52bc269ffe0242ba890e30a8e60a85b64806fe449899cc00a78b19ba9664", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp;Thêm mới mẫu điện thoại");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aad714a52bc269ffe0242ba890e30a8e60a85b64806fe449899cc00a78b19ba10978", async() => {
                WriteLiteral(@"
    <div>
        <div style=""height:200px; background-color:aliceblue"" class=""container"">
            <div class=""row"" style=""padding-top:10px;"">
                <label>Tìm kiếm</label>
            </div>
            <div class=""col-12"">
                <div class=""row"" style=""padding-top:10px;"">
                    <div class=""col-2"">
                        Tên mẫu
                    </div>
                    <div class=""col-3"">
                        ");
#nullable restore
#line 22 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                   Write(Html.Editor("searchName", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""col-2"">

                    </div>
                    <div class=""col-2"">
                        Tên hãng
                    </div>
                    <div class=""col-3"">
                        ");
#nullable restore
#line 31 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                   Write(Html.Editor("searchHang", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>

                </div>
                <div class=""row"" style=""padding-top:10px;"">
                    <div class=""col-2"">
                        Ram
                    </div>
                    <div class=""col-3"">
                        ");
#nullable restore
#line 40 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                   Write(Html.Editor("searchRam", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""col-2"">

                    </div>
                    <div class=""col-2"">
                        Rom
                    </div>
                    <div class=""col-3"">
                        ");
#nullable restore
#line 49 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                   Write(Html.Editor("searchRom", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>

                </div>
                <div class=""row"" style=""padding-top:10px;"">
                    <div class=""col-2"">
                    </div>
                    <div class=""col-3"">
                    </div>
                    <div class=""col-2"">

                    </div>
                    <div class=""col-2"">
                    </div>
                    <div class=""col-3"">
                        <button type=""submit"" name=""submit"" value=""Search"" class=""btn btn-primary form-control"">
                            <i class=""fas fa-search""></i> Search
                        </button>
                    </div>

                </div>
            </div>
        </div>
        <table class=""table table-striped border"">
            <tr class=""table-info"">
                <th>
                    ");
#nullable restore
#line 75 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.ModelDienThoais.FirstOrDefault().TenModel));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 78 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.ModelDienThoais.FirstOrDefault().Hang));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 81 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.ModelDienThoais.FirstOrDefault().Ram));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 84 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.ModelDienThoais.FirstOrDefault().Rom));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 87 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.ModelDienThoais.FirstOrDefault().ManHinh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 90 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.ModelDienThoais.FirstOrDefault().Camera));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 93 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.ModelDienThoais.FirstOrDefault().Chip));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n");
#nullable restore
#line 99 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
             foreach (var item in Model.ModelDienThoais)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aad714a52bc269ffe0242ba890e30a8e60a85b64806fe449899cc00a78b19ba17874", async() => {
#nullable restore
#line 103 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                                                                                                                                             Write(item.TenModel);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                                                                                                                      WriteLiteral(item.TenModel);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchName"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 106 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Hang.TenHang));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 109 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Ram));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 112 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Rom));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 116 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                   Write(Html.DisplayFor(m => item.ManHinh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 119 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Camera));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 123 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Chip));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width:150px\">\r\n                        <div class=\"btn-group\" role=\"group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aad714a52bc269ffe0242ba890e30a8e60a85b64806fe449899cc00a78b19ba23466", async() => {
                    WriteLiteral("\r\n                                <i class=\"fas fa-edit\"></i>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MaModel", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                                                                                              WriteLiteral(item.MaModel);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MaModel"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MaModel", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MaModel"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aad714a52bc269ffe0242ba890e30a8e60a85b64806fe449899cc00a78b19ba26131", async() => {
                    WriteLiteral("\r\n                                <i class=\"far fa-list-alt\"></i>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MaModel", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
                                                                                                 WriteLiteral(item.MaModel);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MaModel"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MaModel", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MaModel"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                           \r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 137 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n        <div class=\"form-group d-flex justify-content-center\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aad714a52bc269ffe0242ba890e30a8e60a85b64806fe449899cc00a78b19ba29229", async() => {
                }
                );
                __CuaHangDienThoai_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::CuaHangDienThoai.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__CuaHangDienThoai_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 140 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
__CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#nullable restore
#line 140 "D:\Mẫu TKPM\Project\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ModelDienThoais\Index.cshtml"
__CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CuaHangDienThoai.Models.View.ModelDienThoaisPaging> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
