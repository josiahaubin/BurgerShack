namespace BurgerShack.Models
{
  public abstract class MenuItem
  {
    public string Title { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    public virtual string GetTemplate()
    {
      string template = $@"
Title: {Title}
Price: {Price:c}
Description: {Description}

Press any key to return to the main menu.
      ";

      return template;
    }

    public MenuItem(string title, double price, string desc)
    {
      Title = title;
      Price = price;
      Description = desc;
    }
  }
}