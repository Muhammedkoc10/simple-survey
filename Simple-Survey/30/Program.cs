using System;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            int begenenSayi = 0, begenmeyenSayi = 0, kararsizSayi = 0, toplamSayi = 0;
            secim: Console.WriteLine("Ürünü beğendiyseniz 'e' Beğenmediyseniz 'h' kararsız kaldıysanız lütfen 'k tuşuna basınız'");
            char karar = Convert.ToChar(Console.ReadLine());

            if (karar == 'e' || karar== 'E')
            {
                toplamSayi = toplamSayi +1 ;
                begenenSayi = begenenSayi + 1;
                Console.WriteLine("Ankete tekrar katılmak için Y çıkmak için N'ye basınız");
                char sonkarar = Convert.ToChar(Console.ReadLine());
                if (sonkarar == 'Y' || sonkarar == 'y')
                {
                    goto secim;
                }
                else
                {
                    goto son;
                }

            }
            else if (karar == 'h' || karar == 'H')
            {
                toplamSayi = toplamSayi + 1;
                begenmeyenSayi = begenmeyenSayi + 1;
                Console.WriteLine("Ankete tekrar katılmak için Y çıkmak için N'ye basınız");
                char sonkarar = Convert.ToChar(Console.ReadLine());
                if (sonkarar == 'Y' || sonkarar == 'y')
                {
                    goto secim;
                }
                else
                {
                    goto son;
                }
            }
            else if (karar == 'k' || karar == 'K')
            {
                toplamSayi = toplamSayi + 1;
                kararsizSayi = kararsizSayi + 1;
                Console.WriteLine("Ankete tekrar katılmak için Y çıkmak için N'ye basınız");
                char sonkarar = Convert.ToChar(Console.ReadLine());
                if (sonkarar == 'Y' || sonkarar == 'y')
                {
                    goto secim;
                }
                else
                {
                    goto son;
                }
                
            }
            else
            {
                Console.WriteLine("Lütfen bu karakterlerden birini deneyeniz!");
                goto secim;
            }
            son:  Console.WriteLine("Kararsız sayı = "+kararsizSayi+ " Beğenen sayı =  "+ begenenSayi + "Beğenmeyen sayı = "+ begenmeyenSayi+ "Toplam sayı = "+ toplamSayi );
        }
    }
}
