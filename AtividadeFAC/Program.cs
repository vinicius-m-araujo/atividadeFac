using AtividadeFAC.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        var cliente = new Cliente("710.002.003-01", "viniciu", "goiania", 629910022, "viniciusemail@gmail.com");
        var carro = new Veiculo("7A32IO", "spider", 2005, "ferrari", "black" );
        
        cliente.exibirInformacoes();
        carro.exibirInformacoes();
    }
}