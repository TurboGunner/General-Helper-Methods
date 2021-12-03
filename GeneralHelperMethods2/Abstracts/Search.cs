using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralHelperMethods
{
    public abstract class Search<T>
    {
        public List<T> list { get; set; }
        public Search()
        {
            list = new List<T>();
        }
        public Search(params T[] items)
        {
            foreach (T item in items)
            {
                list.Add(item);
            }
        }
        public abstract int SearchList(T target);
        public abstract int SearchList(List<T> list, T target);
    }
}