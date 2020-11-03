using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiere kortene
            VISAElectron ve = new VISAElectron("Christian Bøgh");
            VISA v = new VISA("Christian Bøgh");
            Mastercard mas = new Mastercard("Christian Bøgh");
            Maestro mae = new Maestro("Christian Bøgh");
            DebitCard d = new DebitCard("Christian Bøgh");

            //Udskriver ToString metoden
            Console.WriteLine(ve.ToString());
            Console.WriteLine(v.ToString());
            Console.WriteLine(mas.ToString());
            Console.WriteLine(mae.ToString());
            Console.WriteLine(d.ToString());

            //Pauser koden og venter på klikket på en tast
            Console.ReadKey();
        }
    }
}
