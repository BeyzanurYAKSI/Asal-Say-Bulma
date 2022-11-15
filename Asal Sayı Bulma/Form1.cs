using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asal_Sayı_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            long sayac = 0;
            listBox1.Items.Clear();
            long k = Convert.ToInt64(numericUpDown1.Text);
            if(k<2)
            {
                MessageBox.Show("Asal sayı bulunamadı");
            }
            else
            {
                for(long l=2; l<=k;l++)
                {
                    long kontrol = 0;
                    for(long m=2; m< l;m++)
                    {
                        if (l%m==0)
                        {
                            kontrol++;
                            break;
                        }
                    }
                    if(kontrol==0)
                    {
                        listBox1.Items.Add(l);
                        sayac++; 
                    }
                }
            }
            label2.Text = " 1 - " + k + " arası " + sayac + " adet asal sayı bulundu ";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 99999999999;
            numericUpDown1.Minimum = 0;
        }
    }    
}
