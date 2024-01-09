using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace WinFormsApp1_EF
{
    public partial class Form1 : Form
    {
        VtContext veriler = new VtContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            Ogrenci yeniOgrenci = new Ogrenci();

            yeniOgrenci.ad = txtAd.Text;
            yeniOgrenci.soyad = txtSoyad.Text;
            yeniOgrenci.okulNo = Convert.ToInt32(txtOkulNo.Text);

            veriler.ogrenciler.Add(yeniOgrenci);
            veriler.SaveChanges();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriler.ogrenciler.Load();
            dataGridView1.DataSource = veriler.ogrenciler.Local.ToBindingList();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();

            dataGridView1.Columns.Add(btn1);
            btn1.HeaderText = "Kayýt Sil";
            btn1.Text = "Sil";
            btn1.Name = "Sil";
            btn1.UseColumnTextForButtonValue = true;
            btn1.Width = 50;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                veriler.SaveChanges();

            }
        }
    }
}