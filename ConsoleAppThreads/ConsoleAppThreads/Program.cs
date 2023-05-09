using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppThreads
{
    internal class Program
    {
        static int a_row, a_column, b_row, b_column, i, j;
        static int[,] Matrix_a, Matrix_b;

        static void GenerateMatrices()
        {
            Console.WriteLine("\nPodaj liczbe wierszy macierzy A: ");
            a_row = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPodaj liczbe kolumn macierzy A: ");
            a_column = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPodaj liczbe wierszy macierzy B: ");
            b_row = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPodaj liczbe kolumn macierzy B: ");
            b_column = int.Parse(Console.ReadLine());

            if (a_column != b_row)
            {
                Console.Write("Mnozenie takich macierzy jest niemozliwe. Podaj rozmiary w postaci: A: mxn, B: nxl\n");
                GenerateMatrices();
            }
            else
            {
                Matrix_a = new int[a_row, a_column];
                Matrix_b = new int[b_row, b_column];

                for(i = 0; i < a_row; i++) 
                {
                    Console.WriteLine("\n");
                    for(j=0; j < a_column; j++)
                    {
                        Matrix_a[i, j] = j + 1 + i;           // Kazdy element macierzy wynosi: numer kolumny elementu + 1 + numer wierszu, w ktorym znajduje sie element,
                        Console.Write(Matrix_a[i, j] + "\t"); // przy czym numerowanie kolumn i wierszy zaczyna sie od 0!!!
                    }
                }

                Console.WriteLine("\n");

                for (i = 0; i < b_row; i++)
                {
                    Console.WriteLine("\n");
                    for (j = 0; j < b_column; j++)
                    {
                        Matrix_b[i, j] = j + 1 + i;           // Kazdy element macierzy wynosi: numer kolumny elementu + 1 + numer wierszu, w ktorym znajduje sie element,
                        Console.Write(Matrix_b[i, j] + "\t"); // przy czym numerowanie kolumn i wierszy zaczyna sie od 0!!!
                    }
                }


            }
        }


        static void Main(string[] args)
        {

            GenerateMatrices();
            Test test = new Test();




            Console.Read();

        }
        public class Test
        {

        }
    }
}
