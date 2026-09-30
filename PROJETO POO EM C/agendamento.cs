public class Agendamento
{
    public Pet Pet { get; set; }
    public Servico Servico { get; set; }
    public DateTime Data { get; set; }

    public Agendamento(Pet pet, Servico servico, DateTime data)
    {
        Pet = pet;
        Servico = servico;
        Data = data;
    }

    public void Exibir()
    {
        Console.WriteLine(
            $"{Pet.Nome} - {Servico.Nome} - {Data:dd/MM/yyyy}"
        );
    }
}
