using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung03
{
    public abstract class Pflanze : IComparable
    {
        private string name;
        private double höhe;

        private readonly int bodenart;
        private readonly int farbe;

        public Pflanze(string name, double höhe, EBodenart bodenart, EFarbe farbe)
        {
            this.name = name;
            this.höhe = höhe;
            this.bodenart = (int) bodenart;
            this.farbe = (int)farbe;
        }

        public enum EFarbe
        {
            rot = 0,
            gelb = 1,
            weiß = 2,
            orange = 3,
            grün = 4          
        }

        public enum EBodenart
        {
            Sand = 0,
            Lehm = 1,
            Humus = 2
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Höhe
        {
            get { return höhe; }
            set { höhe = value; }
        }

        public int Bodenart
        {
            get { return bodenart; }
        }

        public int Farbe
        {
            get { return farbe; }
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            return Equals(obj);
        }

        public int CompareTo(Object obj)
        {
            Pflanze pfl = (Pflanze)obj;
            return Höhe.CompareTo(pfl.Höhe);
        }
    }
}
