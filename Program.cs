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
        }
    }
}
