using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bineáris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("djon meg egy egész számot : ");
            int szám = int.Parse(Console.ReadLine());
            int i;
            int[] tömb = new int[10];
            for (i = 0; szám > 0; i++)
            {
                tömb[i] = szám % 2;
                szám = szám / 2;
            }
            Console.Write("\nA megadott szám kettes számrendszerben: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(tömb[i]);
            }
            Console.ReadKey();
        }

    }
}
