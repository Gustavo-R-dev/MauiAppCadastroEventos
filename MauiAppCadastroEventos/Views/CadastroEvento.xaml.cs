using MauiAppCadastroEventos.Models;

namespace MauiAppCadastroEventos.Views;

public partial class CadastroEvento : ContentPage
{
    App PropriedadesApp;

    public CadastroEvento()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        //pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_inicio.MinimumDate = DateTime.Now;

        dtpck_termino.MinimumDate = DateTime.Now;
    }

    private async void BotaoAvancar_Clicked(object sender, EventArgs e)
    {
        try
        {
            int participantes = (int)stp_participantes.Value;

            // Validações simples para garantir que os campos numéricos estão corretos
            if (!decimal.TryParse(txt_custoParticipante.Text, out decimal custo))
            {
                await DisplayAlert("Atenção", "Digite um custo válido.", "OK");
                return;
            }

            // Criamos o objeto Evento com os dados preenchidos na tela
            Evento meuEvento = new Evento
            {
                Nome = txt_nomeEvento.Text,
                Local = txt_localEvento.Text,
                DataInicio = dtpck_inicio.Date.Value,
                DataTermino = dtpck_termino.Date.Value,
                NumeroParticipantes = (int)stp_participantes.Value,
                CustoPorParticipante = custo
            };

            // Navega para a página de resumo, enviando o objeto 'meuEvento'
            await Navigation.PushAsync(new EventoCadastrado(meuEvento));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}