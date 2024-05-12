using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Lotto_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("lotto.csv"))
            {
                File.Create("lotto.csv");
            }
            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Sorsolt 1",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Sorsolt 2",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Sorsolt 3",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Sorsolt 4",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Sorsolt 5",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Választott 1",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Választott 2",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Választott 3",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Választott 4",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Választott 5",
                CellTemplate = new DataGridViewTextBoxCell()
            });

            sorsoltSzamok.Columns.Add(new DataGridViewColumn()
            {
                Name = "Talált",
                CellTemplate = new DataGridViewTextBoxCell()
            });
        }

        private void BekuldesGomb_Click(object sender, EventArgs e)
        {
            string szamBekeres = SzamBekeres.Text.Trim();
            List<int> szamok = new List<int>();
            List<int> huzottSzamok = LottoSzamokHuzasa();
            List<int> datas = new List<int>();
            int talalatok = 0;

            if (szamBekeres == "" || szamBekeres == string.Empty || szamBekeres == null || szamBekeres.Split(' ').Length != 5)
            {
                MessageBox.Show("Nem megfelelő az adat!");
                return;
            }
            foreach (string szam in szamBekeres.Split(' '))
            {
                if (int.TryParse(szam, out int ujSzam))
                {
                    if (!szamok.Contains(ujSzam) && ujSzam > 0 && ujSzam < 91)
                    {
                        szamok.Add(ujSzam);
                    }
                    else
                    {
                        MessageBox.Show("Nem megfelelő az adat!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Nem megfelelő az adat!");
                    return;
                }
            }
            szamok.Sort();

            foreach (int szam in huzottSzamok)
            {
                foreach (int felSzam in szamok)
                {
                    if (szam == felSzam)
                    {
                        talalatok++;
                    }
                }
            }

            int index = sorsoltSzamok.Rows.Add();
            for (int i = 0; i < 5; i++)
            {
                sorsoltSzamok.Rows[index].Cells[i].Value = huzottSzamok[i];
                sorsoltSzamok.Rows[index].Cells[i + 5].Value = szamok[i];
            }
            sorsoltSzamok.Rows[index].Cells[10].Value = talalatok;
        }

        private List<int> LottoSzamokHuzasa()
        {
            List<int> szamok = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int szam = new Random().Next(1, 91);
                if (!szamok.Contains(szam))
                {
                    szamok.Add(szam);
                }
                else
                {
                    i--;
                }
            }
            szamok.Sort();
            return szamok;
        }

        private void RogzitesGomb_Click(object sender, EventArgs e)
        {
            string data = string.Empty;
            for (int i = 0; i < sorsoltSzamok.Rows.Count; i++)
            {
                for (int j = 0; j < sorsoltSzamok.Rows[i].Cells.Count; j++) 
                {
                    if (sorsoltSzamok.Rows[i].Cells[j].Value == null)
                        continue;
                    if (j != sorsoltSzamok.Rows[i].Cells.Count - 1)
                    {
                        data += sorsoltSzamok.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        data += sorsoltSzamok.Rows[i].Cells[j].Value + "\n";
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("lotto.csv"))
            {
                sw.Write(data);
            }
        }

        private void LekeresGomb_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("lotto.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');

                    int index = sorsoltSzamok.Rows.Add();
                    for (int i = 0; i < 5; i++)
                    {
                        sorsoltSzamok.Rows[index].Cells[i].Value = line[i];
                        sorsoltSzamok.Rows[index].Cells[i + 5].Value = line[i + 5];
                    }
                    sorsoltSzamok.Rows[index].Cells[10].Value = line[10];
                }
            }
        }
    }
}
