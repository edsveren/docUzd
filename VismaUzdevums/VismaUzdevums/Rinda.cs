using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaUzdevums
{
    public class Rinda
    {
        private string kods;
        private int summa;
        public Rinda(string aKods, int aSumma)
        {
            Kods = aKods;
            Summa = aSumma;
        }

        public string Kods 
        {
            get { return kods; } 
            set { kods = value; } 
        }
        public int Summa
        {
            get { return summa; }
            set { summa = value; }
        }

        //public int kopSum(Rinda[] rin)
        //{
        //    int kSum = 0;
        //    foreach (Rinda r in rin)
        //    {
        //        kSum = kSum + Summa;
        //    }
        //    Console.WriteLine("Kopējā summa: " + kSum);
        //    return kSum;
        //}

        //public void printRinda()
        //{
        //    Console.WriteLine(Kods + " " + Summa);
        //}

    }
}
