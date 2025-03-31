namespace AtividadeFAC.Entities;

public class Cliente
{
    public string CPF { get; set; }
    public string Name { get; set; }
    public string Adress { get; set; }
    public int Phone { get; set; }
    public string email { get; set; }

    public Cliente(string cpf, string name, string adress, int phone, string email)
    {
        CPF = cpf;
        Name = name;
        Adress = adress;
        Phone = phone;
        this.email = email;
    }

    public void exibirInformacoes()
    {
        Console.WriteLine($"CPF: {CPF}, Name: {Name}, Adress: {Adress}, Phone: {Phone}, Email: {email}");
    }
}