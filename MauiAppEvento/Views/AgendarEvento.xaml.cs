using MauiAppEvento.Models;
namespace MauiAppEvento.Views;

public partial class AgendarEvento : ContentPage
{
	public AgendarEvento()
    {
        InitializeComponent();

        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_termino.MinimumDate = dtpck_inicio.Date;
        dtpck_termino.MaximumDate = dtpck_inicio.MaximumDate.AddDays(15);
    }

    private async void btn_avancar_Clicked_1(object sender, EventArgs e)
    {

        try
        {
            Evento E = new Evento
            {
                NomeDoEvento = nome_evento.Text,
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
                QntParticipantes = Convert.ToInt32(qnt_Participantes.Text),
                LocalEvento = local_evento.Text,
                ValorParticipante = Convert.ToInt32(valor_participante.Text),
            };

            await Navigation.PushAsync(new Views.EventoAgendado()
            {
                BindingContext = E
            });
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops!", ex.Message, "Ok");
        }

    }
}