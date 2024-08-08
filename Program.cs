using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 4];

            int[,] matriz2 = new int[5, 2];

            int[,] matriz3 = new int[5, 5];

            matriz3[0, 0] = 0;

            for (int li = 0; li < 5; li++)
            {

                for (int c = 0; c < 5; c++)
                {

                    matriz3[li, c] = 0;

                }

            }

            for (int li = 0; li < 5; li++)
            {

                for (int c = 0; c < 5; c++)
                {

                    Console.Write(matriz3[li, c] + "");

                }
                Console.Write("\n");
            }


            Console.Write("---------------");
            Console.Write("\n");


            int[,] matriz33 = new int[3, 3];

            for (int li = 0; li < 3; li++)
            {

                for (int c = 0; c < 3; c++)
                {

                    if (li == 0)
                    {
                        matriz33[li, c] = 0;
                    }
                    else if (li == 1)
                    {
                        matriz33[li, c] = 1;
                    }
                    else if (li == 2)
                    {
                        matriz33[li, c] = 2;
                    }

                }

            }

            for (int li = 0; li < 3; li++)
            {

                for (int c = 0; c < 3; c++)
                {

                    Console.Write(matriz33[li, c] + "");

                }
                Console.Write("\n");
            }
            


            Console.ReadKey();
        }
    }
}
