using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Örnek1_
{
    


    public interface IStringHelper
    {

        public bool StartWith(string data, string start);
        public string ToUpper(string data);
        public string Reverse(string data);

        public string[] Split(string data);


        public string SubStr(string data, int start, int end);

    }

    public class StringHelper : IStringHelper
    {
        public string Reverse(string data)
        {
            string reversedString = "";
            for (int i = data.Length - 1; i >= 0; i--)
            {
                reversedString += data[i];
            }
            return reversedString;
        }

        public string[] Split(string data)
        {
            return data.Split(' ');
        }

        public bool StartWith(string data, string start)
        {
            return data.StartsWith(start);
        }

        public string SubStr(string data, int start, int end)
        {
            return data.Substring(start, end);
        }

        public string ToUpper(string data)
        {
            return data.ToUpper();
        }
    }
}
