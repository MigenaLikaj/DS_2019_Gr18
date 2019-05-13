using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtKey.Text) < 0)
                    throw new Exception();
                txtCipherTexti.Text = Caesar.encrypt(txtPlainTexti.Text, Convert.ToInt32(txtKey.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mbushni kutite!");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtKeyD.Text) < 0)
                    throw new Exception();
                txtPlain.Text = Caesar.decrypt(txtCipher.Text, Convert.ToInt32(txtKeyD.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mbushini kutite");
            }
        }
        static class Caesar
        {
            public static string encrypt(string str, int key)
            {
                string txtEnkriptuar = "";
                for (int i = 0; i < str.Length; i++)
                    if ((int)str[i] >= 65 && (int)str[i] <= 90)
                        txtEnkriptuar += (char)((int)str[i] + key - (int)((int)(str[i] - 65 + key) / 26) * 26);
                    else if ((int)str[i] >= 97 && (int)str[i] <= 122)
                        txtEnkriptuar += (char)((int)str[i] + key - (int)((int)(str[i] - 97 + key) / 26) * 26);
                    else
                        txtEnkriptuar += str[i];
                return txtEnkriptuar;
            }

            public static string decrypt(string str, int key)
            {
                string txtDekriptuar = "";
                for (int i = 0; i < str.Length; i++)
                    if ((int)str[i] >= 65 && (int)str[i] <= 90)
                        txtDekriptuar += (char)((int)str[i] - key + (int)((90 - (int)str[i] + key) / 26) * 26);
                    else if ((int)str[i] >= 97 && (int)str[i] <= 122)
                        txtDekriptuar += (char)((int)str[i] - key + (int)((122 - (int)str[i] + key) / 26) * 26);
                    else
                        txtDekriptuar += str[i];
                return txtDekriptuar;
            }
        }
    }
}