using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      List<Item> newList = new List<Item>(0);

      Console.WriteLine("Welcome to the To Do List.");
      Console.WriteLine("Would you like to add an item to your list or view your list? ['A' for add, 'Enter' for view]");
      string response = Console.ReadLine();
      if (response == "A" || response == "a") 
      {
        Console.WriteLine("Please enter the description for the new item.");
        string description = Console.ReadLine();
        Item newItem1 = new Item (description); 
      }
      else
      {
        List<Item> result = Item.GetAll();

        foreach (Item thisItem in result)
        {
          Console.WriteLine(thisItem.Description);
        }
      }
    }
  }
}