// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HttpsClientDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using HttpsClientDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using HttpsClientDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\_Imports.razor"
using HttpsClientDemo.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/weather")]
    public partial class WeatherData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
       
    WeatherForecastModel forecast;
    string errorString;

    protected override async Task OnInitializedAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get,
            "https://www.metaweather.com/api/location/2471217/");
        var client = _clientFactroy.CreateClient();

        HttpResponseMessage response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            forecast = await response.Content.ReadFromJsonAsync<WeatherForecastModel>();
            errorString = null;
        }
         else
          {
            errorString = $"There was an error getting our forecast : { response.ReasonPhrase }";
         }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactroy { get; set; }
    }
}
#pragma warning restore 1591
