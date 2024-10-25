using System;

public class PacoteTuristico : ServicoViagem, IReservavel, IPesquisavel
{
    public Destino Destino;
    public DateTime Datas;
    public decimal Preco { get; set; }
    public int VagasDisponiveis { get; set; }



    public PacoteTuristico(Destino Destino, DateTime Datas, decimal Preco, int VagasDisponiveis)
    {
        this.Destino = Destino;
        this.Datas = Datas;
        this.Preco = Preco;
        this.VagasDisponiveis = VagasDisponiveis;
    }

    public override void Reservar()
    { //aqui nao tem como ficar negativo pq vagas disponiveis so [e diminuida se for maior q 0]
        if (VagasDisponiveis > 0)
        {
            Console.WriteLine("Reserva associada ao cliente");
            VagasDisponiveis -= 1;
        }
        else
        {
            Console.WriteLine("Nao ha vagas disponiveis");
        }
    }

    // IMPLEMENTAR ESTE CARA
    public override void Cancelar()
    {
        VagasDisponiveis += 1;
        Console.WriteLine("Reserva cancelada com sucesso.");
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Destino: {Destino.NomeLocal}, Datas: {Datas} ");
    }



    public void Update(Destino Destino, DateTime Datas, decimal Preco, int VagasDisponiveis)
    {
        this.Destino = Destino;
        this.Datas = Datas;
        this.Preco = Preco;
        this.VagasDisponiveis = VagasDisponiveis;
    }

     public void PesquisarPorCodigo(string codigo)
    {
        if (this.Codigo == codigo)
        {
            System.Console.WriteLine("Pacote encontrado");
        }
        else
        {
            System.Console.WriteLine("Pacote nn encontrado");
        }
    }
    public void PesquisarPorNome(string nome)
    {
        if (this.Destino.NomeLocal == nome)
        {
            System.Console.WriteLine("Pacote encontrado");
        }
        else
        {
            System.Console.WriteLine("Pacote nn encontrado");
        }
    }
   


}

