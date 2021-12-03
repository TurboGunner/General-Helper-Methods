using GeneralHelperMethods.Abstracts;
using GeneralHelperMethods.Sorts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneralHelperMethods.Searches
{
    public class BinarySearch<T> : Search<T> where T : IComparable<T>
    {
        public enum SortType { Merge, Quick, Insert }

        public static SortType type = SortType.Merge;
        public bool sortIfExceptional;

        public BinarySearch(bool s = true)
        {
            sortIfExceptional = s;
        }

        public override int SearchList(T target)
        {
            int output = Search(list, 0, list.Count() - 1, target);
            if (output == -1 && sortIfExceptional)
            {
                SortIfExceptional(list);
            }
            return output;
        }

        public override int SearchList(List<T> l, T target)
        {
            list = l;
            int output = Search(list, 0, list.Count() - 1, target);
            if (output == -1)
            {
                SortIfExceptional(list);
            }
            return output;
        }

        public void SortIfExceptional(List<T> l)
        {
            Sort<T> sort;
            if (type.Equals(SortType.Merge))
            {
                sort = new MergeSort<T>();
            }
            else if (type.Equals(SortType.Quick))
            {
                sort = new QuickSort<T>();
            } 
            else
            {
                sort = new InsertionSort<T>();
            }
            sort.SortList(l);
        }

        private int Search(List<T> l, int begin, int end, T target)
        {
            if (begin > end) //Base-Case
            {
                return -1;
            }

            int midpoint = (begin + end) / 2;
            T mpValue = l[midpoint];

            if (target.Equals(mpValue))
            {
                return midpoint;
            }
            else if (target.CompareTo(mpValue) > 0)
            {
                return Search(l, midpoint + 1, end, target);
            }
            else if (target.CompareTo(mpValue) < 0)
            {
                return Search(l, begin, midpoint + 1, target);
            }
            return -1;
        }
    }
}