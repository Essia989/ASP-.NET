// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");


// Three Basic Arrays 

//Array 1
Console.WriteLine("**************************** Arrays  ******************************");
int [] intArray = new int [10];

int i ;
for (i = 0; i<10 ; i++)
{
    intArray[i] = i;
    Console.WriteLine(intArray[i]);
}

string [] names = new string[] {"Tim","Martin","Nikki","Sara"};

Boolean [] Array1 = new bool [10];

int j ;
for (j = 0; j<10 ; j++)
{
    if (j % 2 == 0)
    {
        Array1[j] = true;
    }
    else
    {
        Array1[j] = false;
    }
    Console.WriteLine(Array1[j]);
}

Console.WriteLine("**************************** Lists  ******************************");
// List of Flavors

List<string> Icecream = new List<string>();
Icecream.Add("Vanilla");
Icecream.Add("Chocolat");
Icecream.Add("Coffee");
Icecream.Add("Strawberry");
Icecream.Add("Kiwi");

Console.WriteLine("We have a list of "+Icecream.Count +" icecream flavors");
Console.WriteLine("Icecream [2] : "+Icecream[2]);
Icecream.RemoveAt(2);
Console.WriteLine("We have a list of "+Icecream.Count +" icecream flavors after removing ");

Console.WriteLine("**************************** Dictionary  ******************************");
// User Info Dictionary


//Almost all the methods that exists with Lists are the same with Dictionaries

Random rand = new Random();

Dictionary<string,string> users = new Dictionary<string,string>();

for( int k = 0;k<names.Length; k++ ) 
{
        users.Add(names[k],Icecream[rand.Next(0,Icecream.Count)]);
}

foreach (var entry in users)
{
    Console.WriteLine(entry.Key + " your favoutrite flavor is "+ entry.Value);
}




