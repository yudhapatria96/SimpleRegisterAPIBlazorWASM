#pragma checksum "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\Pages\RegisterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e80bc246e367d1977a0ef1d597d12828f447e013"
// <auto-generated/>
#pragma warning disable 1591
namespace CallAPIWASM.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\_Imports.razor"
using CallAPIWASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\_Imports.razor"
using CallAPIWASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\Pages\RegisterComponent.razor"
using CallAPIWASM.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class RegisterComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mb-3");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<label for=\"exampleFormControlInput1\" class=\"form-label\">Email</label>\r\n        ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "email");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "name@example.com");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\Pages\RegisterComponent.razor"
                                                                                        registerData.email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerData.email = __value, registerData.email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "mb-3");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<label for=\"exampleFormControlInput1\" class=\"form-label\">Password</label>\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "email");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "placeholder", "*****");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\Pages\RegisterComponent.razor"
                                                                             registerData.password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerData.password = __value, registerData.password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "mb-3");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.AddMarkupContent(27, "<label for=\"exampleFormControlInput1\" class=\"form-label\">Password Confirmation</label>\r\n        ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "email");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "placeholder", "******");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\Pages\RegisterComponent.razor"
                                                                              registerData.password_confirmation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerData.password_confirmation = __value, registerData.password_confirmation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "mb-3");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.AddMarkupContent(39, "<label for=\"exampleFormControlInput1\" class=\"form-label\">Name</label>\r\n        ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "email");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "placeholder", "Name");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\Pages\RegisterComponent.razor"
                                                                             registerData.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerData.name = __value, registerData.name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "mb-3");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<label for=\"exampleFormControlInput1\" class=\"form-label\">City</label>\r\n        ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "email");
            __builder.AddAttribute(54, "class", "form-control");
            __builder.AddAttribute(55, "placeholder", "City");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\Pages\RegisterComponent.razor"
                                                                            registerData.city

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerData.city = __value, registerData.city));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-md-4");
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group");
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "button");
            __builder.AddAttribute(68, "class", "btn btn-primary");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\Pages\RegisterComponent.razor"
                                                                    createAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n");
            __builder.OpenElement(74, "h3");
            __builder.AddContent(75, 
#nullable restore
#line 36 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\Pages\RegisterComponent.razor"
     responseRegister.access_token

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\yudha.patria\source\repos\CallAPIWASM\CallAPIWASM\Client\Pages\RegisterComponent.razor"
       
    RegisterData registerData = new RegisterData();
    RegisterResponse responseRegister = new RegisterResponse();
    protected async Task createAccount()
    {

        using var response  = await Http.PostAsJsonAsync("https://onlineshopapi.herokuapp.com/api/auth/register", registerData);

       responseRegister = await response.Content.ReadFromJsonAsync<RegisterResponse>();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
