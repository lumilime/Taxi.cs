using Sistem;
using Sistem.Collection;
using Sistem.Ling;
using Sistem.Text;
using Sistem.Therading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        public string Nama{get; set;}
        public bool Dutyc{get; set;}
        public int Passanger {get; set;}

        public void Detail()
        {
            Console.WriteLine("Driver Name {0}", Nama);
            Console.WriteLine("On Duty {0}", Duty);
            Console.WriteLine("Number of Passanger {0}", Passanger);

        }
        public void Pickup()
        {
            
            Console.WriteLine("sedang menjemput penumpang {0}", Nama);

        }
        public void Dropoff()
        {

            Console.WriteLine("selesai mengantar penumpang {0}", Nama);
       
        }
        
    }


}