// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MafiaApplication.Client.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Git\Projekt1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\Projekt1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Git\Projekt1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Git\Projekt1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Git\Projekt1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Git\Projekt1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Git\Projekt1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Git\Projekt1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Git\Projekt1\Client\_Imports.razor"
using MafiaApplication.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Git\Projekt1\Client\_Imports.razor"
using MafiaApplication.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\Projekt1\Client\Pages\Sales.razor"
using MafiaApplication.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Git\Projekt1\Client\Pages\Sales.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Git\Projekt1\Client\Pages\Sales.razor"
using Sylvan.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Git\Projekt1\Client\Pages\Sales.razor"
using Sylvan.Data.Csv;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Git\Projekt1\Client\Pages\Sales.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Git\Projekt1\Client\Pages\Sales.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Git\Projekt1\Client\Pages\Sales.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Git\Projekt1\Client\Pages\Sales.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Git\Projekt1\Client\Pages\Sales.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sales")]
    public partial class Sales : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Git\Projekt1\Client\Pages\Sales.razor"
                                      

    private int currentCount = 0;
    private string control = "";
    private ObservableCollection<SalesItem> moon = 
        new ObservableCollection<SalesItem>();
 
    protected override async Task OnInitializedAsync()
    {
        currentCount = 1000;
       
        control = "init";
        IEnumerable<SalesItem> records;
        var fileName = @"C:\\Libre.csv";
        using (var reader = new StreamReader(fileName))
        {
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<SalesItem>();
            }
            foreach (var single in records)
            {
            // Do something with values in each row
            Console.WriteLine(single.Region);
            }
        }
    }

        
        /*
        for(int i = 0 ; i < 10 ; i++)
        {
            SalesItem normal = new SalesItem()
            {
                OrderID = 1,
                Country = "count",
                Region = "FOO"
            };
            moon.Add(normal);
        }*/
    
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