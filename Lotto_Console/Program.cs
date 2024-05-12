using System;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main()
        {
            Database database = new Database();
            List<Lotto> lottok = database.lottok;
            Console.WriteLine($"1. feladat:\n\tEddig {lottok.Count} db lottóhúzás volt.");
            int min = int.MaxValue, max = 0;
            Int64 telitalatok = 0;
            Int64 legmagasabbKifi = 0;
            DateTime datum = DateTime.Now;
            foreach (Lotto lotto in lottok)
            {
                if (min > lotto.Ev)
                    min = lotto.Ev;
                if (max < lotto.Ev)
                    max = lotto.Ev;
                telitalatok += lotto.Talalat5db;
                if (legmagasabbKifi < lotto.Talalat5ft)
                {
                    legmagasabbKifi = lotto.Talalat5ft;
                    datum = lotto.Huzasdatum;
                }
            }
            Console.WriteLine($"2. feladat:\n\tAz első lottóhúzás {min}-ben/ban volt.\n\tAz utolsó lottóhúzás {max}-ben/ban volt.");
            Console.WriteLine($"3. feladat:\n\tEddig {telitalatok} telitalálat volt.");
            Console.WriteLine($"4. feladat:\n\tAz eddigi legnagyobb kifizetés {legmagasabbKifi} Ft és {datum.ToString("yyyy.MM.dd")}-ben/ban húzták.");
            Console.WriteLine($"5. feladat:");
            List<int> bekertSzamok = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"\tÍrd be a {i + 1}. számot: ");
                if (int.TryParse(Console.ReadLine(), out int beirt))
                {
                    if (beirt > 0 && beirt <= 90 && !bekertSzamok.Contains(beirt))
                    {
                        bekertSzamok.Add(beirt);
                    }
                    else
                    {
                        Console.WriteLine("\t\tButa user!");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("\t\tButa user!");
                    i--;
                }
            }

            bekertSzamok.Sort();
            int talalat = 0;

            foreach (Lotto lotto in lottok)
            {
                talalat = 0;
                foreach (int szam in bekertSzamok)
                {
                    if (szam == lotto.szam.Egy)
                        talalat++;
                    if (szam == lotto.szam.Ketto)
                        talalat++;
                    if (szam == lotto.szam.Harom)
                        talalat++;
                    if (szam == lotto.szam.Negy)
                        talalat++;
                    if (szam == lotto.szam.Ot)
                        talalat++;
                }
                if (talalat > 1)
                {
                    if (talalat == 2)
                        Console.WriteLine($"{lotto.Huzasdatum.ToString("yyyy.MM.dd")}-ban/ben {talalat}-s lett volna a nyereményed pedig {lotto.Talalat2ft} Ft lett volna.");
                    if (talalat == 3)
                        Console.WriteLine($"{lotto.Huzasdatum.ToString("yyyy.MM.dd")}-ban/ben {talalat}-s lett volna a nyereményed pedig {lotto.Talalat3ft} Ft lett volna.");
                    if (talalat == 4)
                        Console.WriteLine($"{lotto.Huzasdatum.ToString("yyyy.MM.dd")}-ban/ben {talalat}-s lett volna a nyereményed pedig {lotto.Talalat4ft} Ft lett volna.");
                    if (talalat == 5)
                        Console.WriteLine($"{lotto.Huzasdatum.ToString("yyyy.MM.dd")}-ban/ben {talalat}-s lett volna a nyereményed pedig {lotto.Talalat5ft} Ft lett volna.");
                }
            }
            Console.ReadKey(true);
        }
    }
}