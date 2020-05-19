#pragma checksum "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\WorldPopulation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e822637cd0ac6d316a6b2bf3cc9ab3b5a27b543"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorLearn.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using BlazorLearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using BlazorLearn.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using BlazorLearn.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using BlazorLearn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/population")]
    public partial class WorldPopulation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Güncel 3 Günlük Dünya Nüfusu Bilgileri</h2>\r\n\r\n");
            __builder.AddMarkupContent(1, "<blockquote class=\"blockquote\">\r\n    Bilgiler api.population.io sitesinden alınmıştır.\r\n</blockquote>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\WorldPopulation.razor"
 if (values == null) // Henüz veriler gelmemiş olabilir.
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Bilgiler alınıyor...</em></p>\r\n");
#nullable restore
#line 15 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\WorldPopulation.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.AddAttribute(7, "style", "width: 18rem;");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "ul");
            __builder.AddAttribute(10, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 20 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\WorldPopulation.razor"
             foreach (var currentData in @values) // Tüm değerleri dolaşıp güncel nüfus verisini ekrana basıyoruz
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "list-group-item");
            __builder.AddContent(15, 
#nullable restore
#line 22 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\WorldPopulation.razor"
                                             string.Format("{0:#,0}", @currentData.Value)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " - ");
            __builder.AddContent(17, 
#nullable restore
#line 22 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\WorldPopulation.razor"
                                                                                             currentData.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 23 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\WorldPopulation.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 26 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\WorldPopulation.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\WorldPopulation.razor"
       
    Population[] values; // istatistik bilgilerin dizisi

    // Sayfamızın başlangıç aşamasında çalışan asenkron olay metodumuz
    protected override async Task OnInitializedAsync()
    {
        // GetJsonAsync metodunu kullanarak bir talep gönderiyoruz ve sunucu tarafından json dosyasını alıyoruz
        // Burada harici bir servis adresine de çıkılabilir
        // TODO: world.json içeriğini veren bir .net web api dahil edelim
        values = await httpClient.GetFromJsonAsync<Population[]>("db/world.json");
    }

    // Nüfus bilgilerini tutan sınıfımız
    class Population
    {
        public DateTime Date { get; set; }
        public Int64 Value { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
