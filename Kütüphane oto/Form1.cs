using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_oto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            var Gelenad = AdGiristxt.Text;
            var GelenSifre = sifreGiristxt.Text;
            if (Gelenad==("Admin")&& GelenSifre==("123"))
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı veya Şifre Hatalı");
            }
        }
    }
}
