using Sistem;
using Sistem.Collection;
using Sistem.Ling;
using Sistem.Text;
using Sistem.Therading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main (string[]args)
        {
            Taxi satu = new Taxi();
            Taxi dua = new Taxi();

            satu.Nama = "Angga";
            satu.Duty = true;
            satu.Passanger = 10;

            dua.Nama = "Arya";
            dua.Duty = false;
            dua.Passenger = 10;

            satu.Detail();
            satu.Picup();
            saru.Dropoff();

            dua.Detail();
            dua.Pickup();
            dua.Dropoff();

            Console.ReadKey();

        }
    }
}
