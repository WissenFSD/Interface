namespace Interface_Ornek_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu örnekte interfacelerin bir özelliğini daha görmüş ve deneyimlemiş olduk.

            //Önemli Not :  Interfaceler sınıfları temsil ederler.

            //Martı m = new Martı();
            //MartıUctu(m);

            //Saka s = new Saka();
            //Uctu(s);


            //Uctu(new Martı());
            //Uctu(new Karga());



            UctuClass(new Martı());

            static void MartıUctu(Martı m)
            {
                m.Uc();
            }
            static void KargaUctu(Karga k)
            {

            }
            static void SakaUctu(Saka s)
            {


            }


            // bu metodua interface parametre aldık. Bu metoda IUcabilir interfacesini imptlemet eden sınıflar parametre olarak gelebilir.
            // bu metoda uctu interfacesini implement eden tüm sınıflar parametre olarak gelebilir. Ancak interface ile gelen metot değilde
             // sınıfın kendine ait bir metodu var ise bu metot içerisinden o metot çalıştırılamaz.
             // Ornegin saka sınıfında Surun adında bir metot var ise o metota aşağıdaki metot içerisinden yani interface üzerinden erişemez.
            static void Uctu(IUcabilir ucabilir)
            {
                ucabilir.Uc();


            }
            static void UctuClass(IUcabilir ucabilir)
            {

                // is keyword'ü, parametre olarak gelen interface nesnesinin martı nesnesi olup olmadığını kontrol etmekdir. is keyword'ünden geriye true yada false değer dönecektir.
                if(ucabilir is Martı)
                {

                    // is keyword'ünden geriye true geldiğinde, ucabilir denen nesne Martı nesnesine dönüştürüldü.

                    // Bu aşamada, martı nesnesi içerisinde interface ile gelmeyen metotlara erişim sağlanabilir.
                    // Çünkü artık interface üzerinden değil, nesne üzerinden erişim yapılmaktadır.
                    Martı marti = (Martı)ucabilir;
                }
                else if(ucabilir is Karga)
                {
                    Karga karga = (Karga)ucabilir;
                }
                else if(ucabilir is Saka)
                {

                    // Interface'de olmayan sürün metodu aşağıdaki gibi kullanılmıştır.
                    Saka saka = (Saka)ucabilir;
                    saka.Surun();
                }
            }

        }
    }
}