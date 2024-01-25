using Interface_Örnek1_;

namespace Interface_Örnek3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StringHelper helper =new StringHelper();


           string upperString = helper.ToUpper("ben bir yazıyım");
            Console.WriteLine(upperString);


           string[] splitted= helper.Split("ben uzun bir yazıyım");
            foreach(string s in splitted)
            {
                Console.WriteLine(s);
            }


          string reverseString =   helper.Reverse("beni ters çevir");
            Console.WriteLine(reverseString);


           string substrString =  helper.SubStr("bu yazı içerisinde bazı yerler kesilecek", 0, 10);
            Console.WriteLine(substrString);

          bool isStartWith =   helper.StartWith("bu yazı b harfi ile başlıyor mu ?", "c");
            Console.WriteLine(isStartWith);
        }
    }
}