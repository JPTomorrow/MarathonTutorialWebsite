// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MarathonTutorialWebsite.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using MarathonTutorialWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using MarathonTutorialWebsite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    public partial class ChooseLanguage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "D:\Code\blazor\MarathonTutorialWebsite\Shared\ChooseLanguage.razor"
       
    private string selectedCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
    private Dictionary<string, string> cultures;
    protected override void OnInitialized()
    {
        cultures = Configuration.GetSection("Cultures")
        .GetChildren().ToDictionary(x => x.Key, x => x.Value);
    }

    private void RequestCultureChange()
    {

        if (string.IsNullOrWhiteSpace(selectedCulture)) return;

        var uri = new Uri(NavigationManager.Uri)
        .GetComponents(UriComponents.PathAndQuery, UriFormat.Unescaped);

        var query = $"?culture={Uri.EscapeDataString(selectedCulture)}&" +
        $"redirectUri={Uri.EscapeDataString(uri)}";

        /* var prompt = "URI: " + uri + "\n\n" + Uri.EscapeDataString(uri) + "\n\n" + "QUERY: " + query;
        JSRuntime.InvokeVoidAsync("alert", prompt); */

        NavigationManager.NavigateTo("/Culture/SetCulture" + query, forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
