using System;
using System.Collections.Generic;

namespace SeuNamespace // substitua por namespace usado no projeto
{
    internal class Cliente
    {
        public string Nome { get; set; }
        // adicione propriedades/métodos conforme necessário
    }

    internal partial class Program
    {
        private static List<Cliente> listaClientes;

        private static void Main(string[] args)
        {
            // inicialização mínima
            listaClientes = new List<Cliente>();
            Main();
        }

        private static void Main()
        {
            // implementação do fluxo principal
        }

        private static void CadastrarCliente()
        {
            // ...
        }

        private static void CadastrarPet()
        {
            // ...
        }

        private static void ListarClientes()
        {
            // ...
        }
    }
}