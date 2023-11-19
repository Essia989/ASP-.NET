// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class Human
{

    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human ( string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    // Add a constructor to assign custom values to all fields
    public Human ( string name, int strength, int intelligence , int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;

    }
    // Build Attack method
    public int Attack(Human target)
    {
        target.Health = target.Health - ( 3* Strength);
        return target.Health;
    }
}

