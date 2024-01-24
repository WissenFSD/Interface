using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interface_Coklu_Interface_
{
    // bir sınıf birden fazla interface'i implement edebilir. 

    // Implement edilen örnekler arasında virgül olacak şekilde yazılmalıdır.
    public class Tasit : ITasit, IKaraTasiti
    {
        public string Name { get; set; }

        public void EnerjiTipi()
        {
            Console.WriteLine("Eneji tipi benzin");
        }

        public void TekerlekSayisi()
        {
            Console.WriteLine("6 tekerlek");
        }
    }
    public class Tasit2 : ITasit, IHavaTasiti
    {
        public void EnerjiTipi()
        {
            Console.WriteLine("Uçak yakıtı");
        }

        public void MaxIrtifa()
        {
            Console.WriteLine("11000 km");
        }
    }

    public interface IKaraTasiti
    {
        public void TekerlekSayisi();
       
    }
    public interface ITasit
    {

        public void EnerjiTipi();
        
    }
    public interface IHavaTasiti
    {
        public void MaxIrtifa();
        
    }
}
