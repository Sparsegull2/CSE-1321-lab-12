/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab12A
*/

using System;
class chair
{
    public int numOfLegs;
    public bool rolling;
    public string material;

    public chair (int numOfLegs,bool rolling,string material)
    {
        this.numOfLegs = numOfLegs;
        this.rolling = rolling;
        this.material = material;
    }
}
class Lab12A
{

    public static void Main(string[] args)
    {
        Console.WriteLine("You are about to create a chair.");
        Console.Write("How many legs does your chair have: ");
        int numlegs=int.Parse(Console.ReadLine());
        Console.Write("Is your chair rolling (true/false): ");
        bool rolling= bool.Parse(Console.ReadLine());
        Console.Write("What is your chair made of: ");
        string material= Console.ReadLine();
        chair c1=new chair(numlegs,rolling,material);
        
        if (c1.rolling)
        {
            Console.WriteLine("\nYour chair has " + c1.numOfLegs + " legs, is rolling, and is made of " + c1.material + ".");
        }
        else
        {
            Console.WriteLine("\nYour chair has " + c1.numOfLegs + " legs, is not rolling, and is made of " + c1.material + ".");
        }
        Console.WriteLine("\nThis program is going to change that.");
        c1.rolling = false;
        c1.material = "wood";
        c1.numOfLegs = 4;
        if (c1.rolling)
        {
            Console.WriteLine("\nYour chair has " + c1.numOfLegs + " legs, is rolling, and is made of " + c1.material + ".");
        }
        else
        {
            Console.WriteLine("\nYour chair has " + c1.numOfLegs + " legs, is not rolling, and is made of " + c1.material + ".");
        }

    }
}
