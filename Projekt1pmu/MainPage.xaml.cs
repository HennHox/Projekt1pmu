namespace Projekt1pmu
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGravityForceButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GravityForcePage());
        }
        private async void OnGravitationalLawButtonClicked(object sender, EventArgs e)
        {
            // Navigacija na stranicu Zakon gravitacije
            await Navigation.PushAsync(new GravitationalLawPage());
        }
    }

}
