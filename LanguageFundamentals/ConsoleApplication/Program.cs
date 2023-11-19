// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using Console.WriteLine, you can output any string to the terminal/console");


/*
string name = "Tim";
int age = 30;
double height = 1.905;
bool blueEyed = false;
*/



//Declare a variable called rings that is of the Int Type
int numRings = 5;
if (numRings >= 5)
{
    Console.WriteLine("You are welcome to join the party");
}
else
{
    Console.WriteLine("Go win some more rings");
}


int numRings1 = 1;
if (numRings1 >= 5)
{
    Console.WriteLine("You are welcome to join the party");
}
else if (numRings1 > 2)
{
    Console.WriteLine($"Decent...but {numRings1} rings aren't enough");
}
else
{
    Console.WriteLine("Go win some more rings");
}

Console.WriteLine("************************************ For Loop *****************************************");


// loop from 1 to 5 including 5
for (int i1 = 1; i1 <= 5; i1++)
{
    Console.WriteLine(i1);
}
// loop from 1 to 5 excluding 5
for (int i2 = 1; i2 < 5; i2++)
{
    Console.WriteLine(i2);
}

Console.WriteLine("************************************* For Loop*******************************************"); 

int start = 0;
int end = 5;
// loop from start to end including end
for (int i3 = start; i3 <= end; i3++)
{
    Console.WriteLine(i3);
}
// loop from start to end excluding end
for (int i4 = start; i4 < end; i4++)
{
    Console.WriteLine(i4);
}

Console.WriteLine("************************************* While Loop*******************************************"); 

int i = 1;
while (i < 6)
{
    Console.WriteLine(i);
    i ++;
}

Console.WriteLine("********************************************************************************"); 

Random rand = new Random();
for(int val = 0; val < 10; val++)
{
    //Prints the next random value between 2 and 8
    Console.WriteLine(rand.Next(2,25));
}








/*

// Variable to interpolate
string place = "Coding Dojo";
//Interpolated string, note the $
string message = $"Hello {place}";
// Displaying final message
Console.WriteLine(message);
// Another option uses placeholders like so
// Note this does NOT have a $ at the start
Console.WriteLine("Hello {0}", place);

Console.WriteLine("The value of pi is " + 3.14159); 

Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");

*/