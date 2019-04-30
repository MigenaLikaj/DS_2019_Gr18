using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnkriptimiDekriptimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnEnkriptimi_Click(object sender, EventArgs e)
        {
            txtciphertexti.Text = Enkriptimi(new StringBuilder(txtplaintexti.Text), 6).ToString();
        }
        private StringBuilder Enkriptimi(StringBuilder TekstiPaenkriptuar, int celsi)
        {
            StringBuilder TekstiEnkriptuar = new StringBuilder(TekstiPaenkriptuar.ToString());
            for (int indeksi = 0; indeksi < TekstiPaenkriptuar.Length; indeksi++)
            {
                if (TekstiPaenkriptuar[indeksi] != ' ')
                {
                    int nrRendorShkronjes = TekstiPaenkriptuar[indeksi] + 26 - 'A';
                    int shkronja = ((nrRendorShkronjes - celsi) % 26) + 'A';
                    TekstiEnkriptuar[indeksi] = (char)shkronja;
                }
            }
            return TekstiEnkriptuar;
        }

    
        private void btnDekriptimi_Click(object sender, EventArgs e)
        {
            txtplaintexti.Text = Dekriptimi(new StringBuilder(txtciphertexti.Text), 6).ToString();
        }
        private StringBuilder Dekriptimi(StringBuilder TekstiEnkriptuar, int celsi)
        {
            StringBuilder TekstiDekriptuar = new StringBuilder(TekstiEnkriptuar.ToString());
            for (int indeksi = 0; indeksi < TekstiDekriptuar.Length; indeksi++)
            {
                if (TekstiEnkriptuar[indeksi] != ' ')
                {
                    int nrRendorShkronjes = TekstiEnkriptuar[indeksi] + 26 - 'A';
                    int shkronja = ((nrRendorShkronjes - celsi) % 26) + 'A';
                    TekstiDekriptuar[indeksi] = (char)shkronja;
                }
            }
            return TekstiDekriptuar;
        }

    }

}

