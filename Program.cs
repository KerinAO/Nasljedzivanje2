using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedzivanje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            trokut.UcitajStranice();
            Console.WriteLine("Opseg trokuta je: {0}", trokut.Opseg());

            Cetverokut cetverokut = new Cetverokut();
            cetverokut.UcitajStranice();
            Console.WriteLine("Opseg cetverokuta je: {0}", cetverokut.Opseg());

            Console.ReadKey();
        }
    }

    class GeometrijskiLik
    {
        protected int BrojStranica;
        protected double[] stranice = new double[10];

        public void UcitajStranice()
        {
            for(int i = 0; i < BrojStranica; i++)
            {
                Console.WriteLine("Upiši duljinu {0}. stranice", i + 1);
                string s = Console.ReadLine();
                stranice[i] = Convert.ToDouble(s);
            }
        }

        public double Opseg()
        {
            double opseg = 0;
            for(int i = 0; i < BrojStranica; i++)
            {
                opseg += stranice[i];
            }
            return opseg;
        }
    }

    class Trokut : GeometrijskiLik
    {
        public Trokut()
        {
            BrojStranica = 3;
        }

    }

    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut()
        {
            BrojStranica = 4;
        }
    }
}
