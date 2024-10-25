using System;
using System.Runtime.CompilerServices;

public class Agencia
{
    public List<Destino> Destinos;
    public List<Cliente> Clientes;
    public List<PacoteTuristico> Pacotes;
    public List<Reserva> Reservas;

    public Agencia()
    {
        this.Destinos = new List<Destino>();
        this.Clientes = new List<Cliente>();
        this.Pacotes = new List<PacoteTuristico>();
        this.Reservas = new List<Reserva>();
    }

    ///////////////////////////////////////////////////////
    // Implementar os Métodos de Gerenciamento de Destinos:
    ///////////////////////////////////////////////////////
    public void CadastrarDestino(Destino destino)
    {
        if (destino != null)
        {
            Destinos.Add(destino);
            Console.WriteLine("Destino cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Destino não cadastrado!");
        }
    }

    public Destino ConsultarDestinoPorCodigo(String codigo)
    {
        foreach (Destino i in Destinos)
        {
            if (i.Codigo == codigo) { return i; }

        }
        Console.WriteLine("Destino não encontrado!");
        return null;
    }


    public Destino ConsultarDestinoPorPais(String Pais)
    {
        foreach (Destino i in Destinos)
        {
            if (i.Pais == Pais) { return i; }

        } 
        Console.WriteLine("País não encontrado!");
        return null;
    }

    public Destino ConsultarDestinoPorNome(String NomeLocal)
    {
        foreach (Destino i in Destinos)
        {
            if (i.NomeLocal == NomeLocal) { return i; }

        } 
        Console.WriteLine("País não encontrado!");
        return null;
    }

    public void ListarDestinos()
    {
        foreach (Destino i in Destinos)
        {
            i.ExibirInformacoes();
        }
    }

    ///////////////////////////////////////////////////////
    // Implementar os Métodos de Gerenciamento de Clientes:
    ///////////////////////////////////////////////////////
    public void CadastrarCliente(Cliente cliente)
    {
        if (cliente != null)
        {
            Clientes.Add(cliente);
            Console.WriteLine("Cliente cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Cliente não cadastrado!");
        }
    }

    public Cliente ConsultarClientePorID(String id)
    {
        foreach (Cliente i in Clientes)
        {
            if (i.NumeroIdentificacao == id) { return i; }
        }
        Console.WriteLine("cliente nao encontrado");
        return null;
    }


    public void ListarClientes()
    {
        foreach (Cliente i in Clientes)
        {
            i.ExibirInformacoes();
        }
    }

    //////////////////////////////////////////////////////
    // Implementar os Métodos de Gerenciamento de Pacotes:
    //////////////////////////////////////////////////////
    public void CadastrarPacote(PacoteTuristico pacote)
    {
        if (pacote != null)
        {
            Pacotes.Add(pacote);
            Console.WriteLine("Pacote cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Pacote não cadastrado!");
        }
    }
    

    public PacoteTuristico ConsultarPacotePorCodigo(string codigo)
    {
        foreach (PacoteTuristico i in Pacotes)
        {
            if (i.Codigo == codigo) { return i; }
        }
        Console.WriteLine("Pacote não encontrado!");
        return null;
    }

    public PacoteTuristico ConsultarPacotePorDestino(Destino destino)
    {
        foreach (PacoteTuristico i in Pacotes)
        {
            if (i.Destino == destino) { return i; }
        }
        Console.WriteLine("destino não encontrado!");
        return null;
    }

    public void ListarPacotes()
    {
        foreach (PacoteTuristico i in Pacotes)
        {
            i.ExibirInformacoes();
        }
    }

    //////////////////////////////////////////////////////
    //Implementar os Métodos de Gerenciamento de Reservas:
    //////////////////////////////////////////////////////
    public void ReservarPacote(string codigoPacote, Cliente cliente, string codigoReserva)
    {

        bool pacoteExiste = PacoteExiste(codigoPacote);
        bool clienteExiste = ClienteExiste(cliente.NumeroIdentificacao);

        if (pacoteExiste == true && clienteExiste == true)
        {
            PacoteTuristico pacote = ConsultarPacotePorCodigo(codigoPacote);
            pacote.Reservar();
            Reserva reserva = new Reserva(Pacote: pacote, Cliente: cliente, Status: true, Codigo: codigoReserva);
            Reservas.Add(reserva);
        }

    }
    public void CancelarReserva(string Codigo)
    {

        Reserva reserva = ConsultarReservaPorCodigo(Codigo);

        if(reserva != null)
        {
            reserva.Pacote.Cancelar();
            reserva.Status = false;
            Reservas.Remove(reserva);
        }
        else
        {
            Console.WriteLine("Reserva não encontrada");

        }
    }
    public void ListarReservas()
    {
        foreach (Reserva i in Reservas)
        {
            i.ExibirInformacoes();
        }
    }
    // Método utilizado para verificar se o pacote existe, retorna verdadeiro se sim e falso se não
    public bool PacoteExiste(string codigo)
    {
        PacoteTuristico x = ConsultarPacotePorCodigo(codigo);
        if (x != null && x.VagasDisponiveis > 0)
        {
            Console.WriteLine("Existem vagas disponiveis");
            return true;
        }
        else
        {
            return false;
        }
    }

    // Método utilizado para verificar se o cliente existe, retorna verdadeiro se sim e falso se não
    public bool ClienteExiste(string id)
    {
        Cliente x = ConsultarClientePorID(id);
        if (x != null)
        {
            Console.WriteLine("O cliente esta cadastrado");
            return true;
        }
        else
        {
            Console.WriteLine("Cliente nao esta cadastrado");
            return false;
        }
    }
    // Metodo p verificar o codigo das reservas que estao na lista
    public Reserva ConsultarReservaPorCodigo(string Codigo)
    {
        foreach (Reserva i in Reservas)
        {
            if (i.Codigo == Codigo) {return i;}
        }
        Console.WriteLine("destino não encontrado!");
        return null;
    } 
  

  



}