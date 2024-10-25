using System;

public class Reserva
{
    public PacoteTuristico Pacote { get; set; }
    public Cliente Cliente { get; set; }
    public bool Status { get; set; }
    private string codigo;

    public string Codigo  
  {
    get { return codigo; }   
    set { codigo = value; }  
  }

    public Reserva(PacoteTuristico Pacote, Cliente Cliente, bool Status, string Codigo)
    {
        this.Pacote = Pacote;
        this.Cliente = Cliente;
        this.Status = Status;
        this.Codigo = Codigo;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Essa reserva de cliente: {Cliente.Nome} com destino a {Pacote.Destino.NomeLocal}");
    }
   
}