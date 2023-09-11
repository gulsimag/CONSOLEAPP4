using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {   int sayi1,sayi2,secim,sonuc;
            
            for (int i=1;i<=5;i++)
            {
                Console.WriteLine("bir sayi giriniz:");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("bir sayi giriniz:");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("islemi secim 0-topla,1-cıkar,2-carp,3-bol:");
                secim = Convert.ToInt32(Console.ReadLine());
                if(secim == 0)
                {
                  sonuc=sayi1 + sayi2;

                }
               else if(secim==1)
                {
                    sonuc = sayi1 - sayi2;
                }
               else if (secim==2)
                {
                    sonuc = sayi1 * sayi2;
                }
                else if (secim==3)
                {
                    sonuc = sayi1 / sayi2;
                }
                

                    Console.WriteLine("sonuc:" + sonuc);
            }
        }
    }
}
