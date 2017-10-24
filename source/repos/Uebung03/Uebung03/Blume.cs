using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung03
{
    public class Blume : Pflanze
    {
        public Blume(String name, double höhe, EBodenart bodenart, EFarbe farbe) : base (name, höhe, bodenart, farbe)
        {
            if (farbe == EFarbe.grün)
                throw new NotSupportedException("Es gibt keine grünen Blumen.");
        }

        public new int Farbe()
        {
            return base.Farbe;
        }

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
