using System;
using BurgerShack.Services;

namespace BurgerShack.Controllers
{
  public class MenuItemController
  {
    private MenuItemService _ms { get; set; } = new MenuItemService();

    public void UserInput()
    {
      _ms.GetItems();
      Print();
    }

    private void Print()
    {
      foreach (string message in _ms.Messages)
      {
        Console.WriteLine(message);
      }
      _ms.Messages.Clear();
      Console.WriteLine();
    }

    public MenuItemController()
    {
    }
  }
}