using System;
using BurgerShack.Controllers;

namespace BurgerShack
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the shack!");

      MenuItemController _mc = new MenuItemController();
      _mc.UserInput();
    }
  }
}
