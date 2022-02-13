using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithms
{
    internal class Pattern
    {
        public static void SolidRectangle()
        {
            Console.WriteLine("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of colonms:");
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void HollowRectangle()
        {
            Console.WriteLine("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of colonms:");
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (i == 1 || j == 1 || j == m || i == n)
                    {
                        Console.Write("*");
                    }   
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void HalfPyramid()
        {
            Console.WriteLine("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void InvertedHalfPyramid()
        {
            Console.WriteLine("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }

        public static void InvertedRotateHalfPyramid()
        {
            Console.WriteLine("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void HalfPyramidWithNumbers()
        {
            Console.WriteLine("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                    
                }
                Console.WriteLine();
            }
        }

        public static void InvertedHalfPyramidWithNumbers()
        {
            Console.WriteLine("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=n-i+1; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }
        }

        public static void FloydsTriangle()
        {
            Console.WriteLine("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            int number = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }

        public static void TriangleWithBinaryValues()
        {
            Console.WriteLine("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int sum = i+j;
                    if(sum % 2 == 0)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                  
                }
                Console.WriteLine();
            }
        }

        public static void SolidRhombus()
        {
          
            int n = 5;
          
            int m = 8;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (i == 1 || j == 1 || j == m || i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
