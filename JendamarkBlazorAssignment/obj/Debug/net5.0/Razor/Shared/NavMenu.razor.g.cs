#pragma checksum "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1e248eef856acf8650a85d9996a8cf47dfe51b9"
// <auto-generated/>
#pragma warning disable 1591
namespace JendamarkBlazorAssignment.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using JendamarkBlazorAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using JendamarkBlazorAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Shared\NavMenu.razor"
       
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
