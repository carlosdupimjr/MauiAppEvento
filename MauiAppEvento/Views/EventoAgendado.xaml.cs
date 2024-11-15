using MauiAppEvento.Models;
namespace MauiAppEvento.Views;

public partial class EventoAgendado : ContentPage
{
	public EventoAgendado()
	{
		InitializeComponent();
	}
    private void btn_voltar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops!", ex.Message, "Ok");
        }
    }
}