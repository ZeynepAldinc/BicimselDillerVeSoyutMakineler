using System;

namespace BicimselDillerveSoyutMakineler_Odev1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int i = 0;
            int dugum = 0;
            bool kabulNoktasi = false;
            bool DegerKontrol = true;
            Console.WriteLine("Katar Giriniz: ");
            string deger = Console.ReadLine();

            while (DegerKontrol)
            {
                switch (dugum)
                {
                    case 0:
                        if (deger[i] == 'a')
                        {
                            dugum = 2;
                            kabulNoktasi = false;
                        }
                        else if (deger[i] == 'b')
                        {
                            dugum = 1;
                            kabulNoktasi = false;
                        }
                        else
                        {
                            Console.WriteLine("yanlis deger girildi!");
                            DegerKontrol = false;
                        }
                        break;
                    case 1:
                        if (deger[i] == 'a')
                        {
                            dugum = 1;
                            kabulNoktasi = false;
                        }
                        else if (deger[i] == 'b')
                        {
                            dugum = 0;
                            kabulNoktasi = true;
                        }
                        else
                        {
                            Console.WriteLine("yanlis deger girildi!");
                            DegerKontrol = false;
                        }
                        break;
                    case 2:
                        if (deger[i] == 'a')
                        {
                            dugum = 3;
                            kabulNoktasi = true;
                        }
                        else if (deger[i] == 'b')
                        {
                            dugum = 0;
                            kabulNoktasi = true;
                        }
                        else
                        {
                            Console.WriteLine("yanlis deger girildi!");
                            DegerKontrol = false;
                        }

                        break;
                    case 3:
                        if (deger[i] == 'a')
                        {
                            dugum = 2;
                            kabulNoktasi = false;
                        }
                        else if (deger[i] == 'b')
                        {
                            dugum = 3;
                            kabulNoktasi = true;
                        }
                        else
                        {
                            Console.WriteLine("yanlis deger girildi!");
                            DegerKontrol = false;
                        }

                        break;
                    default:
                        Console.WriteLine("Hatali Sistem...");
                        break;
                }
                
                i++;
                if (i >= deger.Length)
                    break;
            }
            if (kabulNoktasi)
            {
                Console.WriteLine("Deger, reguler ifadenin alt kataridir (kabul edildi)");
            }
            else
                Console.WriteLine("Deger, reguler ifadenin alt katari degildir (kabul edilmedi)");
           
        }
    }
}
