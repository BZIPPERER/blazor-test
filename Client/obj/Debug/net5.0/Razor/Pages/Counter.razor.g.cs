#pragma checksum "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76dd38633aef6096ce007c72d7753ead5c380b5c"
// <auto-generated/>
#pragma warning disable 1591
namespace MafiaApplication.Client.Pages
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
#nullable restore
#line 2 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Pages\Counter.razor"
using MafiaApplication.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Pages\Counter.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Einwohnerliste</h1>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr style=\"background-color:grey;color:white\"><td>\r\n            Vorname\r\n        </td>\r\n        <td>\r\n            Nachname\r\n        </td>\r\n        <td>\r\n            Wohnort / Ort\r\n        </td><td></td></tr></thead>\r\n");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 20 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Pages\Counter.razor"
     foreach (var item in items)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 23 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Pages\Counter.razor"
                 item.Name.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 24 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Pages\Counter.razor"
                 item.LastName.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 25 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Pages\Counter.razor"
                 item.Location.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "<td><button class=\"btn btn-primary\">Bewohner entfernen</button></td>");
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Pages\Counter.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Benjamin\source\repo\MafiaApplication\Client\Pages\Counter.razor"
                                          
    

    private int currentCount = 0;

    private ObservableCollection<DataItem> items = 
        new ObservableCollection<DataItem>();
 
    protected override async Task OnInitializedAsync()
    {
        // this method runs on page start and fetches CSV data
        // from path C:\Users\Benjamin\Downloads\100-Sales-Records


        DataItem punkt1 = new DataItem()
        {
            LastName = "Zipperer",
            Name = "Benjamin",
            Location = "Altdorf"
        };
        items.Add(punkt1);

        DataItem punkt11 = new DataItem()
        {
            LastName = "Müller",
            Name = "Hans",
            Location = "Altdorf"
        };
        items.Add(punkt11);

        DataItem punkt12 = new DataItem()
        {
            Name = "Lisa",
            LastName = "Schultz",
            Location = "Altdorf"
        };
        items.Add(punkt12);

        DataItem punkt13 = new DataItem()
        {
            Name = "Bobby",
            LastName = "Schuller",
            Location = "Altdorf"
        };
        items.Add(punkt13);

        //Noch nicht normalisiert
        DataItem nonorm = new DataItem()
        {
            Name = "OB",
            LastName = "Nopper",
            Location = "Stuttgart"
        };
        items.Add(nonorm);
    }
    private void IncrementCount()
    {
        currentCount++;
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
