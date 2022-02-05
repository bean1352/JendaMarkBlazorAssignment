// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class AddOperationComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Components\AddOperationComponent.razor"
       
    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

    private byte[] _image;

    bool ShowForm { get; set; } = true;
    [Required]
    string Name { get; set; }
    [Required]
    int OrderInWhichToPerform { get; set; }
    [Required]
    byte[] Image { get; set; }
    int FormId { get; set; }

    void SubmitForm()
    {
        var parameters = new ModalParameters();
        parameters.Add("Name", Name);
        parameters.Add("Order", OrderInWhichToPerform);
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
