/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab12B
*/

using System;

class Dog
{
    public int age;
    public double weight;
    public string name;
    public string fur_color;
    public string breed;

    public Dog(int age,double weight,string name,string fur_color,string breed) 
    {
        this.age = age;
        this.weight = weight;
        this.name = name;
        this.fur_color = fur_color;
        this.breed = breed;
    }
    public void bark()
    {
        Console.WriteLine("\nWoof! Woof!");
    }
    public void rename(string new_name)
    {
        this.name=new_name;
    }
    public void eat(double food)
    {
        this.weight += food;
    }
}
class Lab12B
{

    public static void Main(string[] args)
    {
        Console.WriteLine("You are about to create a dog.");
        Console.Write("How old is the dog: ");
        int age =int.Parse(Console.ReadLine());
        Console.Write("How much does the dog weigh: ");
        double weight =int.Parse(Console.ReadLine());
        Console.Write("What is the dog’s name: ");
        string name =Console.ReadLine();
        Console.Write("What color is the dog: ");
        string fur_color =Console.ReadLine();
        Console.Write("What breed is the dog: ");
        string breed =Console.ReadLine();
        Dog d1=new Dog(age,weight,name,fur_color,breed);

        Console.WriteLine("\n"+d1.name+" is a "+d1.age+" year old "+d1.fur_color+" "+d1.breed+" that weighs "+d1.weight+" lbs.");
        d1.bark();
        Console.Write(d1.name+" is hungry, how much should he eat: ");
        double food=double.Parse(Console.ReadLine());
        d1.eat(food);
        Console.Write(d1.name+" isn’t a very good name. What should they be renamed to: ");
        string new_name=Console.ReadLine();
        d1.rename(new_name);
        Console.WriteLine("\n" + d1.name + " is a " + d1.age + " year old " + d1.fur_color + " " + d1.breed + " that weighs " + d1.weight + " lbs.");


    }
}
