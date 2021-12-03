using GeneralHelperMethods.Searches;
using GeneralHelperMethods.Sorts;
using System;
using System.Collections.Generic;

namespace GeneralHelperMethods
{
    public class Program
    {
        static List<int> list1 = new List<int>() { 2, 2, 3, 1, 1, 7 };
        static List<int> list2 = new List<int>() { 2, 4, 7, 3, 6, 9, 5, 1, 0 };
        public static void Main(string[] args)
        {
            MergeSortTest();
            QuickSortTest();
            InsertionSortTest();
            BinarySearchTest();

            Console.ReadLine();
        }

        public static void MergeSortTest()
        {
            MergeSort<int> sort = new MergeSort<int>();
            sort.SortList(list1);
            Console.WriteLine(sort.OutputList());
        }

        public static void QuickSortTest()
        {
            QuickSort<int> sort = new QuickSort<int>();
            sort.SortList(list2);
            Console.WriteLine(sort.OutputList());
        }

        public static void InsertionSortTest()
        {
            InsertionSort<int> sort = new InsertionSort<int>();
            sort.SortList(list2);
            Console.WriteLine(sort.OutputList());
        }

        public static void BinarySearchTest()
        {
            BinarySearch<int> search = new BinarySearch<int>();
            Console.WriteLine(search.SearchList(list2, 2));
        }
    }
}
