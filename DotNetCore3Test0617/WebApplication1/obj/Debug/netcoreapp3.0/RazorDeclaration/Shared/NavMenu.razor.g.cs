#pragma checksum "F:\资料\资料\demo\DotNetCore3Test0617\WebApplication1\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "039cd64acc17ef5fed9c613e6c154e86b95f8be7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "F:\资料\资料\demo\DotNetCore3Test0617\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "F:\资料\资料\demo\DotNetCore3Test0617\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "F:\资料\资料\demo\DotNetCore3Test0617\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "F:\资料\资料\demo\DotNetCore3Test0617\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "F:\资料\资料\demo\DotNetCore3Test0617\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "F:\资料\资料\demo\DotNetCore3Test0617\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#line 7 "F:\资料\资料\demo\DotNetCore3Test0617\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 28 "F:\资料\资料\demo\DotNetCore3Test0617\WebApplication1\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
