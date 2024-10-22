using System.Diagnostics;
namespace Maui_Lifecycle_Test
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            Debug.WriteLine("Page2 Constructor");
            InitializeComponent();

            Loaded += LoadedEvent;
            Appearing += AppearingEvent;
            Disappearing += DisappearingEvent;
            Unloaded += UnloadedEvent;
        }

        private void AppearingEvent(object? sender, EventArgs e)
        {
            Debug.WriteLine("Page2 Appearing");
        }

        private void LoadedEvent(object? sender, EventArgs e)
        {
            Debug.WriteLine("Page2 Loaded");
        }

        private void DisappearingEvent(object? sender, EventArgs e)
        {
            Debug.WriteLine("Page2 Disappearing");
        }

        private void UnloadedEvent(object? sender, EventArgs e)
        {
            Debug.WriteLine("Page2 Unloaded");
        }

        private async void Back(object sender, EventArgs e)
            => await Shell.Current.GoToAsync("Page1", false);
    }

}
