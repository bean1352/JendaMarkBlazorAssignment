// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace JendamarkBlazorAssignment.Pages
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
#line 2 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Pages\Index.razor"
using JendamarkBlazorAssignment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Pages\Index.razor"
using JendamarkBlazorAssignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Pages\Index.razor"
using JendamarkBlazorAssignment.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Pages\Index.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Dean\source\repos\JendamarkBlazorAssignment\JendamarkBlazorAssignment\Pages\Index.razor"
       
    private List<Operation> operations;

    [CascadingParameter] public IModalService Modal { get; set; }

    protected override async Task OnInitializedAsync()
    {
        operations = await Service.GetOperationAsync();
    }

    void Remove(Guid operationId)
    {
        operations = operations.Where(x => x.OperationID != operationId).ToList();
    }

    async Task Edit(Operation model)
    {
        var options = new ModalOptions()
        {
            Animation = ModalAnimation.FadeInOut(1),
            HideCloseButton = true,
            Class = "blazored-modal-movies"
        };

        State.GlobalOperation = model;

        var formModel = Modal.Show<EditOperationComponent>("Edit Operation");
        var result = await formModel.Result;

        operations = operations.Where(x => x.OperationID != model.OperationID).ToList();
        if (result.Cancelled)
        {
            Console.WriteLine("Modal was cancelled");
        }
        else
        {
            ModalParameters resultModel = result.Data as ModalParameters;
            var editmodel = resultModel.TryGet<Operation>("Operation");
            editmodel.ImageDataUrl = string.Format("data:image/jpeg;base64,{0}", Convert.ToBase64String(model.ImageData));

            operations.Add(editmodel);

            operations = operations.OrderBy(x => x.OrderInWhichToPerform).ToList();
        }
    }

    async Task AddNewOperation()
    {
        var options = new ModalOptions()
        {
            Animation = ModalAnimation.FadeInOut(1),
            HideCloseButton = true,
            Class = "blazored-modal-movies"
        };

        var formModel = Modal.Show<AddOperationComponent>("Add Operation");
        var result = await formModel.Result;

        if (result.Cancelled)
        {
            Console.WriteLine("Modal was cancelled");
        }
        else
        {
            ModalParameters resultModel = result.Data as ModalParameters;

            var model = resultModel.TryGet<Operation>("Operation");

            if (model.ImageData is null)
            {
                model.ImageData = new byte[0];
            }


            CreateNewOperation(model);

        }

        void CreateNewOperation(Operation model)
        {
            List<Operation> list = new List<Operation>();

            foreach (var item in operations)
            {
                list.Add(item);
            }

            list.Add(new Operation
            {
                Name = model.Name,
                OrderInWhichToPerform = model.OrderInWhichToPerform,
                ImageDataUrl = string.Format("data:image/jpeg;base64,{0}", Convert.ToBase64String(model.ImageData)),
                OperationID = Guid.NewGuid(),
                Device = new Device() { Name = model.Device.Name, DeviceID = Guid.NewGuid(), DeviceType = model.Device.DeviceType },
            });

            list = operations = list.OrderBy(x => x.OrderInWhichToPerform).ToList();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State State { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OperationService Service { get; set; }
    }
}
#pragma warning restore 1591
