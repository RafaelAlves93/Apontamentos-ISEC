#pragma checksum "C:\Users\brun0\Desktop\PWEB\PRATICAS\Ficha8\Ficha8\Ficha8\Views\Roles\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cfa88ccb1f7d748e9d3f71991728d80a6570848"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Detalhes), @"mvc.1.0.view", @"/Views/Roles/Detalhes.cshtml")]
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
#line 1 "C:\Users\brun0\Desktop\PWEB\PRATICAS\Ficha8\Ficha8\Ficha8\Views\_ViewImports.cshtml"
using Ficha8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brun0\Desktop\PWEB\PRATICAS\Ficha8\Ficha8\Ficha8\Views\_ViewImports.cshtml"
using Ficha8.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cfa88ccb1f7d748e9d3f71991728d80a6570848", @"/Views/Roles/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f677bfbb0f70a443e6a91373095f9926526e55c", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ficha8.Models.RoleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Detalhes da Role</h1>\r\nId = ");
#nullable restore
#line 4 "C:\Users\brun0\Desktop\PWEB\PRATICAS\Ficha8\Ficha8\Ficha8\Views\Roles\Detalhes.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nNome = ");
#nullable restore
#line 6 "C:\Users\brun0\Desktop\PWEB\PRATICAS\Ficha8\Ficha8\Ficha8\Views\Roles\Detalhes.cshtml"
  Write(Model.Nome);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ficha8.Models.RoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
