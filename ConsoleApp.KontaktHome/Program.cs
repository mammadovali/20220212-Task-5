using ClassLibrary.Assistansts;
using System;
using System.Text;

namespace ConsoleApp.KontaktHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            

            Console.Title = "Kontakt Home phones";

            int len;
            Phone[] phones = new Phone[0];

            while (Monitor.Confirm("Yeni telefon daxil edilsin? [Enter => Yes, Any Key => No]"))
            {
                len = phones.Length;
                Array.Resize(ref phones, len + 1);
                phones[len] = new Phone();
               
                Console.WriteLine($"{len + 1}. Telefon haqqında: ");

                phones[len].name = Monitor.ReadString($"Adı: ");
                phones[len].producer = Monitor.ReadString($"İstehsalçı: ");
                phones[len].year = Monitor.ReadInteger($"İstehsal ili: ");
                phones[len].memory = Monitor.ReadInteger($"Daxili yaddaş (GB): ");
                phones[len].price = Monitor.ReadDouble($"Qiymət (₼): ");
                
                Console.WriteLine("--------");
            }

            Console.Clear();
            Monitor.Print("########## Telefonların siyahısı ##########");
           
            foreach (var item in phones)
            {
                Console.WriteLine(item);

                Console.WriteLine("********");
            }

            Console.ReadKey();
        }
    }
}
