using Microsoft.JSInterop;

namespace BlazorApp1.ClassLibrary.Services
{
    public class ToastrService
    {
        private IJSRuntime _jsRuntime;

        public ToastrService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }



        public async Task ShowInfoMessage(string message, object options)
        {
            await _jsRuntime.InvokeVoidAsync("toastrWrapper.ShowToastrInfo", message, options);
        }
    }
}


