using System;
using System.IO;

namespace Sudoku1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //linhas
            int[] sudoku =  { 1, 3, 2, 5, 7, 9, 4, 6, 8 };
            int[] sudoku1 = { 4, 9, 8, 2, 6, 1, 3, 7, 5 };
            int[] sudoku2 = { 7, 5, 6, 3, 8, 4, 2, 1, 9 };
            int[] sudoku3 = { 6, 4, 3, 1, 5, 8, 7, 9, 2 };
            int[] sudoku4 = { 5, 2, 1, 7, 9, 3, 8, 4, 6 };
            int[] sudoku5 = { 9, 8, 7, 4, 2, 6, 5, 3, 1 };
            int[] sudoku6 = { 2, 1, 4, 9, 3, 5, 6, 8, 7 };
            int[] sudoku7 = { 3, 6, 5, 8, 1, 7, 9, 2, 4 };
            int[] sudoku8 = { 8, 7, 9, 6, 4, 2, 1, 5, 3 };

            //colunas
            int[] sudoku9 = { 1, 4, 7, 6, 5, 9, 2, 3, 8 };
            int[] sudoku10 = { 3, 9, 5, 4, 2, 8, 1, 6, 7 };
            int[] sudoku11 = { 2, 8, 6, 3, 1, 7, 4, 5, 9 };
            int[] sudoku12 = { 5, 2, 3, 1, 7, 4, 9, 8, 6 };
            int[] sudoku13 = { 7, 6, 8, 5, 9, 2, 3, 1, 4 };
            int[] sudoku14 = { 9, 1, 4, 8, 3, 6, 5, 7, 2 };
            int[] sudoku15 = { 4, 3, 2, 7, 8, 5, 6, 9, 1 };
            int[] sudoku16 = { 6, 7, 1, 9, 4, 3, 8, 2, 5 };
            int[] sudoku17 = { 8, 5, 9, 2, 6, 1, 7, 4, 3 };

            //quadrinhos
            int[] sudoku18 = { 1, 3, 2, 4, 9, 8, 7, 5, 6 };
            int[] sudoku19 = { 5, 7, 9, 2, 6, 1, 3, 8, 4 };
            int[] sudoku20 = { 4, 6, 8, 3, 7, 5, 2, 1, 9 };
            int[] sudoku21 = { 6, 4, 3, 5, 2, 1, 9, 8, 7 };
            int[] sudoku22 = { 1, 5, 8, 7, 9, 3, 4, 2, 6 };
            int[] sudoku23 = { 7, 9, 2, 8, 4, 6, 5, 3, 1 };
            int[] sudoku24 = { 2, 1, 4, 3, 6, 5, 8, 7, 9 };
            int[] sudoku25 = { 9, 3, 5, 8, 1, 7, 6, 4, 2 };
            int[] sudoku26 = { 6, 8, 7, 9, 2, 4, 1, 5, 3 };

            bool repetidos = false;
            for (var x = 0; x < sudoku.Length; x++)
            {
                int a = sudoku[x];
                int c = x + 1;
                for (int y = c; y < sudoku.Length; y++)
                {
                    int b = sudoku[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku1.Length; x++)
            {
                int a = sudoku1[x];
                int c = x + 1;
                for (int y = c; y < sudoku1.Length; y++)
                {
                    int b = sudoku1[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku.Length; x++)
            {
                int a = sudoku2[x];
                int c = x + 1;
                for (int y = c; y < sudoku2.Length; y++)
                {
                    int b = sudoku2[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku3.Length; x++)
            {
                int a = sudoku3[x];
                int c = x + 1;
                for (int y = c; y < sudoku3.Length; y++)
                {
                    int b = sudoku3[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku4.Length; x++)
            {
                int a = sudoku4[x];
                int c = x + 1;
                for (int y = c; y < sudoku4.Length; y++)
                {
                    int b = sudoku4[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku5.Length; x++)
            {
                int a = sudoku5[x];
                int c = x + 1;
                for (int y = c; y < sudoku5.Length; y++)
                {
                    int b = sudoku5[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku6.Length; x++)
            {
                int a = sudoku6[x];
                int c = x + 1;
                for (int y = c; y < sudoku6.Length; y++)
                {
                    int b = sudoku6[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku7.Length; x++)
            {
                int a = sudoku7[x];
                int c = x + 1;
                for (int y = c; y < sudoku7.Length; y++)
                {
                    int b = sudoku7[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku8.Length; x++)
            {
                int a = sudoku8[x];
                int c = x + 1;
                for (int y = c; y < sudoku8.Length; y++)
                {
                    int b = sudoku8[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku9.Length; x++)
            {
                int a = sudoku9[x];
                int c = x + 1;
                for (int y = c; y < sudoku9.Length; y++)
                {
                    int b = sudoku9[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku10.Length; x++)
            {
                int a = sudoku10[x];
                int c = x + 1;
                for (int y = c; y < sudoku10.Length; y++)
                {
                    int b = sudoku10[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku11.Length; x++)
            {
                int a = sudoku11[x];
                int c = x + 1;
                for (int y = c; y < sudoku11.Length; y++)
                {
                    int b = sudoku11[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku12.Length; x++)
            {
                int a = sudoku12[x];
                int c = x + 1;
                for (int y = c; y < sudoku12.Length; y++)
                {
                    int b = sudoku12[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku13.Length; x++)
            {
                int a = sudoku13[x];
                int c = x + 1;
                for (int y = c; y < sudoku13.Length; y++)
                {
                    int b = sudoku13[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku14.Length; x++)
            {
                int a = sudoku14[x];
                int c = x + 1;
                for (int y = c; y < sudoku14.Length; y++)
                {
                    int b = sudoku14[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku15.Length; x++)
            {
                int a = sudoku15[x];
                int c = x + 1;
                for (int y = c; y < sudoku15.Length; y++)
                {
                    int b = sudoku15[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku16.Length; x++)
            {
                int a = sudoku16[x];
                int c = x + 1;
                for (int y = c; y < sudoku16.Length; y++)
                {
                    int b = sudoku16[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku17.Length; x++)
            {
                int a = sudoku17[x];
                int c = x + 1;
                for (int y = c; y < sudoku17.Length; y++)
                {
                    int b = sudoku17[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku18.Length; x++)
            {
                int a = sudoku18[x];
                int c = x + 1;
                for (int y = c; y < sudoku18.Length; y++)
                {
                    int b = sudoku18[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku19.Length; x++)
            {
                int a = sudoku19[x];
                int c = x + 1;
                for (int y = c; y < sudoku19.Length; y++)
                {
                    int b = sudoku19[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku20.Length; x++)
            {
                int a = sudoku20[x];
                int c = x + 1;
                for (int y = c; y < sudoku20.Length; y++)
                {
                    int b = sudoku20[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku21.Length; x++)
            {
                int a = sudoku21[x];
                int c = x + 1;
                for (int y = c; y < sudoku21.Length; y++)
                {
                    int b = sudoku21[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku22.Length; x++)
            {
                int a = sudoku22[x];
                int c = x + 1;
                for (int y = c; y < sudoku22.Length; y++)
                {
                    int b = sudoku22[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku23.Length; x++)
            {
                int a = sudoku23[x];
                int c = x + 1;
                for (int y = c; y < sudoku23.Length; y++)
                {
                    int b = sudoku23[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku24.Length; x++)
            {
                int a = sudoku24[x];
                int c = x + 1;
                for (int y = c; y < sudoku24.Length; y++)
                {
                    int b = sudoku24[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku25.Length; x++)
            {
                int a = sudoku25[x];
                int c = x + 1;
                for (int y = c; y < sudoku25.Length; y++)
                {
                    int b = sudoku25[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }
            for (var x = 0; x < sudoku26.Length; x++)
            {
                int a = sudoku26[x];
                int c = x + 1;
                for (int y = c; y < sudoku26.Length; y++)
                {
                    int b = sudoku26[y];
                    if (a == b)
                    {
                        //se tiver numero repetidos não é sudoku!
                        repetidos = true;
                        Console.WriteLine("NÃO!");
                        Console.ReadLine();
                    }
                }
            }

            if (repetidos == false)
            {
                //se não tiver repetidos, ele é sudoku!
                Console.WriteLine("SIM!");
                Console.ReadLine();
            }
        }
    }
}
