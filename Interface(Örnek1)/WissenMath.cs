using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Örnek1_
{

    public interface IWissenMath
    {

        public int Topla(int a, int b);
        public int Bol(int a, int b);
        public int Carp(int a, int b);
        public int Cikar(int a, int b);
        
    }
    public class WissenMath : IWissenMath
    {
        public int Bol(int a, int b)
        {
            return a / b;
        }

        public int Carp(int a, int b)
        {
            return a * b;
        }

        public int Cikar(int a, int b)
        {
            return a - b;
        }

        public int Topla(int a, int b)
        {
            return a + b;
        }
    }
}