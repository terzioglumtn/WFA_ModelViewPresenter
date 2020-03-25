using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_MVP.Presenter;
using WindowsFormsApp_MVP.View;

namespace WindowsFormsApp_MVP
{
    public partial class Form1 : Form, ILoginPanel
    {
        public event EventHandler GirisTiklandi;

        public Form1()
        {
            InitializeComponent();
        }

        public string KullaniciAdi
        {
            get
            {
                return textBox_kullaniciAdi.Text;
            }
            set
            {
                textBox_kullaniciAdi.Text = value;
            }
        }
        public string Sifre
        {
            get
            {
                return textBox_sifre.Text;
            }
            set
            {
                textBox_sifre.Text = value;
            }
        }
        public string GirisDurumu
        {
            get
            {
                return label_girisDurumuText.Text;
            }
            set
            {
                label_girisDurumuText.Text = value;
            }
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            LoginPresenter loginPresenter = new LoginPresenter(this);
            GirisTiklandi?.Invoke(this, EventArgs.Empty);
        }
    }
}