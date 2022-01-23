using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Şifreli_Mail_Sent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x, mouse_y;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Mail_Gönder_Şifre_Çözümle a = new Mail_Gönder_Şifre_Çözümle();
            if (bunifuMaterialTextbox1.Text == "admin" && bunifuMaterialTextbox2.Text == "pass")
            {
                if (NetworkInterface.GetIsNetworkAvailable() == true)
                {
                    this.Hide();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("İnternet bağlantısı hatası.\n\nLütfen internete bağlanın ve tekrar deneyin.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (bunifuMaterialTextbox1.Text == "" && bunifuMaterialTextbox2.Text == "")
            {
                label4.Text = "Kullanıcı adı ve parola boş bırakılamaz!";
            }
            else
            {
                label4.Text = "Kullanıcı adı yada parola yanlış!";
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
