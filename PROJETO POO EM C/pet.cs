public class Pet
{
    public string Nome { get; set; }
    public string Especie { get; set; }
    public int Idade { get; set; }

    public Pet(string nome, string especie, int idade)
    {
        Nome = nome;
        Especie = especie;
        Idade = idade;
    }

    public void Exibir()
    {
        Console.WriteLine(
            $"Pet: {Nome} | Espécie: {Especie} | Idade: {Idade}"
        );
    }
}
