using GeneralHelperMethods.Abstracts;
using System;
using System.Collections.Generic;

namespace GeneralHelperMethods.Sorts
{
    public class QuickSort<T> : Sort<T> where T : IComparable<T>
    {
        public enum PivotPoint {Left, MidPoint, Right}
        public override void SortList()
        {
            list = RecursiveLogic(list);
        }

        public override void SortList(List<T> l)
        {
            list = l;
            list = RecursiveLogic(list);
        }

        private List<T> RecursiveLogic(List<T> l, PivotPoint p = PivotPoint.MidPoint)
        {
            List<T> output = new List<T>();
            if (l.Count <= 1) //Base case for recursion
            {
                return l;
            }

            T pivot = l[Pivot(l, p)];
            List<T> less, equalTo, greater;

            less = l.FindAll(s => s.CompareTo(pivot) < 0);
            equalTo = l.FindAll(s => s.CompareTo(pivot) == 0);
            greater = l.FindAll(s => s.CompareTo(pivot) > 0);

            output.AddRange(RecursiveLogic(less));
            output.AddRange(equalTo);
            output.AddRange(RecursiveLogic(greater));

            return output;
        }

        private int Pivot(List<T> l, PivotPoint p)
        {
            if (p == PivotPoint.MidPoint)
            {
                return l.Count / 2;
            }
            if (p == PivotPoint.Left)
            {
                return 0;
            }
            else
            {
                return l.Count - 1;
            }
        }
    }
}