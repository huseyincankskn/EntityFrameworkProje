using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntitiyÜrünEntities db = new DbEntitiyÜrünEntities();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_ürün
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.Tbl_Kategori.AD,
                                            x.DURUM
                                        }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Tbl_ürün t = new Tbl_ürün();
            t.URUNAD = Txtürün.Text;
            t.MARKA = Txtmarka.Text;
            t.STOK = short.Parse(Txtstok.Text);
            t.KATEGORİ = int.Parse(comboBox1.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            t.DURUM = 1;
            db.Tbl_ürün.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedildi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txtid.Text);
            var urun = db.Tbl_ürün.Find(x);

            db.Tbl_ürün.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txtid.Text);
            var urun = db.Tbl_ürün.Find(x);
            urun.URUNAD = Txtürün.Text;
            urun.STOK = short.Parse(Txtstok.Text);
            urun.MARKA = Txtmarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori
                               select new { x.ID, x.AD }
                               ).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {

        }
    }
}
