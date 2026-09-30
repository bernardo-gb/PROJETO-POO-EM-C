using MeuProjeto.Modelos;

public class Cliente : Pessoa
{
    public string CPF { get; set; }
    public List<Pet> Pets { get; set; } = new();

    public Cliente(string nome, string telefone, string cpf)
        : base(nome, telefone)
    {
        CPF = cpf;
    }

    public void AdicionarPet(Pet pet)
    {
        Pets.Add(pet);
    }

    public override void Exibir()
    {
        Console.WriteLine($"Cliente: {Nome} | CPF: {CPF}");
    }
}
