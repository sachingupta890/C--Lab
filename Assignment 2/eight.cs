
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Working of Dog class : ");
            dog.Get();
            dog.Show();
            Cat cat = new Cat();
            cat.Get();
            cat.Show();

        }
    }
}
public abstract class Animal
{
    public abstract void Show();
}
public class Dog : Animal
{
    string name;
    int age;
    public void Get()
    {
        Console.WriteLine("Enter the name of Dog : ");
        name = Console.ReadLine();
        Console.WriteLine("Enter the age of Dog : ");
        age = Convert.ToInt32(Console.ReadLine());

    }
    public override void Show()
    {
        Console.WriteLine("Name of Dog is : " + name);
        Console.WriteLine("Age of Dog is : " + age);
    }
}
public class Cat : Animal
{
    string name;
    int age;
    public void Get()
    {
        Console.WriteLine("Enter the name of Cat : ");
        name = Console.ReadLine();
        Console.WriteLine("Enter the age of Cat : ");
        age = Convert.ToInt32(Console.ReadLine());

    }
    public override void Show()
    {
        Console.WriteLine("Name of Cat is : " + name);
        Console.WriteLine("Age of Cat is : " + age);
    }
}


   
