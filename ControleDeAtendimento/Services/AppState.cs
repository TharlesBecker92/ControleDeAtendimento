public class AppState
{
    
    public bool EstaLogado { get; set; } = false;
    public string NomeUsuario { get; set; } = "";
    public string Nome { get; set; } = "";
    public string SobreNome { get; set; } = "";
    private Dictionary<string, bool> NiveisDeAcesso = new Dictionary<string, bool>();

    public void Login(string nomeusuario)
    {
        EstaLogado = true;
        NomeUsuario = nomeusuario;
    }
    public void Exit()
    {
        EstaLogado = false;
        NomeUsuario = "";
        Nome = "";
        SobreNome = "";
    }
    

}
