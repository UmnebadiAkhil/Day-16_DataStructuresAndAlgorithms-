using System;

namespace DataStructure_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DataStructure_Algorithms");

            bool flag = true;
            while (true)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1.Palidrome \n 2.Pattern \n 3.Annagram \n 4.BubbleSort \n 5.InsertionSort, \n 6.Stopwatch Program, \n 7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Palidrome.CheckNumberPalidrome();

                        break;
                    case 2:
                        Pattern.SolidRectangle();
                        Pattern.HollowRectangle();
                        Pattern.HalfPyramid();
                        Pattern.InvertedHalfPyramid();
                        Pattern.InvertedRotateHalfPyramid();
                        Pattern.HalfPyramidWithNumbers();
                        Pattern.InvertedHalfPyramidWithNumbers();
                        Pattern.FloydsTriangle();
                        Pattern.TriangleWithBinaryValues();
                        break;
                    case 3:
                        Annagram.Anagram1();
                        break;
                    case 4:
                        BubbleSort.bubble();
                        break;
                    case 5:
                        InsertionSort.Sortedlist();
                        break;
                }
            }
        }
    }
}