using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Cadastro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent(); 
            MainPage = new NavigationPage(new MeuPesqueiro.Views.CadastroPage());
        }
    }
}
