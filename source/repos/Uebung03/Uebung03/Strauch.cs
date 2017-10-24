using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung03
{
    public class Strauch : Pflanze
    {
        public Strauch(string name, double höhe, EBodenart bodenart) : base(name, höhe, bodenart, EFarbe.grün) { }
        public override bool Equals(object obj)
        {
            return Equals(obj);
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
}
