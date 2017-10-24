using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung03
{

    public class PflanzenUtil
    {
        public static Pflanze[] SortByHeight(Pflanze[] pflanzenArr)
        {
            Array.Sort(pflanzenArr, new ByHeight());
            return pflanzenArr;
        } 

        public static void SortByBoden(List<Pflanze> pflanzenList)
        {
            pflanzenList.Sort(new BodenComparer());
        }
        
        }
    public class ByHeight : IComparer<Pflanze>
    {
        public int Compare(Pflanze x, Pflanze y)
        {
            if (x.Höhe > y.Höhe)
                return 1;
            else if (x.Höhe == y.Höhe)
                return 0;
            else
                return -1;
        }
    }

}
