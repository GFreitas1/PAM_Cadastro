using Microsoft.Maui.Controls;

namespace MeuPesqueiro.Views
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
        }

        private async void OnCadastroClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string email = EmailEntry.Text;
            string senha = SenhaEntry.Text;

            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha))
            {
                await DisplayAlert("Erro", "Preencha todos os campos!", "OK");
                return;
            }

            
            await DisplayAlert("Sucesso", $"Usuário {nome} cadastrado!", "OK");
            await Navigation.PopAsync();
        }
    }
}
