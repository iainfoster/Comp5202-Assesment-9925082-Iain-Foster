using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp5202_Matrices__2d_array__9925082
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayA = new int[3, 3];
            int[,] arrayB = new int[3, 3];
            int[,] arrayC = new int[3, 3];

            
            Random rand = new Random();

            
            for (int i = 0; i < arrayA.GetLength(0); i++)//TO identify what row
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)//TO identify what column
                {
                    //Used to identify the coordanites in the arrays.
                    arrayA[i, j] = rand.Next(-10, 11);
                }
                Console.WriteLine();
            }
            //Display this arrayA
            Console.WriteLine("Random Numbers for arrayB:");
            DisplayA(arrayA);

            for (int i = 0; i < arrayB.GetLength(0); i++)//TO identify what row
            {
                for (int j = 0; j < arrayB.GetLength(1); j++)//TO identify what column
                {
                    //Used to identify the coordanites in the arrays.
                    arrayB[i, j] = rand.Next(-10, 11);
                }
                Console.WriteLine();
            }
            //Display this arrayB
            Console.WriteLine("Random Numbers for arrayB:");
            DisplayB(arrayB);

            Console.WriteLine("\nArrays added together to be made as arrayC:");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(arrayA[i, j] + arrayB[i, j] + "  ");
                }
                Console.WriteLine();
            }
            //Display this arrayC
            Console.WriteLine("Showing ArrayC:");
            DisplayB(arrayC);
        }

        public static void DisplayA(int[,] arr)
        {
            //for loop using the GetLength method.
            for (int i = 0; i < arr.GetLength(0); i++)//TO identify what row
            {
                for (int j = 0; j < arr.GetLength(1); j++)//TO identify what column
                {
                    //Used to identify the coordanites in the arrays.
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public static void DisplayB(int[,] arr)
        {
            
            for (int i = 0; i < arr.GetLength(0); i++)//TO identify what row
            {
                for (int j = 0; j < arr.GetLength(1); j++)//TO identify what column
                {
                    //Used to identifie the coordanites in the arrays.
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}

