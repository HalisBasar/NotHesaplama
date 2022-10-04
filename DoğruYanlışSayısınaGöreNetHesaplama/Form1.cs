using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoğruYanlışSayısınaGöreNetHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double turkceDogru, turkceYanlis, turkceNet;
            double matDogru, matYanlis, matNet;
            double fizDogru, fizYanlis, fizNet;

            turkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            turkceYanlis = Convert.ToDouble(txtTurkceYanlis.Text);
            //
            matDogru = Convert.ToDouble(txtTrhDogru.Text);
            matYanlis = Convert.ToDouble(txtTrhYanlis.Text);
            //
            fizDogru = Convert.ToDouble(txtFizDogru.Text);
            fizYanlis = Convert.ToDouble(txtFizYanlis.Text);
            //
            turkceNet = turkceDogru - (turkceYanlis / 4);
            matNet = matDogru - (matYanlis / 4);
            fizNet = fizDogru - (fizYanlis / 4);

            txtTurkceNet.Text = turkceNet.ToString();
            txtTrhNet.Text = matNet.ToString();
            txtFizNet.Text = fizNet.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Btntemizle_Click(object sender, EventArgs e)
        {
            txtTurkceDogru.Clear();
            txtTurkceYanlis.Clear();
            txtTurkceNet.Clear();
            //
            txtTrhYanlis.Clear();
            txtTrhDogru.Clear();
            txtTrhNet.Clear();
            //
            txtFizDogru.Clear();
            txtFizYanlis.Clear();
            txtFizNet.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTurkceDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }

        private static void OnlyText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTrhDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }

        private void txtFizDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }

        private void txtTurkceYanlis_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }

        private void txtTrhYanlis_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }

        private void txtFizYanlis_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyText(sender, e);
        }
    }
}


