using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// visual studioda satırların yanında sarı renk varsa kaydedilMEMIŞ alanları gösterir.
// yeşil olarak gösteriyorsa o açılışta satırda değişiklik yapılarak kaydedilmiştir. 

namespace _20170805_4Con_sayilaritopla
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kullanıcıdan 2 sayı girişi isteyip girilen sayıları toplayan uygulama.
             */
            int s1, s2;
            Console.Write("1. sayıyı girin :");
            s1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı girin :");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayıların toplamı : {0}", (s1 + s2));

            Console.Write("Sayıların toplamı : "+(s1 + s2)); //operandalardan birisi string ise diğer eleman ne olursa olsun stringe otomatik olarak çevrilir.
            Console.Read();
        }
    }
}
