using DemoBlazorWASM.wwwroot.consts;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace DemoBlazorWASM.Pages
{
    public partial class Alert
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        private string text;
        private string text2;
        private string returntekst;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
        }

        private async Task DoAlert()
        {
            await JSRuntime.InvokeVoidAsync("doAlert", text);
        }

        private async Task DoPrompt()
        {
            returntekst = await JSRuntime.InvokeAsync<string>("doPrompt");
            //returntekst = Age.Result;
        }
    }
}
