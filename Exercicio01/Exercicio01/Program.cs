using Exercicio01;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login;
            Crud c;

            Console.WriteLine("CADASTRO");
            Console.Write("Cadastre um usuário: ");
            string usuario = Console.ReadLine();

            Console.Write("Cadastre a senha: ");
            string senha = Console.ReadLine();

            Console.Write("Confirme a senha: ");
            string senha2 = Console.ReadLine();

            login = new Login(usuario, senha);

            login.ValidarIgualdade(senha, senha2);

            Console.WriteLine();
            Console.WriteLine("LOGIN");
            Console.Write("Digite o usuário: ");
            string usuarioCadastrado = Console.ReadLine();
            Console.Write("Digite a senha: ");
            string senhaCadastrada = Console.ReadLine();

            login.ValidarLogin(usuario, senha, usuarioCadastrado, senhaCadastrada);

            Console.WriteLine();
            Console.WriteLine(login);

            Console.WriteLine("Selecione uma opção para continuar, " + usuario + "!");
            Console.WriteLine("1 - Cadastrar um produto;");
            Console.WriteLine("2 - Excluir um produto;");
            Console.WriteLine("3 - Atualizar um produto;");
            Console.WriteLine("4 - Sair;");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            c = new Crud();

            c.Menu(opcao);
        }
    }
}