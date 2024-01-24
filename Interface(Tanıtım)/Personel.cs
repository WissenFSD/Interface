using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Tanıtım_
{


    // Interface sınıflara rehberlik etmesi için vardır.


    // Interface içerisinde metotların imzaları olur gövdeleri olmaz.


    // Interface tanımlarken interface'nin adının I ile başlaması genel kabul görmüş bir kuraldır.
    public interface IPersonel
    {
        public void Calis();
        public void IzınYap();

        public int Topla(int a, int b);

    }


    // Interface implementasyonu aşağıdaki şekilde yapılmaktadır.


    // bir sınıf birden fazla interface implement edebilir


    // Interface'nin içerisinde taşıdığı metot imzaları, interface'e implement olan sınıflar içerisine kopyalanır. Gövdeleri boştur çünkü gövdeler implement edilen sınıf içerisinde doldurulacaktır.
    public class Personel : IPersonel
    {
        public string Name { get; set; }

        public void Calis()
        {
            Console.WriteLine("Çalışıldı");
        }

        public void IzınYap()
        {
            Console.WriteLine("İzin yapıldı");
        }

        public int Topla(int a, int b)
        {
            return a + b;
        }


        
        // Bu metot interfaceden gelmemektedir. Bu durumda bir sorun oluşmayacaktır.

        // 
        public void SelamVer()
        {

            Console.WriteLine("Selam");
        }
    }
}
