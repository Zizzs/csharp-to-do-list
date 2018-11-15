using System.Collections.Generic;
using System;
using System.Linq;

namespace ToDoList.Models
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the to-do list!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View):");
      string userResponse = Console.ReadLine();
      if (userResponse == "Add" || userResponse == "add")
      {
        Console.WriteLine("Please enter the description for the new item: ");
        string userDescription = Console.ReadLine();
        Item userItem = new Item(userDescription);
        Console.WriteLine( userItem.GetDescription() + " has been added to your list. ");
        Main();
      }
      else if (userResponse == "View" || userResponse == "view")
      {
        foreach(Item item in Item.GetAll())
        {
            Console.WriteLine(item.GetDescription());
        }
        Main();
      }



    }
  }
  public class Item
  {
    private string _description;
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)
    {
      _description = description;
      _instances.Add(this);
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
       _description = newDescription; 
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
     _instances.Clear();
    }

  }
}