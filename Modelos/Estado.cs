namespace PizzaPlace.Shared
{
  public class Estado
  {
    public MenuBLL Menu { get; } = new MenuBLL();     
    public CompraCesta Cesta { get; } = new CompraCesta();
    public Interfaz Interfaz { get; set; } = new Interfaz();
    public decimal PrecioTotal => Cesta.Pedidos.Sum(id => Menu.GetPizza(id)!.Precio);
  }
}