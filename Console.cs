using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Threading.Tasks;
namespace ConsoleApp6
{
    internal class Program
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(false);

        static void Main(string[] args)
        {
            Random random = new Random();

            int size = 30;

            bool FruitEaten = true;
            int[] snake = new int[size - 1];

            int[,] grid = new int[size, size];
            var input = ConsoleKey.P;
            // cordinates of player
            int x = 5;
            int y = 5;
            while (true)
            {
                Thread.Sleep(100);
                // checks if a key isn being pressed in order to not pause the progeram untill further input
                if (Console.KeyAvailable == true)
                {
                    input = Console.ReadKey().Key;

                }


                if (ConsoleKey.D == input)
                {
                    if (x + 1 == 2)
                    {
                        FruitEaten = true;

                    }
                    grid[y, x] = 0;
                    x++;

                }
                if (ConsoleKey.A == input)
                {
                    if (x - 1 == 2)
                    {
                        FruitEaten = true;

                    }
                    grid[y, x] = 0;
                    x--;

                }
                if (ConsoleKey.S == input)
                {
                    if (y + 1 == 2)
                    {
                        FruitEaten = true;

                    }
                    grid[y, x] = 0;
                    y++;

                }
                if (ConsoleKey.W == input)
                {
                    if (y - 1 == 2)
                    {
                        FruitEaten = true;

                    }
                    grid[y, x] = 0;
                    y--;

                }

                grid[y, x] = 1;
                RefreshGrid(grid, size);


                if (FruitEaten == true || input == ConsoleKey.F)
                {
                    spawn_fruit(grid, random.Next(0, 30), random.Next(0, 30));
                    FruitEaten = false;
                    Console.WriteLine(FruitEaten);
                }
            }

        }

        static void RefreshGrid(int[,] grid, int s)
        {
            Console.Clear();
            for (int i = 0; i < s - 1; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < s - 1; j++)
                {

                    if (grid[i, j] == 1)
                    {
                        Console.Write("██");
                    }
                    else if (grid[i, j] == 2)
                    {
                        Console.Write("[]");
                    }
                    else
                    {
                        Console.Write("  ");
                    }


                }
            }
        }
        static void spawn_fruit(int[,] grid, int a, int b)
        {
            for (int i = 0; i < grid.Length - 1; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    if (i == a && j == b)
                    {
                        grid[i, j] = 2;
                    }

                }
            }

        }









    }
}








