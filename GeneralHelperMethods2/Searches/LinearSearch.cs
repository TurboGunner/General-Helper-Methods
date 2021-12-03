using System.Collections.Generic;

namespace GeneralHelperMethods.Searches
{
    public class LinearSearch<T> : Search<T>
    {
        public override int SearchList(T target)
        {
            return list.IndexOf(target);
        }

        public override int SearchList(List<T> l, T target)
        {
            list = l;
            return list.IndexOf(target);
        }
    }
}
