using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.KontaktHome
{
    internal class Phone
    {
        /* 
         adi, istehsalci, istehsal ili, yaddash, qiymet
         */
                
        public int id;
        public string name;
        public string producer;
        public int year;
        public int memory;
        public double price;

        static int counter = 0;

        public Phone()
        {
            counter++;
            id = counter;
        }

        public override string ToString()
        {
            return $"No: {id}\n" +
                $"Adı: {name}\n" +
                $"İstehsalçı: {producer}\n" +
                $"İstehsal ili: {year}\n" +
                $"Daxili yaddaş (GB): {memory}\n" +
                $"Qiymət: {price} ₼";
        }



    }
}
