#pragma checksum "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2607c4f46de9472905d4377d5831f8599557cd06"
// <auto-generated/>
#pragma warning disable 1591
namespace JendamarkBlazorAssignment.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using JendamarkBlazorAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using JendamarkBlazorAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor"
using JendamarkBlazorAssignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class AddOperationComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "simple-form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddMarkupContent(4, "<label for=\"first-name\">Operation Name</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "id", "first-name");
            __builder.AddAttribute(9, "placeholder", "Enter Name");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor"
                      Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label for=\"last-name\">Operation Order In which to perform</label>\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "number");
            __builder.AddAttribute(18, "step", "1");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "pattern", "\\d+");
            __builder.AddAttribute(21, "id", "last-name");
            __builder.AddAttribute(22, "placeholder", "Enter Order");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor"
                      OrderInWhichToPerform

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => OrderInWhichToPerform = __value, OrderInWhichToPerform, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-group");
            __builder.AddMarkupContent(28, "<label for=\"last-name\">Image</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(29);
            __builder.AddAttribute(30, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor"
                              SingleUpload

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor"
                      SubmitForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddContent(35, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor"
                      Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "btn btn-secondary");
            __builder.AddContent(40, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor"
       
    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

    private byte[] _image;

    bool ShowForm { get; set; } = true;
    string Name { get; set; }
    int OrderInWhichToPerform { get; set; }
    byte[] Image { get; set; }
    int FormId { get; set; }

    void SubmitForm()
    {
        var parameters = new ModalParameters();
        parameters.Add("Name", Name);
        parameters.Add("Order", OrderInWhichToPerform.ToString());
        if (Image is not null)
        {
            parameters.Add("Image", Image);
        }



        ModalInstance.CloseAsync(ModalResult.Ok(parameters));

    }

    void Cancel()
    {
        ModalInstance.CancelAsync();
    }

    private async Task SingleUpload(InputFileChangeEventArgs e)
    {
        MemoryStream ms = new MemoryStream();
        await e.File.OpenReadStream().CopyToAsync(ms);
        Image = ms.ToArray();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
