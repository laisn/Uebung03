using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung03
{
    public class BodenComparer : IComparer<Pflanze>
    {
        public int Compare(Pflanze x, Pflanze y)
        {
            Pflanze p1 = x;
            Pflanze p2 = y;

            return p1.Bodenart.CompareTo(p2.Bodenart);
        }
    }
}
