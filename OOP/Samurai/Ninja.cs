class Ninja : Human
{
    int Attack_count; 
    public Ninja (string name, int str, int intel, int hp)
    {
        Human( name,  str, intel,  75,  hp)
        Attack_count = 0; 
    }

    public override int Attack(Human target)
    {
        Attack_count += 1;
        if ( Attack_count == 5)
        {
            target.Health -= Dexterity;
            Dexterity += 10 ;
            Console.WriteLine($"{Name} attacked {target.Name} for {Dexterity} damage!");
            Console.WriteLine($"{Name} is gained 10 dexterity points total is {Dexterity} Points !");
        }
        return target.Health;
    }
    
    public int Steal (Human target)
    {
        Health += 5;
        target.Health -= 5;
        Console.WriteLine($"{Name} stealed {target.Name} for {Dexterity} damage!");
    }


}