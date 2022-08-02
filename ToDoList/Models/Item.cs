using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.JoinEntities = new HashSet<CategoryItem>();
    }

    public int ItemId { get; set; }
    public string Description { get; set; }
    private bool _isCompleted = false;
    public bool IsCompleted
    {
      get
      {
        return _isCompleted;
      }
      set
      {
        _isCompleted = value;
      }
    }
    public DateTime DueDate { get; set; }

    public virtual ICollection<CategoryItem> JoinEntities { get;}
  }
}