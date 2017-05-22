using Xamarin.Forms;

namespace SocialLoginLab
{
    public partial class MainPage : ContentPage
    {
        readonly AzureService azureService = new AzureService();

        public MainPage()
        {
            InitializeComponent();

            LoginButton.Clicked += async (sender, args) =>
            {
                var user = await azureService.LoginAsync();
                InfoLabel.Text = (user != null) ? $"Bem vindo: {user.UserId}" : "Falha no Login, tente novamente!";
            };
        }
    }
}
