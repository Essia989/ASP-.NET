// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Xml.XPath;

Console.WriteLine("Welcome to the Fundamentals II assignment");


Console.WriteLine("*************************  PrintNumbers  ************************");
static void PrintNumbers()
{
    // Print all of the integers from 1 to 255.
    for (int i = 1 ; i<= 255; i++)
    {
        System.Console.WriteLine(i);
    }
}
PrintNumbers();

Console.WriteLine("*************************  PrintOdds  ************************");
static void PrintOdds()
{
    // Print all of the odd integers from 1 to 255.
    for (int i = 1 ; i<= 255; i++)
    {
        if (i % 2 != 0)
        {
            System.Console.WriteLine(i);
        }
    }
}
PrintOdds();

Console.WriteLine("*************************  PrintSum  ************************");
static void PrintSum()
{
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New number: 2 Sum: 3
    int sum = 0;
    for (int i = 0; i<= 255; i++)
    {
        sum += i;
    }
    Console.WriteLine("Sum = "+ sum); 
}
PrintSum();

Console.WriteLine("*************************  LoopArray  ************************");
static void LoopArray(int[] numbers)
{
    // Write a function that would iterate through each item of the given integer array and 
    // print each value to the console. 
    foreach (int val in numbers)
    {
        System.Console.WriteLine(val);
    }
}

int[] array2 = { 1, 73, -25, 4, -36, 6 };
LoopArray(array2);


Console.WriteLine("*************************  FindMax  ************************");
static int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    int max = numbers[0];
    foreach (int val in numbers)
    {
        if ( val > max)
        {
            max = val;
        }
    }
    return (max);
}

System.Console.WriteLine("The maximum value is  : " + FindMax(array2));


Console.WriteLine("*************************  GetAverage  ************************");
static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    int sum = 0;
    foreach (int i in numbers)
    {
        sum += i;
    }
    int avg = sum / numbers.Length;
    Console.WriteLine("Average  = "+ avg); 
}
int[] array = { 1, 73, -25, 4, -36, 6 ,20};
GetAverage(array);

Console.WriteLine("*************************  OddList  ************************");
static List<int> OddList()
{
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
    List<int> list = new List<int>();
    for (int i = 1 ; i<= 255; i++)
    {
        
        if (i % 2 != 0)
        {
            list.Add(i);
        }
    }
    return (list);
}
List<int> result_list = OddList();
foreach (int i in result_list )
{
    System.Console.WriteLine(i);
}

Console.WriteLine("*************************  GreaterThanY  ************************");
static int GreaterThanY(List<int> numbers, int y)
{
    // Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
    int count = 0;
    foreach (int i in numbers )
    {
        if (i > y)
        {
            count += 1;
        }
    }
    return count ;
}

List<int> list1 = new List<int>();

list1.Add(32);
list1.Add(2);
list1.Add(45);
list1.Add(1);
list1.Add(89);
list1.Add(3);
list1.Add(21);
list1.Add(4);
list1.Add(11);
list1.Add(9);

System.Console.WriteLine(GreaterThanY(list1, 0) + " numbers are greater than 11 ");


Console.WriteLine("*************************  SquareArrayValues  ************************");
static void SquareArrayValues(List<int> numbers)
{
    // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
    for ( int i =0; i<numbers.Count; i++ )
    {
        System.Console.WriteLine("Before the square : "+numbers[i]);
        numbers[i] = numbers[i] * numbers[i];
    }
    for ( int i = 0; i < numbers.Count; i++ )
    {
        System.Console.WriteLine("After the square : "+ numbers[i]);
    }

}
SquareArrayValues(list1);

Console.WriteLine("*************************  EliminateNegatives  ************************");
static void EliminateNegatives(List<int> numbers)
{
    // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
    for ( int i =0; i<numbers.Count; i++ )
    {
        if ( numbers[i] < 0 )
        {
            numbers[i] = 0;
        }        
    }
    foreach ( int i in numbers )
    {
        System.Console.WriteLine(i);
    }
}

List<int> list2 = new List<int>();

list2.Add(32);
list2.Add(2);
list2.Add(-45);
list2.Add(-1);
list2.Add(89);
list2.Add(3);
list2.Add(-21);
list2.Add(4);
list2.Add(-11);
list2.Add(9);
EliminateNegatives(list2);

