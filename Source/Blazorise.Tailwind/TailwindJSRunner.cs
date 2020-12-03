using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazorise.Tailwind
{
    public partial class TailwindJSRunner : JSRunner
    {
        private const string TAILWIND_NAMESPACE = "tailwind";

        public TailwindJSRunner( IJSRuntime runtime )
            : base( runtime )
        {
        }

        public override ValueTask<bool> InitializeTooltip( ElementReference elementRef, string elementId )
        {
            return runtime.InvokeAsync<bool>( $"{TAILWIND_NAMESPACE}.tooltip.initialize", elementRef, elementId );
        }

        public override ValueTask<bool> OpenModal( ElementReference elementRef, string elementId, bool scrollToTop )
        {
            return runtime.InvokeAsync<bool>( $"{TAILWIND_NAMESPACE}.modal.open", elementRef, elementId, scrollToTop );
        }

        public override ValueTask<bool> CloseModal( ElementReference elementRef, string elementId )
        {
            return runtime.InvokeAsync<bool>( $"{TAILWIND_NAMESPACE}.modal.close", elementRef, elementId );
        }
    }
}
