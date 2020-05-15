using Microsoft.AspNetCore.Components;

namespace DemoBlazorWASM.Pages
{
    public partial class Counter2
    {
        [Parameter]
        public int CurrentCount { get; set; } = 0;

        private void IncrementCount()
        {
            CurrentCount++;
        }
    }
}
