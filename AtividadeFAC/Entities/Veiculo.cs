namespace AtividadeFAC.Entities;

public class Veiculo
{
    private string Placa { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Fabricante { get; set; }
    public string Color { get; set; }

    public Veiculo(string placa, string modelo, int ano, string fabricante, string color)
    {
        Placa = placa;
        Modelo = modelo;
        Ano = ano;
        Fabricante = fabricante;
        Color = color;
    }

    public void exibirInformacoes()
    {
        Console.WriteLine($"Placa: {Placa}, Modelo: {Modelo}, Fabricante: {Fabricante}, Color: {Color}");
    }
}