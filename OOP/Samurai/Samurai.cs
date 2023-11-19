class Samurai : Human
{
    int Attack_count; 
    public Samurai (string name, int str, int intel, int dex)
    {
        Human( name,  str, intel,  dex,  200);
    }

    public override int Attack(Human target)
    {
        Attack (target);
        if ( target.Health < 50)
        {
            target.Health = 0;
            Console.WriteLine($"{Name} attacked {target.Name} and killed him !!!");
        }
        return target.Health;
    }
    
    public int Maditate ()
    {
        Health = 200;
        Console.WriteLine($"After meditation {Name} now recovered 100% of it's health points !");
    }
    return Health;
}