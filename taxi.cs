using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void info()
        {
            Console.WriteLine("\n Information Taxi \n");
            Console.WriteLine(" Nama Driver : {0}", DriverName);

            if (OnDuty == true)
            {
                Console.WriteLine(" Kerja : Iya", OnDuty);
            }
            else
            {
                Console.WriteLine(" Kerja : Tidak", OnDuty);
            }

            Console.WriteLine(" Nomor Pelanggan : {0}", NumPassenger);
        }

        public void ada()
        {
            Console.WriteLine(" {0} Maaf Sedang Ada Penumpang", DriverName);
        }
        public void Tidak()
        {
            Console.WriteLine(" {0} Sedang Tidak Ada Penumpang", DriverName);
        }
    }
}
