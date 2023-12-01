using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Crud
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }

        public Crud(int id, string nome, int quantidade, double preco)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public Crud() { }

        public void CadastrarProduto()
        {

        }

        public void Menu(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Insira os dados para cadastro do produto:");
                    Console.Write("Codígo: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.Write("Produto: ");
                    break;
            }
        }

        public override string ToString()
        {
            return "Código "
                + Id
                + ", Produto";
        }
    }
}
