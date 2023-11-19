// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

Console.WriteLine("Welcome to Puzzles Console App");

Console.WriteLine("****************  Random Array  ****************");
static void  RandoArray()
{
    int[] numArray =new int[10];
    Random rand = new Random();
    // variable initialisation 
    int  max = numArray[0];
    int  sum = 0;
    
    // filling the array with random integers betwee 5 and 25
    for ( int i= 0; i< 10 ; i++)
    {
        numArray[i] = rand.Next(5,26);
    }
    // intialising the min var 
    int min  = 5;
    // looping through the array and retreiving the max min value and sum
    for (int j= 0; j<10; j++)
    {
        
        sum += numArray[j];
        if (numArray[j]>max) max = numArray[j];
        if (numArray[j]<min) min = numArray[j];
        // printing the array values 
        System.Console.WriteLine(" numArray ["+j+"] = "+numArray[j]);
    }
    // printing the result
    System.Console.WriteLine(" MAx = "+max);
    System.Console.WriteLine(" Min = "+min);
    System.Console.WriteLine(" Sum  = "+sum);

}

RandoArray();

Console.WriteLine("****************  Toss the Coin  ****************");
static string TossCoin()
{
    System.Console.WriteLine("Tossing the Coin!");
    Random rand = new Random();
    bool isHeads = false;
    string result;
    if (rand.Next(0,2) == 1) isHeads = true;
    if (isHeads == false) result ="Tails";
    else result ="Heads";
    return result;
}

string str = TossCoin();
System.Console.WriteLine(str);


Console.WriteLine("****************  TossMultipleCoins(int num)  ****************");
static double TossMultipleCoins(int num)
{
    int count = 0;
    for (int i= 0; i<num; i ++)
    {
        string str = TossCoin();
        System.Console.WriteLine(str);
        if (str == "Heads") count++;
    }
    double ratio = (double)count / num;
    return ratio ;
}

double rslt = TossMultipleCoins(10);

System.Console.WriteLine(" The Heads ratio is " + rslt*100 +"%");

Console.WriteLine("****************  Names  ****************");
static List<string> Names(int num)
{
    List<string> lst = new List<string>();
    lst.Add("Todd");
    lst.Add("Tiffany");
    lst.Add("Charlie");
    lst.Add("Gene");
    lst.Add("Sydney");
    List<string> lst_result = new List<string>();
    foreach (string l in lst)
    {
        if ( l.Length > num) lst_result.Add(l);
    }

    return lst_result;
}

List<string> reslt = Names(5);
foreach (string ls in reslt)  System.Console.WriteLine(ls);