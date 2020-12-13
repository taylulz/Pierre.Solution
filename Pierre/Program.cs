using System;
using Pierre.Models;
using System.Collections.Generic;

class Program
{
  // public static Bread pita = new Bread("pita", 0);
  // public static Bread french = new Bread("french", 0);
  // public static List<Bread> allBread = new List<Bread>() {pita, french};
  public static string[] breadMenu = { "pita", "french" };

  // public static Pastry biscuit = new Pastry("biscuit", 0);
  // public static Pastry croissant = new Pastry("croissant", 0);
  // public static List<Pastry> allPastries = new List<Pastry>() {biscuit, croissant};
  public static string[] pastryMenu = { "biscuits", "croissants" };

  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("Would you like to order some of our fine Breads? ['Y' for yes, 'N' for no]");
    string breadYesOrNo = Console.ReadLine().ToLower();
    if (breadYesOrNo == "y")
    {
      // go to new bread order method
      OrderBread();
    }
    else
    {
      // go to pastry method!
      OrderPastry();
    }
  }
  public static void OrderBread()
  {
    Console.WriteLine("Please select from our following bread items:");
    Console.WriteLine("----------------");
    foreach (string loaf in breadMenu)
    {
    Console.WriteLine(loaf);
    }
    Console.WriteLine("----------------");

    Console.WriteLine("What type of bread do you want?");
    string breadSelection = Console.ReadLine();
    Console.WriteLine("You selected: " + breadSelection);
    Console.WriteLine("How many of these " + breadSelection + " bread loaves do you want?");
    int breadQuant = int.Parse(Console.ReadLine());
    Bread breadOrder = new Bread(breadSelection, breadQuant);
    Console.WriteLine("you ordered " + breadOrder.Quantity + " of the " + breadOrder.BreadKind);
    Console.WriteLine("Bread order recieved! Press ['enter'] to see our Pastry menu");
    Console.ReadLine();
    OrderPastry();
  }
  public static void OrderPastry()
  {
    Console.WriteLine("What type of pastry would you like?");
    Console.WriteLine("----------------");
    foreach (string pastry in pastryMenu)
    {
      Console.WriteLine(pastry);
    }
    Console.WriteLine("----------------");
    string pastrySelection = Console.ReadLine();
    Console.WriteLine("How many of the " + pastrySelection + " do you want?");
    int pastryQuant = int.Parse(Console.ReadLine());
    Pastry newPastryOrder = new Pastry(pastrySelection, pastryQuant);
    Console.WriteLine("You ordered " + pastryQuant + " of the " + pastrySelection);
  }
} 

// I want the console to do things in this order:
// 1. Start screen lists breads and pastries
// 2. Ask what type and quantity of bread
// 3. Ask what type and quantity of pastry
// 4. Ask if they need to add anything else (if so run through main again)
// 5. Once the answer is "no" to needing anything else...
// 6. Print the grand total and what they ordered