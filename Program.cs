using System;
using System.Text;

namespace passwordapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning password generation, please enter the number of characters for your new random password");
            bool characterSelectionParsed = int.TryParse(Console.ReadLine(),  out int characterSelection);

            if (!characterSelectionParsed)
            {
                Console.WriteLine("Sorry, that is not a number, we will not be able to proceed.");
                return;
            }

            var rp = new RandomPassword();            

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Your random password is: {rp.Generate(characterSelection)}.");
            }
        }
    }
}
