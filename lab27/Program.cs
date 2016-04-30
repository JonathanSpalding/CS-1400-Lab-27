// Author: Jonathan Spalding
// Assignment: lab 27
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 4/19/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using static System.Console;
using System.IO;

namespace lab27
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Declare variables, including an array of Boxes
            const int MAX = 10;
            // Set counter to zero
            int count = 0;
            string inputLine = "";
            Box[] boxes = new Box[MAX];
            // open the file
            WriteLine("Please enter the name of your file in your documents folder: ");
            string environment = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\";
            StreamReader file = new StreamReader(environment + ReadLine());
            // loop until all ata is read or the array is full
            do
            {
                //read in all of the ata for one object, saving the data in some local variables
                inputLine = file.ReadLine();
                //
                if (inputLine != null && count < MAX)
                {
                    //create an object passing the data to the constructor
                    string[] data = inputLine.Split();
                    int dataH = int.Parse(data[0]);
                    int dataW = int.Parse(data[1]);
                    int dataD = int.Parse(data[2]);
                    // save the reference to the object in the array and increment the counter
                    boxes[count++] = new Box(dataH, dataW, dataD);
                }   
            } while (inputLine != null && count < MAX);
            // for loop that writes the volume of each box.
            for (int j = 0; j < count; j++)
            {
                Console.WriteLine("The volume of box {0:d} is {1:d} cubic inches", j + 1, boxes[j].GetVolume());
            }
            ReadKey(true);
        }
    }
}
