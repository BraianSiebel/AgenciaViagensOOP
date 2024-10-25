using System;

public class Cliente
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Contato { get; set; }

    public Cliente(string Nome, string NumeroIdentificacao, string Contato)
    {
        this.Nome = Nome;
        this.NumeroIdentificacao = NumeroIdentificacao;
        this.Contato = Contato;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, NumeroIdentificacao: {NumeroIdentificacao}, Contato: {Contato}");
    }


    public void Update(string Nome, string NumeroIdentificacao, string Contato)
    {
        this.Nome = Nome;
        this.NumeroIdentificacao = NumeroIdentificacao;
        this.Contato = Contato;
    }

}