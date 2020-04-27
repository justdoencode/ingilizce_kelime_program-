using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ingilizce_kelime_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\poyra\OneDrive\Masaüstü\C# Çalışmalar\Udemy Çalışma\ingilizce_kelime_oyunu\dbSozluk.mdb'");
        Random rnd = new Random();
        
        void kelime()
        {
            baglanti.Open();
            int id = rnd.Next(1, 2490);
            OleDbCommand cmd = new OleDbCommand("select * from sozluk where id=@id", baglanti);
            cmd.Parameters.AddWithValue("@id", id);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_turkce.Clear();
                lbl_kelime.Text = dr[1].ToString();
                lbl_turkce.Text = dr[2].ToString();
                lbl_turkce.Text = lbl_turkce.Text.ToLower();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            kelime();
        }
        int bilinenkelime = 0;
        private void txt_turkce_TextChanged(object sender, EventArgs e)
        {
            if (txt_turkce.Text == lbl_turkce.Text)
            {
                bilinenkelime++;
                lbl_bilinenkelime.Text = bilinenkelime.ToString();
                kelime();
            }
        }
        int süre = 90;
        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            lbl_süre.Text = süre.ToString();
            if (süre == 0)
            {
                timer1.Stop();
                txt_turkce.Enabled = false;
                MessageBox.Show("Süre Doldu\nBilinen Kelime Sayısı : "+bilinenkelime,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
