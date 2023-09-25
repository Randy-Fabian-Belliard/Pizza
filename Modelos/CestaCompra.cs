using System.Collections.Generic;

namespace PizzaPlace.Shared
{
  public class CompraCesta
  {
    public Cliente Cliente { get; set; } = new Cliente();     
    public List<int> Pedidos { get; set; } = new List<int>();     
    public bool HaPagado { get; set; }
    public void Add(int pizzaId) => Pedidos.Add(pizzaId);
    public void RemoveAt(int pos) => Pedidos.RemoveAt(pos);
  }
}