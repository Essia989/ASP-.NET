// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class Buffet
{
    public List<Food> Menu;
    Random rand = new Random();
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Burger", 1000, true, false),
            new Food("Burger", 1000, true, false),
            new Food("Burger", 1000, true, false),
            new Food("Chiken Rice", 1300, true, false),
            new Food("Roasted Turkey", 2400, true, false),
            new Food("Cheese Cake", 2400, false, true),
            new Food("Baklawa", 400, false, true)
        };
    }
    
    public Food Serve()
    {
        Food served_food = Menu [rand.Next(0,6)];
        return served_food;
    }
}

﻿Buffet buffet = new();

Ninja ninjaOne = new Ninja();

ninjaOne.Eat(buffet.Serve());