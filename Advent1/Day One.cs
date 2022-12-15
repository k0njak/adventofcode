using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Runtime;


// The first part of Advent Of Code Day 1


string[] text = System.IO.File.ReadAllLines(@"E:\Code Stuff\advent1.txt");

List<int> newNumberList = new List<int>(); // List for all the numbers.

List<int> newNumberListOfSums = new List<int>();


// Loop through a string array and convert each line into int. Then when hit the white space add the lines together and print out sum.

foreach(string line in text)
{
    if(line != string.Empty)
    {
        int currentLineAsInt = int.Parse(line);
        Console.WriteLine(currentLineAsInt + " This is int");
        newNumberList.Add(currentLineAsInt);
      
    }

    else if(line == string.Empty)
    {

        // Save the value in array or list.

        Console.WriteLine("There is empty line");
        int theEntry = newNumberList.Sum();
        newNumberListOfSums.Insert(0, theEntry);



        // Assign the highest value.
        int highestValue = newNumberListOfSums.Max();

        Console.WriteLine(highestValue + " This is the highest value in the sums list.");
        


        // Get the top three of the stuff.

        int theTotalForTopThree =+ newNumberListOfSums.OrderByDescending(p => p).Take(3).Sum();

        Console.WriteLine(theTotalForTopThree + " This is the sum of top three elfs.");


        // Clear the list for new entry.
        newNumberList.Clear();




    }






}


Console.ReadLine();


