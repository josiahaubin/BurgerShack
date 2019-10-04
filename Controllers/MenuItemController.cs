using BurgerShack.Services;

namespace BurgerShack.Controllers
{
  public class MenuItemController
  {
    private MenuItemService _ms { get; set; } = new MenuItemService();
    public MenuItemController()
    {
    }
  }
}