#pragma checksum "D:\akash\study\asp.net core\BlazorApplication\Pages\EditRazor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e822f5e85c4f9bfe1fd54ff1ba13f70373adb64"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\akash\study\asp.net core\BlazorApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\akash\study\asp.net core\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\akash\study\asp.net core\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\akash\study\asp.net core\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\akash\study\asp.net core\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\akash\study\asp.net core\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\akash\study\asp.net core\BlazorApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\akash\study\asp.net core\BlazorApplication\_Imports.razor"
using BlazorApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\akash\study\asp.net core\BlazorApplication\_Imports.razor"
using BlazorApplication.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/patients/{id}")]
    public partial class EditRazor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EditRazor</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\akash\study\asp.net core\BlazorApplication\Pages\EditRazor.razor"
                 patient

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\akash\study\asp.net core\BlazorApplication\Pages\EditRazor.razor"
                                     SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<lable>Id</lable>\r\n        ");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "id", "id");
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "name", "id");
                __builder2.AddAttribute(14, "value", 
#nullable restore
#line 9 "D:\akash\study\asp.net core\BlazorApplication\Pages\EditRazor.razor"
                                                              patient.id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(15, "readonly", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.AddMarkupContent(21, "<lable>Name</lable>\r\n        ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "id", "id");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "name", "name");
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\akash\study\asp.net core\BlazorApplication\Pages\EditRazor.razor"
                                                                      patient.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.name = __value, patient.name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.AddMarkupContent(33, "<lable>Address</lable>\r\n        ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "id", "id");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "name", "address");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\akash\study\asp.net core\BlazorApplication\Pages\EditRazor.razor"
                                                                         patient.address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.address = __value, patient.address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.AddMarkupContent(45, "<lable>City</lable>\r\n        ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "id", "id");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "name", "city");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\akash\study\asp.net core\BlazorApplication\Pages\EditRazor.razor"
                                                                      patient.city

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.city = __value, patient.city));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.AddMarkupContent(57, "<lable>Age</lable>\r\n        ");
                __builder2.OpenElement(58, "input");
                __builder2.AddAttribute(59, "id", "id");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "name", "age");
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\akash\study\asp.net core\BlazorApplication\Pages\EditRazor.razor"
                                                                     patient.age

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.age = __value, patient.age));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.AddMarkupContent(69, "<lable>Gender</lable>\r\n        ");
                __builder2.OpenElement(70, "input");
                __builder2.AddAttribute(71, "id", "id");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "name", "gender");
                __builder2.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\akash\study\asp.net core\BlazorApplication\Pages\EditRazor.razor"
                                                                        patient.gender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.gender = __value, patient.gender));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.AddMarkupContent(78, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\akash\study\asp.net core\BlazorApplication\Pages\EditRazor.razor"
       
    [Parameter]
    public string id { get; set; }

    private BlazorApplication.Models.Patient patient { get; set; }

    

    protected override void OnInitialized()
    {
        if (!string.IsNullOrEmpty(id) && id == "0")
        {

            patient = new Models.Patient();

        }
        else
        {
            patient = DataAccessProvider.GetPatientSingleRecord(Convert.ToInt32(id));
        }
    }

    public async Task SubmitForm()
    {
        if (patient.id == 0)
        {
          
            DataAccessProvider.AddPatientRecord(patient);
            navigation.NavigateTo("patients");
        }
        else
        {
         
            DataAccessProvider.UpdatePatientRecord(patient);
            navigation.NavigateTo("patients");
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorApplication.Data.IDataAccessProvider DataAccessProvider { get; set; }
    }
}
#pragma warning restore 1591
