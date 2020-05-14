#pragma checksum "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbd6a383413a6922db25c79451ab575adc6cf06b"
// <auto-generated/>
#pragma warning disable 1591
namespace PlannerApp.Client.Pages.Auth
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
#nullable restore
#line 16 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
using PlannerApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-12");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h2>Login to your account</h2>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                          loginRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                                       LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n                ");
                    __builder3.OpenComponent<PlannerApp.Client.Shared.AlertMessage>(15);
                    __builder3.AddAttribute(16, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                        message

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "MessageType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PlannerApp.Client.Models.AlertMessageType>(
#nullable restore
#line 14 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                                               messageType

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n\r\n                ");
                    __builder3.OpenElement(19, "ul");
                    __builder3.AddMarkupContent(20, "\r\n");
#nullable restore
#line 17 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                     foreach (var item in userInfo)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(21, "                        ");
                    __builder3.OpenElement(22, "li");
                    __builder3.OpenElement(23, "b");
                    __builder3.AddContent(24, 
#nullable restore
#line 19 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                item.Key

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddContent(25, " : ");
                    __builder3.AddContent(26, 
#nullable restore
#line 19 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                                item.Value

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(27, "\r\n");
#nullable restore
#line 20 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(28, "                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\r\n\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(30);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(32, "<label>Email</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(33);
                    __builder3.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                            loginRequest.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.Email = __value, loginRequest.Email))));
                    __builder3.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginRequest.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\r\n                ");
                    __Blazor.PlannerApp.Client.Pages.Auth.Login.TypeInference.CreateValidationMessage_0(__builder3, 38, 39, 
#nullable restore
#line 28 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                          ()=>loginRequest.Email

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(40, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(41, "<label>Password</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(42);
                    __builder3.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                             loginRequest.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.Password = __value, loginRequest.Password))));
                    __builder3.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginRequest.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n                ");
                    __Blazor.PlannerApp.Client.Pages.Auth.Login.TypeInference.CreateValidationMessage_1(__builder3, 47, 48, 
#nullable restore
#line 32 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                          ()=>loginRequest.Password

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(49, "\r\n\r\n                <hr>\r\n\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(50);
                    __builder3.AddAttribute(51, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 36 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                          Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "Text", "Login");
                    __builder3.AddAttribute(53, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 37 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                           Radzen.ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "class", "btn-block mr-2");
                    __builder3.AddAttribute(55, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                        isBusy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(57);
                    __builder3.AddAttribute(58, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 39 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                          Radzen.ButtonType.Button

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "Text", "Register");
                    __builder3.AddAttribute(60, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 40 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                           Radzen.ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "class", "btn-block mr-2");
                    __builder3.AddAttribute(62, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                        isBusy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                                       GoToRegister

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
       
    LoginRequest loginRequest = new LoginRequest();

    bool isBusy = false;
    string message = string.Empty;

    Models.AlertMessageType messageType = Models.AlertMessageType.Success;
    Dictionary<string, string> userInfo = new Dictionary<string, string>();

    public async Task LoginUser()
    {
        isBusy = true;
        var result = await authService.LoginUserAsync(loginRequest);

        if (result.IsSuccess)
        {
            message = "Welcome to PlannerApp";
            userInfo = result.UserInfo;
            messageType = Models.AlertMessageType.Success;
            navigationManager.NavigateTo("/");
        }
        else
        {
            message = result.Errors.FirstOrDefault() ?? result.Message;
            messageType = Models.AlertMessageType.Error;
        }
        isBusy = false;
    }

    void GoToRegister()
    {
        navigationManager.NavigateTo("/auth/register");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService authService { get; set; }
    }
}
namespace __Blazor.PlannerApp.Client.Pages.Auth.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
