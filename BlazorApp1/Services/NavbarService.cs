namespace BlazorApp1.Services
{
    public class NavbarService
    {
        public bool IsNavbarVisible { get; private set; } = true;

        public event Func<Task> OnChangeAsync;

        public async Task ToggleNavbar()
        {
            IsNavbarVisible = !IsNavbarVisible;
            await NotifyStateChangedAsync();
        }

        private async Task NotifyStateChangedAsync()
        {
            if (OnChangeAsync != null)
            {
                await OnChangeAsync.Invoke();
            }
        }
    }
}
