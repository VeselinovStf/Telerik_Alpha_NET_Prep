using System;

namespace Day_13_AbstractClasses
{
    public class MyBook : Book
    {       
        private int price;
 
        public MyBook(string t, string a , int price)
            : base( t,a)
        {
            this.price = price;
        }

        public override void display()
        {
            System.Console.WriteLine($"Title: {this.title}");
            System.Console.WriteLine($"Author: {this.author}");
            System.Console.WriteLine($"Price: {this.price}");
        }
    }
}