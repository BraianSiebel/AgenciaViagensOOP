using System;

public class Destino : IPesquisavel
{

    public string NomeLocal { get; set; }
    public string Pais { get; set; }
    public string Codigo { get; set; }
    public string Descricao { get; set; }

    public Destino(string NomeLocal, string Pais, string Codigo, string Descricao)
    {
        this.NomeLocal = NomeLocal;
        this.Pais = Pais;
        this.Codigo = Codigo;
        this.Descricao = Descricao;
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {NomeLocal}, Pais: {Pais}, Codigo: {Codigo}, Descricao: {Descricao}");
    }
    /*
        public string getCodigo()
        {
            return this.Codigo;
        }

        public void setCodigo(string Codigo)
        {
            this.Codigo = Codigo;
        }*/

    public void Update(string NomeLocal, string Pais, string Codigo, string Descricao)
    {
        this.NomeLocal = NomeLocal;
        this.Pais = Pais;
        this.Codigo = Codigo;
        this.Descricao = Descricao;
    }
    public void PesquisarPorCodigo(string codigo)
    {
        if (this.Codigo == codigo)
        {
            System.Console.WriteLine("Destino encontrado");
        }
        else
        {
            System.Console.WriteLine("destino nn encontrado");
        }
    }
    public void PesquisarPorNome(string nome)
    {
        if (this.NomeLocal == nome)
        {
            System.Console.WriteLine("destino encontrado");
        }
        else
        {
            System.Console.WriteLine("destino nn encontrado");
        }
    }

}