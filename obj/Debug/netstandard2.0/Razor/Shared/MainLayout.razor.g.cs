#pragma checksum "C:\Users\knu1\source\epi-info-boilerplate\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dafa9e3e707ffcde1d7d7b0e88a720ffcf4b03a0"
// <auto-generated/>
#pragma warning disable 1591
namespace epi_info_boilerplate.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using epi_info_boilerplate;
    using epi_info_boilerplate.Shared;
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "sidebar");
            builder.AddAttribute(2, "style", "z-index: 0");
            builder.AddMarkupContent(3, "\r\n    ");
            builder.OpenComponent<epi_info_boilerplate.Shared.NavMenu>(4);
            builder.CloseComponent();
            builder.AddMarkupContent(5, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(6, "\r\n\r\n");
            builder.OpenElement(7, "main");
            builder.AddAttribute(8, "style", "z-index: -1");
            builder.AddMarkupContent(9, "\r\n        ");
            builder.AddContent(10, Body);
            builder.AddMarkupContent(11, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
