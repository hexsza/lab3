using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("n=");
            int count = int.Parse(Console.ReadLine());

            Movie[] movies = new Movie[count];

            Console.WriteLine(
                "genres՝ 1-Action, 2-Comedy, 3-ScienceFiction, 4-Drama, 5-Horror");

            Console.WriteLine(
                "input: number name year genre views likes");

            for (int i = 0; i < count; i++)
            {
                Console.Write($"film {i + 1}: ");
                string input = Console.ReadLine();

                movies[i] = new Movie(input);
            }

            Console.WriteLine();
            Console.WriteLine(
                $"{"No",4} {"Name",-15} {"Year",-8} {"Genre",-12} {"Rating",8}");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }
    }
}
