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
#line 1 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using MarathonTutorialWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using MarathonTutorialWebsite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "c:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Shared\MainLayout.razor"
       
    private void GoToTrainingVids()
    {
        navigationManager.NavigateTo("/");
    }

    private void GoToAbout()
    {
        navigationManager.NavigateTo("/about");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
