using System;

class Program
{
    public static void Main(string[] args)
    { 
        Agencia agencia1 = new Agencia();

        // Utilize CadastrarDestino para adicionar novos destinos à agência.
        Destino destino1 = new Destino(NomeLocal: "Rio de Janeiro", Pais: "Brasil", Codigo: "40028922", Descricao: "Tiroteio");
        Destino destino2 = new Destino(NomeLocal: "Terradiarreia", Pais: "tentaram", Codigo: "84074070", Descricao: "bacaxo");
        agencia1.CadastrarDestino(destino1);
        destino1.ExibirInformacoes();
        destino1.Update("RJ", "Br", "420420", "Campo minado");
        destino1.ExibirInformacoes();

        // Utilize CadastrarPacote para adicionar novos pacotes, associando-os a destinos existentes.
        var data1 = new DateTime(2020, 07, 02);
        PacoteTuristico pacoteTuristico1 = new PacoteTuristico(Destino: destino1, Datas: data1, Preco: 11.23154354m, VagasDisponiveis: 5);
        var data2 = new DateTime(2034, 02, 03);
        PacoteTuristico pacoteTuristico2 = new PacoteTuristico(Destino: destino2, Datas: data2, Preco: 22.3456m, VagasDisponiveis: 3);

        agencia1.CadastrarPacote(pacoteTuristico1);
        pacoteTuristico1.ExibirInformacoes();
        pacoteTuristico1.Update(destino1, data1, 92.4312m, 7);
        agencia1.CadastrarPacote(pacoteTuristico2);
        var resultadoConsulta = agencia1.ConsultarPacotePorDestino(destino1);
        resultadoConsulta.ExibirInformacoes();

        
        // Utilize CadastrarCliente para registrar novos clientes interessados em viagens.
        Cliente cliente1 = new Cliente(Nome: "Joca", NumeroIdentificacao: "123", Contato: "123");
        Cliente cliente2 = new Cliente(Nome: "Tiburcio", NumeroIdentificacao: "32223", Contato: "321");
        cliente1.ExibirInformacoes();
        cliente1.Update("Joca Sr", "987654321", "torneira@hotmail.com");
        agencia1.CadastrarCliente(cliente1);
        agencia1.CadastrarCliente(cliente2);
        agencia1.ReservarPacote(pacoteTuristico1.Codigo, cliente1, "3254");
        agencia1.ReservarPacote(pacoteTuristico2.Codigo, cliente1,"53");
        agencia1.ReservarPacote(pacoteTuristico1.Codigo, cliente2,"4536");
        agencia1.ListarReservas();
        agencia1.CancelarReserva("4536");
        agencia1.ListarReservas();
        agencia1.ListarClientes();
        agencia1.ListarPacotes();
        agencia1.ListarDestinos();
 
        

    }
}

