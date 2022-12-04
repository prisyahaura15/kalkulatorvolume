using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            epInfo.SetError(groupBox1, "Silahkan pilih bangun ruang");

        }

        private void tbPanjang_Leave(object sender, EventArgs e)
        {
            if (tbPanjang.Text != "" && (tbPanjang.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(tbPanjang, "Lanjutkan");
                epWrong.SetError(tbPanjang, "");
                epInfo.SetError(tbPanjang, "");
                epWarning.SetError(tbPanjang, "");
            }
            else if (tbPanjang.Text == "")
            {
                epWrong.SetError(tbPanjang, "");
                epCorrect.SetError(tbPanjang, "");
                epWarning.SetError(tbPanjang, "Belum diisi");
                epInfo.SetError(tbPanjang, "");
            }
            else
            {
                epWrong.SetError(tbPanjang, "Data yang dimasukkan salah");
                epCorrect.SetError(tbPanjang, "");
                epInfo.SetError(tbPanjang, "");
                epWarning.SetError(tbPanjang, "");
            }
        }

        private void tbTinggi_Leave(object sender, EventArgs e)
        {
            if (tbTinggi.Text != "" && (tbTinggi.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(tbTinggi, "Lanjutkan");
                epWrong.SetError(tbTinggi, "");
                epInfo.SetError(tbTinggi, "");
                epWarning.SetError(tbTinggi, "");
            }
            else if (tbTinggi.Text == "")
            {
                epWrong.SetError(tbTinggi, "");
                epCorrect.SetError(tbTinggi, "");
                epWarning.SetError(tbTinggi, "Belum diisi");
                epInfo.SetError(tbTinggi, "");
            }
            else
            {
                epWrong.SetError(tbTinggi, "Data yang dimasukkan salah");
                epCorrect.SetError(tbTinggi, "");
                epInfo.SetError(tbTinggi, "");
                epWarning.SetError(tbTinggi, "");
            }
        }

        private void tbLebar_Leave(object sender, EventArgs e)
        {
            if (tbLebar.Text != "" && (tbLebar.Text).All(Char.IsNumber))
            {
                int lebar = int.Parse(tbLebar.Text);
                epCorrect.SetError(tbLebar, "Lanjutkan");
                epWrong.SetError(tbLebar, "");
                epInfo.SetError(tbLebar, "");
                epWarning.SetError(tbLebar, "");
            }
            else if (tbLebar.Text == "")
            {
                epWrong.SetError(tbLebar, "");
                epCorrect.SetError(tbLebar, "");
                epWarning.SetError(tbLebar, "Belum diisi");
                epInfo.SetError(tbLebar, "");
            }
            else
            {
                epWrong.SetError(tbLebar, "Data yang dimasukkan salah");
                epCorrect.SetError(tbLebar, "");
                epInfo.SetError(tbLebar, "");
                epWarning.SetError(tbLebar, "");
            }
        }

        private void tbDiameter_Leave(object sender, EventArgs e)
        {
            if (tbDiameter.Text != "" && (tbDiameter.Text).All(Char.IsNumber))
            {
                int diameter = int.Parse(tbDiameter.Text);
                epCorrect.SetError(tbDiameter, "Lanjutkan");
                epWrong.SetError(tbDiameter, "");
                epInfo.SetError(tbDiameter, "");
            }
            else if (tbDiameter.Text == "")
            {
                epWrong.SetError(tbDiameter, "");
                epCorrect.SetError(tbDiameter, "");
                epWarning.SetError(tbDiameter, "Belum diisi");
                epInfo.SetError(tbDiameter, "");
            }
            else
            {
                epWrong.SetError(tbDiameter, "Data yang dimasukkan salah");
                epCorrect.SetError(tbDiameter, "");
                epInfo.SetError(tbDiameter, "");
                epWarning.SetError(tbDiameter, "");
            }
        }

        private void tbAlas_Leave(object sender, EventArgs e)
        {
            if (tbAlas.Text != "" && (tbAlas.Text).All(Char.IsNumber))
            {
                int alas = int.Parse(tbAlas.Text);
                epCorrect.SetError(tbAlas, "Lanjutkan");
                epWrong.SetError(tbAlas, "");
                epWarning.SetError(tbAlas, "");
                epInfo.SetError(tbAlas, "");
            }
            else if (tbAlas.Text == "")
            {
                epWrong.SetError(tbAlas, "");
                epCorrect.SetError(tbAlas, "");
                epWarning.SetError(tbAlas, "Belum diisi");
                epInfo.SetError(tbAlas, "");
            }
            else
            {
                epWrong.SetError(tbAlas, "Data yang dimasukkan salah");
                epCorrect.SetError(tbAlas, "");
                epWarning.SetError(tbAlas, "");
                epInfo.SetError(tbAlas, "");
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbAlas.Clear();
            tbDiameter.Clear();
            tbLebar.Clear();
            tbPanjang.Clear();
            tbTinggi.Clear();
            rbBalok.Checked = false;
            rbKubus.Checked = false;
            rbBola.Checked = false;
            rbPrisma.Checked = false;
            rbLimas3.Checked = false;
            rbLimas4.Checked = false;
            rbKerucut.Checked = false;
            rbTabung.Checked = false;
            tbAlas.Enabled = false;
            tbPanjang.Enabled = false;
            tbLebar.Enabled = false;
            tbTinggi.Enabled = false;
            tbDiameter.Enabled = false;
            epInfo.SetError(groupBox1, "Silahkan pilih bangun ruang");
            epWrong.SetError(tbAlas, "");
            epCorrect.SetError(tbAlas, "");
            epWarning.SetError(tbAlas, "");
            epInfo.SetError(tbAlas, "");
            epWrong.SetError(tbDiameter, "");
            epCorrect.SetError(tbDiameter, "");
            epWarning.SetError(tbDiameter, "");
            epInfo.SetError(tbDiameter, "");
            epWrong.SetError(tbLebar, "");
            epCorrect.SetError(tbLebar, "");
            epWarning.SetError(tbLebar, "");
            epInfo.SetError(tbLebar, "");
            epWrong.SetError(tbPanjang, "");
            epCorrect.SetError(tbPanjang, "");
            epWarning.SetError(tbPanjang, "");
            epInfo.SetError(tbPanjang, "");
            epWrong.SetError(tbTinggi, "");
            epCorrect.SetError(tbTinggi, "");
            epWarning.SetError(tbTinggi, "");
            epInfo.SetError(tbTinggi, "");
        }

        private void bHitung_Click(object sender, EventArgs e)
        {
            if (rbBalok.Checked)
            {

                if (tbPanjang.Text != "" && tbLebar.Text != "" && tbTinggi.Text != "")
                {
                    int panjang = int.Parse(tbPanjang.Text);
                    int tinggi = int.Parse(tbTinggi.Text);
                    int lebar = int.Parse(tbLebar.Text);
                    int calc = panjang * lebar * tinggi;
                    MessageBox.Show
                    ("Tinggi : " + tbTinggi.Text +
                    "\nLebar: " + tbLebar.Text +
                    "\nPanjang: " + tbTinggi.Text +
                    "\nVolume: " + calc,

                    "Terima kasih telah menggunakan aplikasi kami",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tbPanjang.Text == "" || tbTinggi.Text == "" || tbLebar.Text == "")
                {
                    MessageBox.Show
                   ("Data belum lengkap",
                   "Kesalahan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbKubus.Checked)
            {


                if(tbPanjang.Text != "")
                {
                    int panjang = int.Parse(tbPanjang.Text);
                    int calc = panjang * panjang * panjang;
                    MessageBox.Show
                   ("Panjang sisi : " + tbPanjang.Text +
                   "\nVolume: " + calc,

                   "Terima kasih telah menggunakan aplikasi kami",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tbPanjang.Text == "")
                {
                    MessageBox.Show
                   ("Data belum lengkap",
                   "Kesalahan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbBola.Checked)
            {

                if (tbDiameter.Text != "")
                {
                    int diameter = int.Parse(tbDiameter.Text);
                    int r = diameter / 2;
                    float calc = (float)(4.00 / 3.00 * 3.14 * r * r * r);
                    MessageBox.Show
                   ("Diameter : " + tbDiameter.Text +
                   "\nJari jari : " + r +
                   "\nVolume : " + calc,

                   "Terima kasih telah menggunakan aplikasi kami",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tbDiameter.Text == "")
                {
                    MessageBox.Show
                   ("Data belum lengkap",
                   "Kesalahan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbTabung.Checked)
            {
                if (tbDiameter.Text != "" && tbTinggi.Text != "")
                {
                    int diameter = int.Parse(tbDiameter.Text);
                    int tinggi = int.Parse(tbTinggi.Text);
                    int r = diameter / 2;
                    float calc = (float)(3.14 * r * r * tinggi);
                    MessageBox.Show
                   ("Diameter : " + tbDiameter.Text +
                   "\nJari jari : " + r +
                   "\nTinggi : " + tinggi +
                   "\nVolume : " + calc,

                   "Terima kasih telah menggunakan aplikasi kami",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tbDiameter.Text == "" || tbTinggi.Text=="")
                {
                    MessageBox.Show
                   ("Data belum lengkap",
                   "Kesalahan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbKerucut.Checked)
            {

                if (tbDiameter.Text != "" && tbTinggi.Text != "")
                {
                    int diameter = int.Parse(tbDiameter.Text);
                    int tinggi = int.Parse(tbTinggi.Text);
                    int r = diameter / 2;
                    float calc = (float)(1.00/3.00 * 3.14 * r * r * tinggi);
                    MessageBox.Show
                   ("Diameter : " + tbDiameter.Text +
                   "\nJari jari : " + r +
                   "\nTinggi : " + tinggi +
                   "\nVolume : " + calc,

                   "Terima kasih telah menggunakan aplikasi kami",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tbDiameter.Text == "" || tbTinggi.Text == "")
                {
                    MessageBox.Show
                   ("Data belum lengkap",
                   "Kesalahan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbPrisma.Checked)
            {
                if (tbPanjang.Text != "" && tbLebar.Text != "" && tbTinggi.Text != "")
                {
                    int a = int.Parse(tbPanjang.Text);
                    int b = int.Parse(tbLebar.Text);
                    int tinggi = int.Parse(tbTinggi.Text);
                    float calc = (float)(1.00 / 2.00 * a * b  * tinggi);
                    MessageBox.Show
                   ("a : " + a
                   + "\nb : " + b + 
                   "\nTinggi : " + tinggi +
                   "\nVolume : " + calc,

                   "Terima kasih telah menggunakan aplikasi kami",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tbPanjang.Text != "" || tbLebar.Text != "" || tbTinggi.Text != "")
                {
                    MessageBox.Show
                   ("Data belum lengkap",
                   "Kesalahan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbLimas3.Checked)
            {
                if (tbAlas.Text != "" && tbLebar.Text != "" && tbTinggi.Text != "")
                {
                    int a = int.Parse(tbAlas.Text);
                    int b = int.Parse(tbLebar.Text);
                    int tinggi = int.Parse(tbTinggi.Text);
                    float calc = (float)(1.00 / 6.00 * a * b * tinggi);
                    MessageBox.Show
                   ("a : " + a
                   + "\nb : " + b +
                   "\nTinggi : " + tinggi +
                   "\nVolume : " + calc,

                   "Terima kasih telah menggunakan aplikasi kami",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tbAlas.Text != "" || tbLebar.Text != "" || tbTinggi.Text != "")
                {
                    MessageBox.Show
                   ("Data belum lengkap",
                   "Kesalahan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbLimas4.Checked)
            {
                if (tbPanjang.Text != "" && tbLebar.Text != "" && tbTinggi.Text != "")
                {
                    int luasalas = int.Parse(tbPanjang.Text) * int.Parse(tbLebar.Text);
                    int tinggi = int.Parse(tbTinggi.Text);
                    float calc = (float)(1.00 / 3.00 * luasalas * tinggi);
                    MessageBox.Show
                   ("Panjang : " + tbPanjang.Text +
                   "\nLebar : " + tbLebar.Text +
                   "\nLuas Alas : " + luasalas +
                   "\nTinggi : " + tinggi +
                   "\nVolume : " + calc,

                   "Terima kasih telah menggunakan aplikasi kami",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tbPanjang.Text != "" || tbLebar.Text != "" || tbTinggi.Text != "")
                {
                    MessageBox.Show
                   ("Data belum lengkap",
                   "Kesalahan",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show
                  ("Data belum lengkap",
                  "Kesalahan",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbKubus_CheckedChanged(object sender, EventArgs e)
        {
            tbTinggi.Clear();
            tbPanjang.Clear();
            tbDiameter.Clear();
            tbAlas.Clear();
            tbLebar.Clear();
            tbPanjang.Enabled = true;
            tbTinggi.Enabled = false;
            tbLebar.Enabled = false;
            tbDiameter.Enabled = false;
            tbAlas.Enabled = false;
            epInfo.SetError(tbPanjang, "");
            epInfo.SetError(tbLebar, "");
            epInfo.SetError(groupBox1, "");
            epWrong.SetError(tbAlas, "");
            epCorrect.SetError(tbAlas, "");
            epWarning.SetError(tbAlas, "");
            epWrong.SetError(tbDiameter, "");
            epCorrect.SetError(tbDiameter, "");
            epWarning.SetError(tbDiameter, "");
            epWrong.SetError(tbLebar, "");
            epCorrect.SetError(tbLebar, "");
            epWarning.SetError(tbLebar, "");
            epWrong.SetError(tbPanjang, "");
            epCorrect.SetError(tbPanjang, "");
            epWarning.SetError(tbPanjang, "");
            epWrong.SetError(tbTinggi, "");
            epCorrect.SetError(tbTinggi, "");
            epWarning.SetError(tbTinggi, "");
        }

        private void rbBalok_CheckedChanged(object sender, EventArgs e)
        {
            tbTinggi.Clear();
            tbPanjang.Clear();
            tbDiameter.Clear();
            tbAlas.Clear();
            tbLebar.Clear();
            tbPanjang.Enabled = true;
            tbLebar.Enabled = true;
            tbTinggi.Enabled = true; 
            tbDiameter.Enabled = false;
            tbAlas.Enabled = false;
            epInfo.SetError(tbPanjang, "");
            epInfo.SetError(tbLebar, "");
            epInfo.SetError(groupBox1, "");
            epWrong.SetError(tbAlas, "");
            epCorrect.SetError(tbAlas, "");
            epWarning.SetError(tbAlas, "");
            epWrong.SetError(tbDiameter, "");
            epCorrect.SetError(tbDiameter, "");
            epWarning.SetError(tbDiameter, "");
            epWrong.SetError(tbLebar, "");
            epCorrect.SetError(tbLebar, "");
            epWarning.SetError(tbLebar, "");
            epWrong.SetError(tbPanjang, "");
            epCorrect.SetError(tbPanjang, "");
            epWarning.SetError(tbPanjang, "");
            epWrong.SetError(tbTinggi, "");
            epCorrect.SetError(tbTinggi, "");
            epWarning.SetError(tbTinggi, "");
        }

        private void rbPrisma_CheckedChanged(object sender, EventArgs e)
        {
            tbTinggi.Clear();
            tbPanjang.Clear();
            tbDiameter.Clear();
            tbAlas.Clear();
            tbLebar.Clear();
            tbPanjang.Enabled = true;
            tbLebar.Enabled = true;
            tbTinggi.Enabled = true;
            tbDiameter.Enabled = false;
            tbAlas.Enabled = false;
            epInfo.SetError(tbPanjang, "Masukkan panjang sisi miring a disini");
            epInfo.SetError(tbLebar, "Masukkan panjang sisi miring b disini");
            epInfo.SetError(groupBox1, "");
            epWrong.SetError(tbAlas, "");
            epCorrect.SetError(tbAlas, "");
            epWarning.SetError(tbAlas, "");
            epWrong.SetError(tbDiameter, "");
            epCorrect.SetError(tbDiameter, "");
            epWarning.SetError(tbDiameter, "");
            epWrong.SetError(tbLebar, "");
            epCorrect.SetError(tbLebar, "");
            epWarning.SetError(tbLebar, "");
            epWrong.SetError(tbPanjang, "");
            epCorrect.SetError(tbPanjang, "");
            epWarning.SetError(tbPanjang, "");
            epWrong.SetError(tbTinggi, "");
            epCorrect.SetError(tbTinggi, "");
            epWarning.SetError(tbTinggi, "");
        }

        private void rbBola_CheckedChanged(object sender, EventArgs e)
        {
            tbTinggi.Clear();
            tbPanjang.Clear();
            tbDiameter.Clear();
            tbAlas.Clear();
            tbLebar.Clear();
            tbPanjang.Enabled = false;
            tbLebar.Enabled = false;
            tbTinggi.Enabled = false;
            tbDiameter.Enabled = true;
            tbAlas.Enabled = false;
            epInfo.SetError(tbPanjang, "");
            epInfo.SetError(tbLebar, "");
            epInfo.SetError(groupBox1, "");
            epWrong.SetError(tbAlas, "");
            epCorrect.SetError(tbAlas, "");
            epWarning.SetError(tbAlas, "");
            epWrong.SetError(tbDiameter, "");
            epCorrect.SetError(tbDiameter, "");
            epWarning.SetError(tbDiameter, "");
            epWrong.SetError(tbLebar, "");
            epCorrect.SetError(tbLebar, "");
            epWarning.SetError(tbLebar, "");
            epWrong.SetError(tbPanjang, "");
            epCorrect.SetError(tbPanjang, "");
            epWarning.SetError(tbPanjang, "");
            epWrong.SetError(tbTinggi, "");
            epCorrect.SetError(tbTinggi, "");
            epWarning.SetError(tbTinggi, "");
        }

        private void rbLimas3_CheckedChanged(object sender, EventArgs e)
        {
            tbTinggi.Clear();
            tbPanjang.Clear();
            tbDiameter.Clear();
            tbAlas.Clear();
            tbLebar.Clear();
            tbPanjang.Enabled = false;
            tbLebar.Enabled = true;
            tbTinggi.Enabled = true;
            tbDiameter.Enabled = false;
            tbAlas.Enabled = true;
            epInfo.SetError(tbPanjang, "");
            epInfo.SetError(tbLebar, "Masukkan panjang sisi miring b disini");
            epInfo.SetError(groupBox1, "");
            epWrong.SetError(tbAlas, "");
            epCorrect.SetError(tbAlas, "");
            epWarning.SetError(tbAlas, "");
            epWrong.SetError(tbDiameter, "");
            epCorrect.SetError(tbDiameter, "");
            epWarning.SetError(tbDiameter, "");
            epWrong.SetError(tbLebar, "");
            epCorrect.SetError(tbLebar, "");
            epWarning.SetError(tbLebar, "");
            epWrong.SetError(tbPanjang, "");
            epCorrect.SetError(tbPanjang, "");
            epWarning.SetError(tbPanjang, "");
            epWrong.SetError(tbTinggi, "");
            epCorrect.SetError(tbTinggi, "");
            epWarning.SetError(tbTinggi, "");
        }

        private void rbLimas4_CheckedChanged(object sender, EventArgs e)
        {
            tbTinggi.Clear();
            tbPanjang.Clear();
            tbDiameter.Clear();
            tbAlas.Clear();
            tbLebar.Clear();
            tbPanjang.Enabled = true;
            tbLebar.Enabled = true;
            tbTinggi.Enabled = true;
            tbDiameter.Enabled = false;
            tbAlas.Enabled = false;
            epInfo.SetError(tbPanjang, "");
            epInfo.SetError(tbLebar, "");
            epInfo.SetError(groupBox1, "");
            epWrong.SetError(tbAlas, "");
            epCorrect.SetError(tbAlas, "");
            epWarning.SetError(tbAlas, "");
            epWrong.SetError(tbDiameter, "");
            epCorrect.SetError(tbDiameter, "");
            epWarning.SetError(tbDiameter, "");
            epWrong.SetError(tbLebar, "");
            epCorrect.SetError(tbLebar, "");
            epWarning.SetError(tbLebar, "");
            epWrong.SetError(tbPanjang, "");
            epCorrect.SetError(tbPanjang, "");
            epWarning.SetError(tbPanjang, "");
            epWrong.SetError(tbTinggi, "");
            epCorrect.SetError(tbTinggi, "");
            epWarning.SetError(tbTinggi, "");
        }

        private void rbKerucut_CheckedChanged(object sender, EventArgs e)
        {
            tbTinggi.Clear();
            tbPanjang.Clear();
            tbDiameter.Clear();
            tbAlas.Clear();
            tbLebar.Clear();
            tbPanjang.Enabled = false;
            tbLebar.Enabled = false;
            tbTinggi.Enabled = true;
            tbDiameter.Enabled = true;
            tbAlas.Enabled = false;
            epInfo.SetError(tbPanjang, "");
            epInfo.SetError(tbLebar, "");
            epInfo.SetError(groupBox1, "");
            epWrong.SetError(tbAlas, "");
            epCorrect.SetError(tbAlas, "");
            epWarning.SetError(tbAlas, "");
            epWrong.SetError(tbDiameter, "");
            epCorrect.SetError(tbDiameter, "");
            epWarning.SetError(tbDiameter, "");
            epWrong.SetError(tbLebar, "");
            epCorrect.SetError(tbLebar, "");
            epWarning.SetError(tbLebar, "");
            epWrong.SetError(tbPanjang, "");
            epCorrect.SetError(tbPanjang, "");
            epWarning.SetError(tbPanjang, "");
            epWrong.SetError(tbTinggi, "");
            epCorrect.SetError(tbTinggi, "");
            epWarning.SetError(tbTinggi, "");
        }

        private void rbTabung_CheckedChanged(object sender, EventArgs e)
        {
            tbTinggi.Clear();
            tbPanjang.Clear();
            tbDiameter.Clear();
            tbAlas.Clear();
            tbLebar.Clear();
            tbPanjang.Enabled = false;
            tbLebar.Enabled = false;
            tbTinggi.Enabled = true;
            tbDiameter.Enabled = true;
            tbAlas.Enabled = false;
            epInfo.SetError(tbPanjang, "");
            epInfo.SetError(tbLebar, "");
            epInfo.SetError(groupBox1, "");
            epWrong.SetError(tbAlas, "");
            epCorrect.SetError(tbAlas, "");
            epWarning.SetError(tbAlas, "");
            epWrong.SetError(tbDiameter, "");
            epCorrect.SetError(tbDiameter, "");
            epWarning.SetError(tbDiameter, "");
            epWrong.SetError(tbLebar, "");
            epCorrect.SetError(tbLebar, "");
            epWarning.SetError(tbLebar, "");
            epWrong.SetError(tbPanjang, "");
            epCorrect.SetError(tbPanjang, "");
            epWarning.SetError(tbPanjang, "");
            epWrong.SetError(tbTinggi, "");
            epCorrect.SetError(tbTinggi, "");
            epWarning.SetError(tbTinggi, "");
        }
    }
}
