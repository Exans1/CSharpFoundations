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
            decimal? bonus = null;
            bool hasBonus = false;

            if(bonus.HasValue){
                hasBonus = true;
                Console.WriteLine(hasBonus);
            }
            else{
                Console.WriteLine(false);
            }
            
        }
    }
}
