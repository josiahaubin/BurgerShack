using System.Collections.Generic;
using BurgerShack.Models;

namespace BurgerShack.Services
{
  public class MenuItemService
  {
    public List<MenuItem> Items { get; private set; }
    public List<string> Messages { get; set; }


    public void Setup()
    {
      Drinks soda = new Drinks("Mountain Dew", 0.99, "Dew the Dew");
      Drinks water = new Drinks("H20", 0.50, "Waterboy approved");
      Drinks coffee = new Drinks("Coffee", 1.50, "Good ol Mississippi Mud Water");

      Entree burger = new Entree("Big Boy Burger", 5.00, "You want a Heart Attack? We've got the burger for you");
      Entree hotDog = new Entree("HotDawg", 2.50, "Issa one hot dawg, dawg.");
      Entree salad = new Entree("Salad...", 1.50, "Don't know why we serve this to be honest");
      Entree pizza = new Entree("Pizzzzza", 3.00, "We are the new Papa John in town.");

      Sides fries = new Sides("French Fries", 1.25, "Did the french make the French Fry??");
      Sides fruitCup = new Sides("Fruit Cup....", 1.00, "Again, why do we serve this??");
      Sides mac = new Sides("Mad Max's Mad Mac", 2.25, "This is one bomb mac!");

      Items.AddRange(new MenuItem[] { soda, water, coffee, burger, hotDog, salad, pizza, fries, fruitCup, mac });
    }

    public MenuItemService()
    {
      Items = new List<MenuItem>();
      Messages = new List<string>();
      Setup();
    }
  }
}