using BlazorApp1.ClassLibrary.Enumerations;
using BlazorApp1.ClassLibrary.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.ClassLibrary.Pages
{
    public partial class ToastrWrapper
    {
        [Inject]
        public ToastrService ToastrService { get; set; }

        
        private async Task ShowToastrInfo()
        {
            var message = "send from c#.";
            var options = new ToastrOptions
            {
                CloseButton = true,
                HideDuration = 300,
                HideMethod = ToastrHideMethod.SlideUp,
                ShowMethod = ToastrShowMethod.SlideDown,
                PositionClass = ToastrPositionMethod.BottomRight
            };
            Console.WriteLine($" option object: {options} ");
            await ToastrService.ShowInfoMessage(message, options);
        }
    }
}
