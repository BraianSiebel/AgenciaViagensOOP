public abstract class ServicoViagem
{
  public string Codigo { get; set; }
  public string Descricao { get; set; }


  public abstract void Reservar();
  public abstract void Cancelar();

 
}