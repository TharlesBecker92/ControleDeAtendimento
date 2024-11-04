using Microsoft.AspNetCore.Components;

namespace ControleDeAtendimento.Components.Pages.LoginPage{
    public partial class LoginPage : ComponentBase
    {
        private LoginModel loginModel = new LoginModel();

        private async Task HandleLogin()
        {
            AppState.Login(loginModel.Username);
            NavigationManager.NavigateTo("/");
        }
        private async Task HandleExit()
        {
            AppState.Exit();
            NavigationManager.NavigateTo("/");
        }

        public class LoginModel
        {
            public string Username { get; set; } = string.Empty;            
            public string Password { get; set; } = string.Empty;
        }
    }
}
