﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            string kayakProducts = "Kayak";
            //print the kayakProducts to the console using a foreach loop.
            foreach (string Kayak in products)
            {
                Console.WriteLine(Kayak);
            }
            Console.WriteLine();
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            string shoeProducts = "Shoes";
            //print the shoeProducts to the console using a foreach loop or string.Join().
            foreach (string Shoes in products)
            {
                Console.WriteLine(Shoes);
            }
            Console.WriteLine();
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            string ballProducts = "ball";
            //print the ballProducts to the console using a foreach loop or string.Join().
            foreach (string ball in products)
            {
                Console.WriteLine(ball);
            }
            Console.WriteLine();
            //sort ballProducts alphabetically and print them to the console.
            List<string> sorted = products.OrderBy(x => x).ToList();
            //add six more items to the products list using .add().
            products.Add("Bike Bars");
                        products.Add("Bike Frame");
                        products.Add("Bike Fork");
                        products.Add("Bike Front Wheel");
                        products.Add("Bike Back Wheel");
                        products.Add("Bike Crank Arms");


            //print the product with the longest name to the console using the .First() extension.
                        List<string> longest = products.OrderBy(x => x.Length).ToList();
                        Console.WriteLine(products.Skip(0).Take(1).Last());
            //print the product with the shortest name to the console using OrderByDesceding() and the .First() extension.
                        List<string> shortest = products.OrderByDescending(x => x.Length).ToList();
                        Console.WriteLine(products.Skip(0).Take(1).First());
            //print the product with the 4th shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
                        List<string> fourthShortest = products.OrderBy(x => x.Length).ToList();
                        Console.WriteLine(products.Skip(3).Take(1).First());
            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
                        List<string> secondLongest = products.OrderBy(x => x.Length).ToList();
                        Console.WriteLine(products.Skip(1).Take(1).Last());
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).

            //print out the reversedProducts to the console using a foreach loop.

            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //Note: you will not use a variable to store your list

            Console.ReadKey();
        }
    }
}