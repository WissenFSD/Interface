namespace Interface_Ornek_
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
            static void Uctu(IUcabilir ucabilir)
            {
                ucabilir.Uc();


            }
            static void UctuClass(IUcabilir ucabilir)
            {
                if(ucabilir is Martı)
                {
                    Martı marti = (Martı)ucabilir;
                }
                else if(ucabilir is Karga)
                {
                    Karga karga = (Karga)ucabilir;
                }
                else if(ucabilir is Saka)
                {
                    Saka saka = (Saka)ucabilir;
                    saka.Surun();
                }
            }

        }
    }
}