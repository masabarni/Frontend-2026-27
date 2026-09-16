using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main()
        {
            //Data Source
            List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            //LINQ Quer
            /* var evenNumber = from num in numbers
                              //where num % 2 == 0
                              where num > 3 && num < 10
                              select num;*/


            List<int> resultNumbers = new List<int>();//var evenNumbres helyett van 
           foreach(int num in numbers) //From num is numbers helyett
            {
                if(num % 2 == 0) // where helyett
                {
                    Console.WriteLine(num);
                }
            }

            //Execution
            foreach(var num in resultNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
