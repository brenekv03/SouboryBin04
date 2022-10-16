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
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int pcPismen = 0;
                int pcCisel=0;
                int pcOperatoru = 0;
                int pcZnakuKonceVety = 0;
                while(fs.Position<fs.Length)
                {
                    int kod = br.ReadInt32();
                    MessageBox.Show("" + (char)kod);
                }

            }
        }
    }
}
