using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_quatro
{
    internal class Program
    {
        struct DadosDoSalao
        {
            public string NomeDoCliente;
            public string EnderecoDoCliente;
            public UInt32 TelefoneDoContato;
            public DateTime DataDoCliente;

        }
        static void Main(string[] args)
        {
            List<DadosDoSalao> ListaDoSalao = new List<DadosDoSalao>();
            string iniciar;
            do
            {
            Console.WriteLine("Bem vindo a nossa plataforma, pressione 'I' para iniciar e 'S' para sair");
                iniciar = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (iniciar == "i")
                {
                    DadosDoSalao dadosDoSalao;
                    Console.WriteLine("Digite seu nome: ");
                    dadosDoSalao.NomeDoCliente = Console.ReadLine();
                    Console.WriteLine("Digite seu endereço: ");
                    dadosDoSalao.EnderecoDoCliente = Console.ReadLine();
                    Console.WriteLine("Digite seu telefone");
                    dadosDoSalao.TelefoneDoContato = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Digite a data do agendamento: ");
                    dadosDoSalao.DataDoCliente = Convert.ToDateTime(Console.ReadLine());
                    ListaDoSalao.Add(dadosDoSalao);

                    Console.Clear();

                } else if (iniciar == "s")
                {
                    Console.WriteLine("Obrigado e volte sempre");

                } else
                {
                    Console.WriteLine("Tecla desconhecida, por favor pressione uma tecla conhecida pelo nosso sistema");
                }

            } while ( iniciar != "s");

            Console.WriteLine("aperte qualquer coisa para sair");

            Console.ReadKey();
        }
    }
}
