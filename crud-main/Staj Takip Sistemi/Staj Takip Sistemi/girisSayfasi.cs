﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Takip_Sistemi
{
    public partial class girisSayfasi : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RJFLT08;Initial Catalog=""Staj Takip Sistemi"";Integrated Security=True");
        public girisSayfasi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            kullaniciGiris giris = new kullaniciGiris();
            giris.Show();
            this.Hide();
        }

        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(exitBtn, "Kapat");
        }

        private void minimizeBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(minimizeBtn, "Küçült");
        }
    }
}