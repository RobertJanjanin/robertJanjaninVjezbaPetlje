﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robertJanjaninPetlje
{
    class Program
    {
        static void Main(string[] args)
        {
            string unosTeksta;
            Console.WriteLine("Unesi riječ: ");
            unosTeksta = Console.ReadLine();

            Console.WriteLine(unosTeksta);

            for (int i = unosTeksta.Length; i > 0; i--)
            {
                Console.WriteLine(unosTeksta.Substring(0, i));

            }
            Console.ReadKey();
        }
    }
}
