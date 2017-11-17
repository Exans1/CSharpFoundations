/**************************************Header****************************************
Sean Kim
11/15/2017
CSharpFoundations

***************************************Header****************************************/
using System;
using System.Text;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            string gameOfThronesPremier = "April 17, 2011";

             DateTime gameOfThronesDate = Convert.ToDateTime(gameOfThronesPremier);
             
             Console.WriteLine(gameOfThronesDate);
        }
    }
}
