// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyFirstBlazorApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\akash\study\asp.net core\MyFirstBlazorApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\akash\study\asp.net core\MyFirstBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\akash\study\asp.net core\MyFirstBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\akash\study\asp.net core\MyFirstBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\akash\study\asp.net core\MyFirstBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\akash\study\asp.net core\MyFirstBlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\akash\study\asp.net core\MyFirstBlazorApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\akash\study\asp.net core\MyFirstBlazorApplication\_Imports.razor"
using MyFirstBlazorApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\akash\study\asp.net core\MyFirstBlazorApplication\_Imports.razor"
using MyFirstBlazorApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\akash\study\asp.net core\MyFirstBlazorApplication\Pages\ReciepeList.razor"
using DataAcesss.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\akash\study\asp.net core\MyFirstBlazorApplication\Pages\ReciepeList.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reciepes")]
    public partial class ReciepeList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\akash\study\asp.net core\MyFirstBlazorApplication\Pages\ReciepeList.razor"
       
    List<Recepie> Recipes = new List<Recepie>();

    protected override async Task OnInitializedAsync()
    {
        Recipes = RecepieService.List();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecepieService RecepieService { get; set; }
    }
}
#pragma warning restore 1591
