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
            string[] arr = new string[]{"Sansa", "Bran", "Eddard", "Arya"};

             foreach (string names in arr){
                Console.WriteLine(names); 
             }
        }
    }
}
