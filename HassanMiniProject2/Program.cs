// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Transactions;

// here is the welcome message to the user
Console.WriteLine("Here is Hassan's second masterpiece in C# programming!");
Console.WriteLine("Here is a program in which you can add a new watch to list of your watches!");

// an exit key is defined for user to enter if one doesn't want to add more watches

char exit;

string categoryName;
string productsName ;
int price;

List<Watch> Assets = new List<Watch>();

while (true)
{
    Console.WriteLine("Enter the information and if you want to quit press \"q\"");
    Console.Write("Enter Cateqory:");
    categoryName = Console.ReadLine();
    if (categoryName == "q")
    {
        break;
    }
    else
    {
        Console.Write("Enter Product:");
        productsName = Console.ReadLine();
        Console.Write("Enter Price:");
        price =Convert.ToInt32(Console.ReadLine());
    }
    Watch asset = new Watch(categoryName, productsName, price);
    Assets.Add(asset);

}

foreach(Watch asset in Assets)
{
    Console.WriteLine(asset.Category + " " + asset.ProductsName + " " + asset.Price);
}

// This is just comment




/*

foreach (Watch evryWatch in watch)
{
    Console.WriteLine("Do you want to add a whatch to to your list? If you don't want to add a new watch please enter:"+ "q " );

    Console.Write("Please enter the watchs category's name or press" + "q "+ " to exit:");
    evryWatch.category = Console.ReadLine();

    if (evryWatch.category == "q" || evryWatch.category == "Q")
        break;
    else { 
    Console.Write("please enter the product's name: ");
        evryWatch.productsName = Console.ReadLine();

        Console.Write("please enter the price: ");
        evryWatch.price = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine(evryWatch.category);
    Console.WriteLine(evryWatch.productsName);
    Console.WriteLine(evryWatch.price);
}

Console.WriteLine("Yes its fine, don't worry your code is working");

*/

Console.ReadLine();

/* Creating an Array: It should be like this:
 * Type of variables shoud be witten and number of variables.
 * It is not resisable
string[] arraysName = new string[10];
its not nessesary to write how many elements it should be contaned
var taype will be defined after entering the first value.
Creating a list should be like this:
List<double> valiues= new List<double>();

*/




class Watch
{
    public Watch(string category, string product, int price)
    {
        this.Category = category;
        this.ProductsName = product;
        this.Price = price;
    }

    public string Category { get; set;}
    public string ProductsName { get; set;}
    public int Price { get; set;}
   
}




