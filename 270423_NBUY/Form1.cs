using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _270423_NBUY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=.;Database=Northwind;User=sa;Pwd=123");
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Kategoriler",baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvListe.DataSource = dt;
            dgvListe.Columns[0].Visible = false;
            //dgvListe.Columns[1].Visible = false;
            //dgvListe.Columns[2].Visible = false;
            dgvListe.Columns[3].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert Kategoriler (KategoriAdi,Tanimi) values (@adi,@tanimi)";
            cmd.Connection = baglanti;
            cmd.Parameters.AddWithValue("@adi", txtAd.Text);
            cmd.Parameters.AddWithValue("@tanimi", txtTanim.Text);
            baglanti.Open();
            int etk = cmd.ExecuteNonQuery();
            baglanti.Close();
            if (etk>0)
            {
                MessageBox.Show("Başarılı");
                Listele();

            }
            else
            {
                MessageBox.Show("Başarısız");
            }



        }

        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Tedarikciler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvListe.DataSource = dt;
            dgvListe.Columns[0].Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            btnEkle.Visible = false;
            txtAd.Visible = false;
            txtTanim.Visible = false;
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert Tedarikciler (SirketAdi,Sehir) values (@adi,@sehir)";
            cmd.Connection = baglanti;
            cmd.Parameters.AddWithValue("@adi", txtSirketAd.Text);
            cmd.Parameters.AddWithValue("@sehir", txtSehir.Text);
            baglanti.Open();
            int etk = cmd.ExecuteNonQuery();
            baglanti.Close();
            if (etk > 0)
            {
                MessageBox.Show("Başarılı");
                SqlDataAdapter adp = new SqlDataAdapter("Select * from Tedarikciler", baglanti);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvListe.DataSource = dt;
                dgvListe.Columns[0].Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                btnEkle.Visible = false;
                txtAd.Visible = false;
                txtTanim.Visible = false;

            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }
    }
}
