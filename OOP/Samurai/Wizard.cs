Class Wizard : Human
[
    public Wizard (string name, int str, int dex)
    {
        Human( name,  str,  25,  dex,  50)
    }

    // Build Attack method
    public override int Attack(Human target)
    {
        int dmg = Intelligence * 3;
        target.Health -= dmg;
        Health += dmg ;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Console.WriteLine($"{Name} is healed by {dmg} Health Points !");
        return target.Health;
    }

    public interface Heal (Human target)
    {
        int healing = Intelligence * 3;
        target.Health += healing ;
        Health += Healing ;
        Console.WriteLine($"{Name} healed  {target.Name} for {healing } Health Points!");
        return target.Health;
    }



]