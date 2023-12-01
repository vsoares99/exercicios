namespace Exercicio01
{
    internal class Login
    {
        public string Usuario { get; private set; }
        public string Senha { get; private set; }

        public Login(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }

        public void ValidarIgualdade(string senha, string senha2)
        {
            while (senha != senha2)
            {
                Console.WriteLine();
                Console.WriteLine("Senhas diferentes, digite novamente.");
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();

                Console.Write("Confirme a senha: ");
                senha2 = Console.ReadLine();
            }
        }

        public void ValidarLogin(string usuario, string senha, string usuarioCadastrado, string senhaCadastrada)
        {
            while (usuarioCadastrado != usuario || senhaCadastrada != senha)
            {
                Console.WriteLine();
                Console.WriteLine("Usuário ou senha incorretos.");
                Console.Write("Digite o usuário: ");
                usuarioCadastrado = Console.ReadLine();
                Console.Write("Digite a senha: ");
                senhaCadastrada = Console.ReadLine();
            }
        }

        public override string ToString()
        {
            return "Bem vindo(a), "
                + Usuario
                + "!";
        }
    }
}
