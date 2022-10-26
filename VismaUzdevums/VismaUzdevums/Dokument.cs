using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaUzdevums
{
    public class Dokument
    {
        private string numurs;
        public static int maxSumma = 100;
        private DateTime datums;
        //private Rinda[] rindas;
        private List<Rinda> rindas;

        //public Dokument(string aNumurs, Rinda[] aRindas)
        //{
        //    Numurs = aNumurs;
        //    Rindas = aRindas;
        //}

        public Dokument(string aNumurs, List<Rinda> aList)
        {
            Numurs = aNumurs;
            Rindas = aList;
        }

        public string Numurs
        {
            get { return numurs; }
            set { numurs = value; }
        }

        public DateTime Datums
        {
            get { return datums; }
            set { datums = value; }
        }

        //public Rinda[] Rindas
        //{
        //    get { return rindas; }
        //    set { rindas = value; }
        //}

        public List<Rinda> Rindas
        {
            get { return rindas; }
            set { rindas = value; }
        }

        

        static DateTime GetNextWeekday()
        {
            DayOfWeek d = DayOfWeek.Monday;
            DateTime result = DateTime.Now.AddDays(1);
            while (result.DayOfWeek != d)
                result = result.AddDays(1);
            return result;
        }

        //public void printDoc(int kSum, List<Rinda> list)
        //{
        //    Console.WriteLine();
        //    Datums = GetNextWeekday();
        //    string dts = Datums.ToShortDateString();
        //    Console.WriteLine("Datums: " + dts);

        //    Console.WriteLine("Dokumenta nr: " + Numurs);

        //    double maxSummaD = (double)maxSumma;
        //    Console.WriteLine("Maksimālā summa: " + maxSummaD.ToString("F2") + " EUR");

        //    int lin = 0;
        //    Console.WriteLine("Rindas: ");
        //    int notS = 0;
        //    foreach (Rinda rinda in list)
        //    {
        //        double rinSD = (double)rinda.Summa;
        //        Console.WriteLine("\t" + rinda.Kods + "  " + rinSD.ToString("F2") + " EUR" + ";");
        //        lin++;
        //        notS = rinda.Summa;
        //    }
            
        //    Console.WriteLine("Rindu skaits: " + lin);

        //    double kSumD = (double)kSum;
        //    double notSD = (double)notS;

        //    Console.WriteLine(("Kopējā summa: " + (kSum - notSD).ToString("F2") + " EUR"));

        //    Console.WriteLine("Nepievienotā summa: " + notS.ToString("F2") + " EUR");

        //    Console.WriteLine("Pārsniegtā summa: " + kSumD.ToString("F2") + " EUR");
        //}

        public void printDocus(int kSum)
        {
            Console.WriteLine();
            Datums = GetNextWeekday();
            string dts = Datums.ToShortDateString();
            Console.WriteLine("Datums: " + dts);

            Console.WriteLine("Dokumenta nr: " + Numurs);

            double maxSummaD = (double)maxSumma;
            Console.WriteLine("Maksimālā summa: " + maxSummaD.ToString("F2") + " EUR");

            int lin = 0;
            Console.WriteLine("Rindas: ");
            int notS = 0;
            foreach (Rinda rinda in Rindas)
            {
                double rinSD = (double)rinda.Summa;
                Console.WriteLine("\t" + rinda.Kods + "  " + rinSD.ToString("F2") + " EUR" + ";");
                lin++;
                notS = rinda.Summa;
            }

            Console.WriteLine("Rindu skaits: " + lin);

            double kSumD = (double)kSum;
            double notSD = (double)notS;

            Console.WriteLine(("Kopējā summa: " + (kSum - notSD).ToString("F2") + " EUR"));

            Console.WriteLine("Nepievienotās rindas summa: " + notS.ToString("F2") + " EUR");

            Console.WriteLine("Pārsniegtā summa: " + kSumD.ToString("F2") + " EUR");
        }
    }
}
