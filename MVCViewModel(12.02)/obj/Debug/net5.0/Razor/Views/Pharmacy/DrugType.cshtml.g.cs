#pragma checksum "C:\Users\User\OneDrive\Рабочий стол\C#Practise\MVC\Views\Pharmacy\DrugType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79d243a85d1387e521ddcb748bdbbe0d1c500265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pharmacy_DrugType), @"mvc.1.0.view", @"/Views/Pharmacy/DrugType.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Рабочий стол\C#Practise\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Рабочий стол\C#Practise\MVC\Views\_ViewImports.cshtml"
using MVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79d243a85d1387e521ddcb748bdbbe0d1c500265", @"/Views/Pharmacy/DrugType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aefbdd7e30d8548302f0fc5e69eeb67f1c4118a", @"/Views/_ViewImports.cshtml")]
    public class Views_Pharmacy_DrugType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DrugType>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\OneDrive\Рабочий стол\C#Practise\MVC\Views\Pharmacy\DrugType.cshtml"
  
    ViewData["Title"] = "Drug";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1> Drug Types</h1>\r\n<ul>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\User\OneDrive\Рабочий стол\C#Practise\MVC\Views\Pharmacy\DrugType.cshtml"
       foreach(DrugType drugType in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>DrugType:");
#nullable restore
#line 10 "C:\Users\User\OneDrive\Рабочий стол\C#Practise\MVC\Views\Pharmacy\DrugType.cshtml"
                        Write(drugType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\Users\User\OneDrive\Рабочий стол\C#Practise\MVC\Views\Pharmacy\DrugType.cshtml"
            }

    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DrugType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
