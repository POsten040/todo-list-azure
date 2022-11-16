
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual List<Item> Items { get; set; }
  }
}