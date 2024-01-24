using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek_
{
    public class Saka : IUcabilir
    {
        public void Kon()
        {
            Console.WriteLine("Saka konabilir");
        }

        public void Uc()
        {
            Console.WriteLine("Saka uçabilir");
        }
        public void Surun()
        {
            Console.WriteLine("Süründü");
        }
    }
    public class Karga : IUcabilir
    {
        public void Kon()
        {
            Console.WriteLine("Karga kondu");
        }

        public void Uc()
        {
            Console.WriteLine("Karga uçtu");
        }
    }
    public class Martı : IUcabilir
    {
        public void Kon()
        {
            Console.WriteLine("Martı kondu");
        }

        public void Uc()
        {
          Console.WriteLine("Martı uctu");
        }
    }
}
