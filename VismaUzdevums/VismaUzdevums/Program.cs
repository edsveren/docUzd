using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace VismaUzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Input document number:");
            string nr = Console.ReadLine();
            //Rinda[] rin = new Rinda[n];
            List<Rinda> list = new List<Rinda>();
            //Dokument doc = new Dokument(nr, rin);

            //int kSum = 0;
            //while (kSum < Dokument.maxSumma)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine("Input next Line Code:");
            //        string code = Console.ReadLine();
            //        Console.WriteLine("Input next line Sum:");
            //        int maxSumLimit = Dokument.maxSumma / 3;
            //        int sum = rnd.Next(1, (maxSumLimit + 1));
            //        Console.WriteLine(sum);
            //        rin[i] = new Rinda(code, sum);

            //        list.Add(rin[i]);
            //        kSum = kSum + sum;
            //    }
            //}

            Dokument doc = new Dokument(nr, list);

            int kSum = 0;
            int j = 0;
            while (kSum < Dokument.maxSumma)
            {
                Console.WriteLine("Input " + (j + 1) + ". line Code:");
                string code = Console.ReadLine();
                Console.WriteLine("Input " + (j + 1) + ". line Sum:");
                int maxSumLimit = Dokument.maxSumma / 3;
                int sum = rnd.Next(1, (maxSumLimit + 1));
                Console.WriteLine(sum);
                Rinda rin = new Rinda(code, sum);
                list.Add(rin);
                kSum = kSum + sum;
                j++;

            }

            //doc.printDoc(kSum, list);

            doc.printDocus(kSum);


        }
    }



}
