namespace Projekt1pmu;

public partial class GravityForcePage : ContentPage
{
    private const double g = 9.81; // Gravitacijsko ubrzanje (m/s^2)

    public GravityForcePage()
    {
        InitializeComponent();
    }

    private void OnCalculateGravityForceClicked(object sender, EventArgs e)
    {
        if (double.TryParse(massEntry.Text, out double mass))
        {
            double force = mass * g;
            gravityResultLabel.Text = $"Sila teže: {force} N";
        }
        else
        {
            gravityResultLabel.Text = "Molimo unesite valjanu masu!";
        }
    }
}
