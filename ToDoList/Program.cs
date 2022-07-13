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
        AddItem();
      }
      else
      {
        ViewItem();
      }

      static void AddItem()
      {
        Console.WriteLine("Please enter the description for the new item.");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        Console.WriteLine("=======================================");
        Console.WriteLine(description + " has been added to your list. Would you like to add an item to your list or view your list? ['A' for add, 'Enter' for view]");
        string response = Console.ReadLine();
        if (response == "A" || response == "a")
        {
          AddItem();
        }
        else
        {
          ViewItem();
        }
      }

      static void ViewItem()
      {
        List<Item> result = Item.GetAll();

        if (result.Count == 0)
        {
          Console.WriteLine("You don't have any item in the list yet");
          AddItem();
        }
        else
        {
          foreach (Item thisItem in result)
          {
            Console.WriteLine(thisItem.Description);
          }
          Console.WriteLine("=======================================");
          Console.WriteLine("Would you like to add more items to the list? ['A' for add, 'Enter' for quit]");
          string response = Console.ReadLine();
          if (response == "A" || response == "a")
          {
            AddItem();
          }
        }
      }
    }
  }
}