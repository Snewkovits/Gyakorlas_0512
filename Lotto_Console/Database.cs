using System;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    class Database
    {
        public List<Lotto> lottok = new List<Lotto>();
        string file = "lotto.txt";
        
        public Database()
        {
            using (StreamReader sr = new StreamReader(file))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    if (line.Length < 10)
                        continue;

                    DateTime date;
                    DateTime.TryParseExact(line[2], "yyyy.MM.dd.", null, System.Globalization.DateTimeStyles.None, out date);
                    Lotto lotto = new Lotto()
                    {
                        Ev = int.Parse(line[0]),
                        Het = int.Parse(line[1]),
                        Huzasdatum = date,
                        Talalat5db = Int64.Parse(line[3].Replace(" ", "")),
                        Talalat5ft = Int64.Parse(line[4].Replace("Ft", "").Replace(" ", "")),
                        Talalat4db = Int64.Parse(line[5].Replace(" ", "")),
                        Talalat4ft = Int64.Parse(line[6].Replace("Ft", "").Replace(" ", "")),
                        Talalat3db = Int64.Parse(line[7].Replace(" ", "")),
                        Talalat3ft = Int64.Parse(line[8].Replace("Ft", "").Replace(" ", "")),
                        Talalat2db = Int64.Parse(line[9].Replace(" ", "")),
                        Talalat2ft = Int64.Parse(line[10].Replace("Ft", "").Replace(" ", "")),
                        szam = new Szamok()
                        {
                            Egy = int.Parse(line[11]),
                            Ketto = int.Parse(line[12]),
                            Harom = int.Parse(line[13]),
                            Negy = int.Parse(line[14]),
                            Ot = int.Parse(line[15])
                        }
                    };

                    lottok.Add(lotto);
                }
            }
        }
    }

    struct Lotto
    {
        public int Ev;
        public int Het;
        public DateTime Huzasdatum;
        public Int64 Talalat5db;
        public Int64 Talalat5ft;
        public Int64 Talalat4db;
        public Int64 Talalat4ft;
        public Int64 Talalat3db;
        public Int64 Talalat3ft;
        public Int64 Talalat2db;
        public Int64 Talalat2ft;
        public Szamok szam;
    }

    struct Szamok
    {
        public int Egy;
        public int Ketto;
        public int Harom;
        public int Negy;
        public int Ot;
    }
}
