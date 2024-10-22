using System.Diagnostics;
namespace Maui_Lifecycle_Test
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            Debug.WriteLine("Page1 Constructor");
            InitializeComponent();

            Loaded += LoadedEvent;
            Appearing += AppearingEvent;
            Disappearing += DisappearingEvent;
            Unloaded += UnloadedEvent;
        }

        private void AppearingEvent(object? sender, EventArgs e)
        {
            Debug.WriteLine("Page1 Appearing");
        }

        private void LoadedEvent(object? sender, EventArgs e)
        {
            Debug.WriteLine("Page1 Loaded");
        }

        private void DisappearingEvent(object? sender, EventArgs e)
        {
            Debug.WriteLine("Page1 Disappearing");
        }

        private void UnloadedEvent(object? sender, EventArgs e)
        {
            Debug.WriteLine("Page1 Unloaded");
        }

        private async void Navigate(object sender, EventArgs e)
            => await Shell.Current.GoToAsync("Page2", false);
    }

}
