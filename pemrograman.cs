using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class pemrograman
    {
        static void Main(string[] args)
        {


            Taxi taxi = new Taxi();
            Taxi taxi1 = new Taxi();

            taxi.DriverName = "fahmi";
            taxi.OnDuty = true;
            taxi.NumPassenger = 2845633;

            taxi1.DriverName = "Budi";
            taxi1.OnDuty = true;
            taxi1.NumPassenger = 4745777;

            taxi.info();
            taxi.ada();
            taxi.Tidak();

            taxi1.info();
            taxi1.ada();
            taxi1.Tidak();

            Console.ReadKey();
        }
    }
}
