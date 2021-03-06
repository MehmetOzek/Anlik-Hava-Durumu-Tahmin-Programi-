#pragma checksum "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1adc0776c8ec515b77f5b39311f91b25f4c1d43"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Hava Durumu Verileri</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "h2");
            __builder.AddContent(4, 
#nullable restore
#line 10 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
                     errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 11 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
}
else if (forecast is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<div class=\"h4\">Y??kleniyor...</div>\r\n");
#nullable restore
#line 15 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-striped");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>Gun</th>\r\n                <th>Hava Durumu</th>\r\n                <th>D??????k</th>\r\n                <th>Y??ksek</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 28 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
             foreach(var w in forecast.Consolidated_weather)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "            ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 31 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
                     w.applicable_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 32 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
                     w.weather_state_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 33 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
                     w.min_temp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 34 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
                     w.max_temp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 36 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
            }  

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 39 "C:\Users\Mehmet\source\repos\HttpsClientDemo\HttpsClientDemo\Pages\WeatherData.razor"
}

#line default
#line hidden
#nullable disable
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
