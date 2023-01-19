using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Schema;

Dictionary<string, decimal> menu = new Dictionary<string, decimal>();

menu.Add("eggs", 3.99m);
menu.Add("milk", 4.99m);
menu.Add("bread", 2.99m);
menu.Add("fruit", 5.99m);
menu.Add("vegetables", 6.99m);
menu.Add("butter", 1.99m);
menu.Add("chewing tobacco", 7.99m);
menu.Add("cereal", 9.99m);


Console.WriteLine("Welcome to The Market! ");

Console.WriteLine("" +
    "Item\t\t\tPrice\n" +
    "=======================================\n" +
    "eggs\t\t\t3.99\n" +
    "milk\t\t\t4.99\n" +
    "bread\t\t\t2.99\n" +
    "fruit\t\t\t5.99\n" +
    "vegetables\t\t6.99\n" +
    "butter\t\t\t1.99\n" +
    "chewing tobacco\t\t7.99\n" +
    "cereal\t\t\t9.99\n");

List<string> list = new List<string>();
List<decimal> list2 = new List<decimal>();

bool runProgram = true;
while (true)
{
    Console.WriteLine("What item would you like to order? ");
    string choice = Console.ReadLine(); 
        
    if (menu.ContainsKey(choice))
    {
        list.Add(choice);
        list2.Add(menu[choice]);
        Console.WriteLine($"{choice} has been added to your list at ${list2[0]} ");
        Console.WriteLine("Do you want to add anything else to your list? (y/n) ");
        string again = Console.ReadLine();
        if (again == "y")
        {
            runProgram = true;
        }
        else if (again == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine($"{again} is not valid. Please enter eith y or n. ");
        }
    }
    else
    {
        Console.Write($"{choice} is out of stock. Try Meijer. ");
    }
}

decimal total = list2.Sum();
decimal Expensive = list2.Max();
decimal Cheap = list2.Min();
Console.WriteLine("Thanks for your order! ");
Console.WriteLine("Here's what you got: ");
Console.WriteLine("" + "Item\t\tPrice\n=============================");
foreach (string s in list)
{
    Console.WriteLine($"{s}            \t${menu[s]}");
}
Console.WriteLine($"Your total is {total}");
Console.WriteLine($"The most expensive item was {Expensive}");
Console.WriteLine($"The least expensive item was {Cheap}");












