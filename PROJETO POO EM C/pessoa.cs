public abstract class Pessoa
{
    public string Nome { get; set; }
    public string Telefone { get; set; }

    public Pessoa(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }

    public virtual void Exibir()
    {
        Console.WriteLine($"{Nome} - {Telefone}");
    }
}
