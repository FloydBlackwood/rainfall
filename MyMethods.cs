using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallAssignment
{
    class MyMethods
    {
        //variables declared
        int years;
        int totalMonths;
        double inches;
        double average;
        double totalInches = 0;
        string[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public int GetYears()//method to get number of years. This value is then passed to GetInches method
        {
            Console.Title = "Rainfall Assignment";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPlease Enter The Number Of Years: ");        
            int years = int.Parse(Console.ReadLine());
            return years;
        }
        public void GetInches(int years)
        {
            try//try catch statement displays error warning if invalid input is entered
            {
                //for loop repeats for each iteration of years
                for (int i = 0; i < years; i++)
                {
                    //nested for loop repeats for the months in the array
                    for (int j = 0; j < Months.Length; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("\nHow Many Inches Of Rainfall For " + Months[j] + " : ");
                        inches = double.Parse(Console.ReadLine());
                        //calculations to return answers
                        totalMonths = years * 12;
                        totalInches += inches;
                        average = totalInches / (years * 12);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)//end of try catch statement
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }
        }
        public void DisplayResults()//method to display the results of the calculations from GetInches

        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThe Total Number Of Months Is {0}", totalMonths);
            Console.WriteLine("\nThe Total Inches Of Rainfall Is {0}", totalInches);
            Console.WriteLine("\nThe Average Inches Of Rainfall Is {0}", average);

        }
    }
}
