// See https://aka.ms/new-console-template for more information


using System.Globalization;

Console.WriteLine("Hello and welcome to Fundamentals Assignment");

Console.WriteLine("************************   1   ************************");

int i ;
// 1 
for ( i = 1; i<= 255 ; i++ )
{
    Console.WriteLine(i);
}

// 2
Console.WriteLine("************************   2   ************************");

for ( int j = 1; j<= 100 ; j++ )
{
    if ( j % 3 == 0 && j % 5 == 0)
    {
        Console.WriteLine(j);
    }
}

// 3
Console.WriteLine("************************   3   ************************");

for ( int x = 1; x<= 100 ; x++ )
{
    if ( x % 3 == 0 && x % 5 == 0)
    {
        Console.WriteLine(x +"FizzBuzz");
    }
    else if (x % 3 == 0)
    {
        Console.WriteLine(x +"Fizz");
    }
    else if ( x % 5 == 0)
    {
        Console.WriteLine(x +"Buzz");
    }
}

Console.WriteLine("************************   4   ************************");

// Using while loop  
int z = 1;
while ( z < 100)
{
    if ( z % 3 == 0 && z % 5 == 0)
    {
        Console.WriteLine(z +"FizzBuzz");
    }
    else if (z % 3 == 0)
    {
        Console.WriteLine(z +"Fizz");
    }
    else if ( z % 5 == 0)
    {
        Console.WriteLine(z +"Buzz");
    }
    z++;
}
