#pragma checksum "D:\C# Projects\Handin1\DNPHandin1\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3199a451d9050e3e50c1fd105fe4799756b9682f"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPHandin1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C# Projects\Handin1\DNPHandin1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# Projects\Handin1\DNPHandin1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C# Projects\Handin1\DNPHandin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C# Projects\Handin1\DNPHandin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C# Projects\Handin1\DNPHandin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C# Projects\Handin1\DNPHandin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C# Projects\Handin1\DNPHandin1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C# Projects\Handin1\DNPHandin1\_Imports.razor"
using DNPHandin1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C# Projects\Handin1\DNPHandin1\_Imports.razor"
using DNPHandin1.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>DNPHandin1</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\C# Projects\Handin1\DNPHandin1\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "D:\C# Projects\Handin1\DNPHandin1\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\C# Projects\Handin1\DNPHandin1\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "Login");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "D:\C# Projects\Handin1\DNPHandin1\Shared\NavMenu.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-lock-locked\" aria-hidden=\"true\"></span> Login\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "Registration");
            __builder.AddAttribute(34, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "D:\C# Projects\Handin1\DNPHandin1\Shared\NavMenu.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                <span class=\"oi oi-person\" aria-hidden=\"true\"></span> Registration\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(39);
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenElement(42, "li");
                __builder2.AddAttribute(43, "class", "nav-item px-3");
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
                __builder2.AddAttribute(46, "class", "nav-link");
                __builder2.AddAttribute(47, "href", "AdultsList");
                __builder2.AddAttribute(48, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 22 "D:\C# Projects\Handin1\DNPHandin1\Shared\NavMenu.razor"
                                                                   NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "\r\n                    <span class=\"oi oi-list\" aria-hidden=\"true\"></span> Adults List\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenElement(53, "li");
                __builder2.AddAttribute(54, "class", "nav-item px-3");
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(56);
                __builder2.AddAttribute(57, "class", "nav-link");
                __builder2.AddAttribute(58, "href", "AddAdult");
                __builder2.AddAttribute(59, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 27 "D:\C# Projects\Handin1\DNPHandin1\Shared\NavMenu.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(61, "\r\n                    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Add Adults\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\C# Projects\Handin1\DNPHandin1\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591