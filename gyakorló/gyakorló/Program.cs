using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorló
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            TimeSpan regg_s = new TimeSpan(6, 0, 0);
            TimeSpan regg_e = new TimeSpan(10, 0, 0);
            TimeSpan délE_s = new TimeSpan(10, 0, 0);
            TimeSpan délE_e = new TimeSpan(12, 0, 0);
            TimeSpan dél = new TimeSpan(12, 0, 0);
            TimeSpan délU_s = new TimeSpan(12, 0, 0);
            TimeSpan délU_e = new TimeSpan(19, 0, 0);
            TimeSpan este_s = new TimeSpan(19, 0, 0);
            TimeSpan este_e = new TimeSpan(6, 0, 0);

            if ((now >= regg_s) && (now < regg_e))
            {
                Console.WriteLine("Jó reggelt!");
            }

            if ((now >= délE_s) && (now < délE_e))
            {
                Console.WriteLine("Délelőtt van!");
            }

            if (now == dél)
            {
                Console.WriteLine("Dél van!");
            }

            if ((now > délU_s) && (now < délU_e))
            {
                Console.WriteLine("Délután van!");
            }
            if ((now >= este_s) && (now < este_e))
            {
                Console.WriteLine("Jó estét!");
            }
            Console.WriteLine("Mekkora pénzt szeretne lekötni");
            double össz = int.Parse(Console.ReadLine());
            Console.WriteLine("Hány évig?");
            int év = int.Parse(Console.ReadLine());
            double profit = 0;
            for (int i = 0; i <= év; i++) {
                profit += össz * 0.1; }
            Console.WriteLine($"A kezdeti {össz}-Ft {év} évnyi elteltével {profit}-Ft profitot kaphat");

            Console.WriteLine("Adja meg a futó kezdő sebességét m/s-ban");
            double v0 = double.Parse(Console.ReadLine());
 
            {
                double vmax = v0 + 2.0;
                double distance = 100.0;

                Console.WriteLine("\nTáv(m)\tSebesség(km/h)");

                for (int d = 0; d <= 100; d += 10)
                {
                    double speed;

                    if (d <= 50)
                    {

                        speed = v0 + (vmax - v0) * d / 50.0;
                    }
                    else if (d <= 90)
                    {
                        speed = vmax;
                    }
                    else
                    {
                        speed = vmax * (100 - d) / 10.0;
                    }

                    double speedKmh = speed * 3.6;
                    Console.WriteLine($"{d}\t{speedKmh}");
                }
            }
        }
    }
}

