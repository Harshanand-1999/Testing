using System;

namespace TikTakToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            structure();
        }
        static int[,] elements = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        static void structure()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ",elements[0,0],elements[0,1],elements[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", elements[1, 0], elements[1, 1], elements[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", elements[2, 0], elements[2, 1], elements[2, 2]);  
        }

        



    }
}
