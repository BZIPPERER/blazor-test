#pragma checksum "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67fd1d7ab0eedf664823038b842ac0114c4007de"
// <auto-generated/>
#pragma warning disable 1591
namespace MafiaApplication.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\_Imports.razor"
using MafiaApplication.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\_Imports.razor"
using MafiaApplication.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-ersaffj188");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddAttribute(5, "b-ersaffj188");
            __builder.AddMarkupContent(6, "<div class=\"top-row px-4\" b-ersaffj188><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-ersaffj188>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "content px-4");
            __builder.AddAttribute(9, "b-ersaffj188");
            __builder.AddContent(10, 
#nullable restore
#line 13 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "sidebar");
            __builder.AddAttribute(14, "b-ersaffj188");
            __builder.OpenComponent<MafiaApplication.Client.Shared.NavMenu>(15);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591