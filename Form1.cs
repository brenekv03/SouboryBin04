using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SouboryBin04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                FileStream fs1 = new FileStream("pomocnik.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs1);
                bw.Write('A');
                bw.Write('C');
            bw.Write('1');
            bw.Write('*');
            bw.Write('-');
            bw.Write('.');
            bw.Write('F');


            fs1.Close();

                FileStream fs = new FileStream("pomocnik.dat", FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int pcPismen = 0;
                int pcCisel=0;
                int pcOperatoru = 0;
                int pcZnakuKonceVety = 0;
                while(fs.Position<fs.Length)
                {
                    char kod = br.ReadChar();
                if (kod >= 'A' && kod <= 'Z')
                {
                    pcPismen++;
                }
                else if (kod >= 'a' && kod <= 'z')
                {
                    pcPismen++;
                }
                else if (kod >= '0' && kod <= '9')
                {
                    pcCisel++;
                }
                else if (kod == '+' | kod == '-' | kod == '*' | kod == '/')
                {
                    pcOperatoru++;
                }
                else if (kod == '.' | kod == '?' | kod == '!' | kod == ':')
                {
                    pcZnakuKonceVety++;
                }
                }
            MessageBox.Show("Počet písmen: " + pcPismen + "\nPočet čísel: " + pcCisel + "\nPočet operátorů: " + pcOperatoru + "\nPočet znaků" + pcZnakuKonceVety);
        }
    }
}
