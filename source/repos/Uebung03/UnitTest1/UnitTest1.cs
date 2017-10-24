using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Uebung03; 

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Pflanze> liste = new List<Pflanze>();

            Blume b1 = new Blume("Gänseblümchen", 1.22, Pflanze.EBodenart.Humus, Pflanze.EFarbe.weiß);
            Blume b2 = new Blume("Rose", 3.1, Pflanze.EBodenart.Sand, Pflanze.EFarbe.rot);
            Blume b3 = new Blume("Tulpe", 2.2, Pflanze.EBodenart.Lehm, Pflanze.EFarbe.orange);
            Blume b4 = new Blume("Gras", 0.8, Pflanze.EBodenart.Humus, Pflanze.EFarbe.weiß);

            Strauch s1 = new Strauch("Dornbusch", 3.3, Pflanze.EBodenart.Humus);
            Strauch s2 = new Strauch("Busch", 2.2, Pflanze.EBodenart.Sand);

            Pflanze[] array = { b1, b2, b3, b4, s1, s2 };

            liste.Add(b1);
            liste.Add(b2);
            liste.Add(b3);
            liste.Add(b4);

            liste.Add(s1);
            liste.Add(s2);

            Console.WriteLine("Vor der Sortierung nach Höhe:");
            foreach(Pflanze p in array)
            {
                Console.WriteLine(p.Höhe);
            }           

            Console.WriteLine("Liste nach der Sortierung nach Höhe");
            PflanzenUtil.SortByHeight(array);
            foreach(Pflanze p in array)
            {
                Console.WriteLine(p.Höhe);
            }

            Console.WriteLine("Liste nach der Sortierung nach Boden");
            PflanzenUtil.SortByBoden(liste);
            foreach(Pflanze p in liste)
            {
                Console.WriteLine(p.Bodenart);
            }
        }
    }
}
