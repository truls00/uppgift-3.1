using System;
namespace uppgift_3._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder > 19)
            {
                Console.WriteLine("du är för gammal");
                Console.ReadKey();  
            }
            if (ålder < 16)
            {
                Console.WriteLine("du är för ung");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Du får vara med");
                Console.ReadKey();  
            }
        }
    }
}







