using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interface_Örnek3_
{

    public interface IArrayHelper
    {
        public string[] Reverse(string[] array);
        public int Length(int[] array);

        public void IsDigit(string[] array);
        public string[] Copy(string[] array);

        public object[] ToArray(ArrayList list);





    }
    public class ArrayHelper : IArrayHelper
    {
        public string[] Copy(string[] array)
        {

            string[] copiedArray = new string[array.Length];
            Array.Copy(array, copiedArray, array.Length);
            return copiedArray; 
        }

        public void IsDigit(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsDigit(array[i], 0))
                {

                    Console.WriteLine("{0} bir rakamdır", array[i]);
                }




            }
        }

        public int Length(int[] array)
        {
            return array.Length;
        }

        public string[] Reverse(string[] array)
        {
            string[] reversedArray = new string[array.Length];

            int index = 0;
            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[index] = array[i];
                index++;
            }

            return reversedArray;
        }

        public object[] ToArray(ArrayList list)
        {
            return list.ToArray();
        }
    }
}
