namespace LHPet.Models; //Uma espécie de domínio para que possa ser chamado de qualquer lugar.

public class Cliente
{
    public int Id {get; set;}
    public string? Nome { get; set; } //Propriedade não anulável, só colocar uma interrogação no inicio
    //Ao digitar prop e apertar enter, preenche automatico.
    public string? Cpf { get; set; }

    public string? Email {get; set;}

    public string? Paciente { get; set; }
    
    //Ao escrever ctor e apertar enter, cria-se o construtor

    public Cliente(int id, string nome, string cpf, string email, string paciente)
    {
        this.Id = id;
        this.Cpf = cpf;
        this.Nome = nome;
        this.Email = email;
        this.Paciente = paciente;
    }
}