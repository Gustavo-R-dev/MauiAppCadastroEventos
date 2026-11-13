using MauiAppCadastroEventos.Models;

namespace MauiAppCadastroEventos.Views;

public partial class EventoCadastrado : ContentPage
{
    // O construtor PRECISA aceitar o 'Evento' para combinar com o que mandamos no botão
    public EventoCadastrado(Evento eventoRecebido)
    {
        InitializeComponent();

        // Associa os dados à tela
        BindingContext = eventoRecebido;
    }

    private async void BotaoVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}