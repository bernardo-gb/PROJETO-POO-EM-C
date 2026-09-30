using System;
using System.Collections.Generic;
using MeuProjeto.Modelos;

internal partial class Program
{
    private static List<Cliente> clientes = new();

    private static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n=== PETCARE ===");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Cadastrar pet");
            Console.WriteLine("3 - Listar clientes");
            Console.WriteLine("0 - Sair");

            try
            {
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente();
                        break;

                    case 2:
                        CadastrarPet();
                        break;

                    case 3:
                        ListarClientes();
                        break;

                    case 0:
                        Console.WriteLine("Sistema encerrado.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Digite uma opção válida.");
                opcao = -1;
            }

        } while (opcao != 0);
    }

    private static void CadastrarCliente()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        clientes.Add(new Cliente(nome, telefone, cpf));
        Console.WriteLine("Cliente cadastrado!");
    }

    private static void CadastrarPet()
    {
        if (clientes.Count == 0)
        {
            Console.WriteLine("Cadastre um cliente primeiro.");
            return;
        }

        Cliente cliente = clientes[0];

        Console.Write("Nome do pet: ");
        string nome = Console.ReadLine();

        Console.Write("Espécie: ");
        string especie = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        cliente.AdicionarPet(new Pet(nome, especie, idade));
        Console.WriteLine("Pet cadastrado!");
    }

    private static void ListarClientes()
    {
        foreach (Cliente cliente in clientes)
        {
            cliente.Exibir();
            foreach (Pet pet in cliente.Pets)
            {
                pet.Exibir();
            }
        }
    }
}

namespace MeuProjeto.Modelos
{
    public class Pet
    {
        public string Nome { get; }
        public string Especie { get; }
        public int Idade { get; }

        public Pet(string nome, string especie, int idade)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        public void Exibir()
        {
            Console.WriteLine($"  Pet: {Nome} - {Especie} - {Idade} anos");
        }
    }

    public class Cliente
    {
        public string Nome { get; }
        public string Telefone { get; }
        public string Cpf { get; }
        public List<Pet> Pets { get; } = new List<Pet>();

        public Cliente(string nome, string telefone, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
        }

        public void AdicionarPet(Pet pet) => Pets.Add(pet);

        public void Exibir()
        {
            Console.WriteLine($"Cliente: {Nome} | Tel: {Telefone} | CPF: {Cpf}");
        }
    }
}
