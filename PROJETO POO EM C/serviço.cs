public class Servico
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Servico(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void Exibir()
    {
        Console.WriteLine($"Serviço: {Nome} | R$ {Preco:F2}");
    }
}
