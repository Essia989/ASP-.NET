abstract class Ninja
{
    protected int calorieIntake;
    public List<IConsumable> ConsumptionHistory;
    public Ninja()
    {
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
    }
    public abstract bool IsFull {get;}
    public abstract void Consume(IConsumable item);



    //***********************************************************************



    /*
    private int calorieIntake;
    public List<Food> FoodHistory;
    
    // add a constructor
    public  Ninja(int calintake, Food food)
    {
        calorieIntake = calintake;
        FoodHistory.Add (food); 
    }


    // add a public "getter" property called "IsFull"
    public bool IsFull ()
    {
        if (calorieIntake > 1200) return true;
        else return false;
    }
    // build out the Eat method
    public void Eat(Food item)
    {
        if(IsFull()) 
        {
            System.Console.WriteLine("Ninja is full");
        }
        else 
        {
            calorieIntake += item.Calories;
            FoodHistory.Add (item);
            System.Console.WriteLine(" Food eaten " + item.Name + " " + item.Calories+" cal");
            if(item.IsSweet) System.Console.WriteLine("Food is Sweet");
            if(item.IsSpicy) System.Console.WriteLine("Food is Spicy");
        }
        
    } */
}

