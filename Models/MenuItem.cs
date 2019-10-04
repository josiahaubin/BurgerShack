namespace BurgerShack.Models
{
  public abstract class MenuItem
  {
    public string Title { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }

    public MenuItem(string title, int price, string desc)
    {
      Title = title;
      Price = price;
      Description = desc;
    }
  }
}