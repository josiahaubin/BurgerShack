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
      string userAns = Console.ReadLine().ToLower();
      Console.Clear();

      switch (userAns)
      {
        case "q":
          Environment.Exit(1);
          break;
        default:
          if (int.TryParse(userAns, out int index))
          {
            _ms.GetItems(index - 1);
            Print();
            Console.ReadKey();
            Console.Clear();
          }
          break;
      }
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