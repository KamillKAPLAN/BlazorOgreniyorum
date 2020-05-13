#pragma checksum "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10cb741756398bc408801f1009b5e6fb98fc52d8"
// <auto-generated/>
#pragma warning disable 1591
namespace PlannerApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Radzen Blazor Chart pie series</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6 col-sm-12 p-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __Blazor.PlannerApp.Client.Pages.Index.TypeInference.CreateRadzenPieSeries_0(__builder2, 10, 11, 
#nullable restore
#line 7 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Index.razor"
                                    revenue

#line default
#line hidden
#nullable disable
                , 12, "Revenue", 13, "Quarter", 14, "Revenue");
                __builder2.AddMarkupContent(15, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n\r\n");
            __builder.OpenComponent<PlannerApp.Client.Shared.SurveyPrompt>(19);
            __builder.AddAttribute(20, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Index.razor"
       
    class DataItem
    {
        public string Quarter { get; set; }
        public double Revenue { get; set; }
    }

    DataItem[] revenue = new DataItem[] {
        new DataItem
        {
            Quarter = "Q1",
            Revenue = 30000
        },
        new DataItem
        {
            Quarter = "Q2",
            Revenue = 40000
        },
        new DataItem
        {
            Quarter = "Q3",
            Revenue = 50000
        },
        new DataItem
        {
            Quarter = "Q4",
            Revenue = 80000
        },
    };

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.PlannerApp.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenPieSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenPieSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Title", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
