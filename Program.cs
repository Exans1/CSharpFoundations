/**************************************Header****************************************
Sean Kim
11/15/2017
CSharpFoundations


Console code for write line stolen from 
https://social.msdn.microsoft.com/Forums/en-US/ca9ddcea-7487-4e69-8e52-cae4f5b66c37/c-help-how-to-get-user-input-and-have-code-responde-to-it?forum=Vsexpressvcs
***************************************Header****************************************/
using System;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in your name.");

            string name = Console.ReadLine();

            Console.WriteLine("Hello {0} how are you on this fine day? Press 1 for Good or 2 for bad.", name);

            int result;

            if (int.TryParse(Console.ReadLine(), out result))

            {

                if (result == 1)

                    Console.WriteLine("Well {0} I am glad to hear it, cool!", name);

                else if (result == 2)

                    Console.WriteLine("Well {0} I am sorry to hear it, that sucks!", name);

                else

                    Console.WriteLine("Incorrect response");

            }

            else

                Console.WriteLine("Incorrect response");

            Console.ReadLine();

            Console.WriteLine("Enter an number between 5 and 20.");
            int myResponse = int.Parse(Console.ReadLine());
            int i = 1;
           
            if (myResponse <= 20 && myResponse >= 5){
                while (i <= myResponse) {
                if(i % 2 == 0 ){
                    Console.WriteLine(i + " is Even.");
                }
                else {
                Console.WriteLine(i+ " is Odd.");
                }
                i++;
                }
            }
            else {
                Console.WriteLine("Invalid Responce");
            }
            
            
            Console.WriteLine("Push Enter to End program");
            Console.ReadLine();
        }
    }
}
