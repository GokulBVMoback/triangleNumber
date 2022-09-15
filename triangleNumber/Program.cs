using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine()); //get user input for num
            Console.Write("Enter the Width:");
            int width=Convert.ToInt32(Console.ReadLine()); //get user input for width
            int width2 = width; //we assign the value of width to width2


            for(int row=0; row<width; row++) //this loop is looped for what you give in Width
            {
                for(int col=0; col<width2; col++) //this loop is looped for the value of width2. By default it`s value is what you give in the width.
                {
                    Console.Write(num);  //this print the number what you give in the number. print it for the number of time that the inner for loop is looped.
                }
                Console.WriteLine(); //after the inner loop was looped. this shift the cursor to next line
               width2--; //this decrease the value of width2 after exit from inner for loop
            }

        }
    }
}
