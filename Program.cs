using System;

namespace Secure_Database
{
    class Program
    {
        static void Main(string[] args)
        {
             data user = new data();

                System.Console.WriteLine("User register:");
                System.Console.WriteLine("");

                Console.WriteLine("Insert Name: ");
                user.name = Console.ReadLine();

                System.Console.WriteLine("Insert id: ");
                user.id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insert key: ");
                user.key = Console.ReadLine();

        }
    }
}
//Solo pude hacer la lista bien, intente hacer lo demás pero no sabía como.