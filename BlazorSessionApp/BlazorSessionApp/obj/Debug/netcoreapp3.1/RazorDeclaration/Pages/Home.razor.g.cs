#pragma checksum "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a00bb2cc7a05ea5395c568259412e318103efda6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorSessionApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\_Imports.razor"
using BlazorSessionApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\_Imports.razor"
using BlazorSessionApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\Pages\Home.razor"
using Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\Pages\Home.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\Pages\Home.razor"
       

    public string Username { get; set; }
    public string Password { get; set; }


#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ali_h\source\repos\BlazorSessionApp\BlazorSessionApp\Pages\Home.razor"
            

    private async Task GetSession()
    {
        Username = accessor.HttpContext.Session.GetString("Username");
        Password = accessor.HttpContext.Session.GetString("Password");
        await InvokeAsync(()=> StateHasChanged());
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await GetSession();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor accessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionState session { get; set; }
    }
}
#pragma warning restore 1591
