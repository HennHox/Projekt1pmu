namespace Projekt1pmu;

public partial class GravitationalLawPage : ContentPage
{
    private const double G = 6.67430e-11; // Gravitacijska konstanta (m³/kg/s²)

    public GravitationalLawPage()
    {
        InitializeComponent();
    }

    private void OnCalculateGravitationalForceClicked(object sender, EventArgs e)
    {
        if (double.TryParse(mass1Entry.Text, out double mass1) &&
            double.TryParse(mass2Entry.Text, out double mass2) &&
            double.TryParse(distanceEntry.Text, out double distance))
        {
            if (distance > 0)
            {
                double force = G * (mass1 * mass2) / (distance * distance);
                gravitationalResultLabel.Text = $"Gravitacijska sila: {force} N";
            }
            else
            {
                gravitationalResultLabel.Text = "Udaljenost mora biti veca od 0!";
            }
        }
        else
        {
            gravitationalResultLabel.Text = "Molimo unesite valjane vrijednosti!";
        }
    }
}