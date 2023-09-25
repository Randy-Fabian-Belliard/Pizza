using System.Collections.Generic; 
using System.Linq;

namespace PizzaPlace.Shared
{
  public class MenuBLL
  {
    public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
    public void Agregar(Pizza pizza) => Pizzas.Add(pizza);
    public Pizza? GetPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
  }
}