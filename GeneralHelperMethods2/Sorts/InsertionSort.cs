using GeneralHelperMethods.Abstracts;
using System;
using System.Collections.Generic;

namespace GeneralHelperMethods.Sorts
{
    public class InsertionSort<T> : Sort<T> where T : IComparable<T>
    {
        public override void SortList()
        {
            RecursiveLogic(list, list.Count);
        }

        public override void SortList(List<T> l)
        {
            list = l;
            RecursiveLogic(list, list.Count);
        }

        private void RecursiveLogic(List<T> l, int index)
        {
            if (index <= 1) //Base-case
            {
                return;
            }
            RecursiveLogic(l, index - 1);

            T lastElement = l[index - 1];
            int i;

            for (i = index - 2; i >= 0 && l[i].CompareTo(lastElement) > 0; i--)
            {
                l[i + 1] = l[i];
            }
            l[i + 1] = lastElement;
        }
    }
}
