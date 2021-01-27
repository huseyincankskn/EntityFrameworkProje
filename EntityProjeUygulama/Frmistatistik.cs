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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }
        DbEntitiyÜrünEntities db = new DbEntitiyÜrünEntities();
        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategori.Count().ToString();
            label3.Text = db.Tbl_ürün.Count().ToString();
            label5.Text = db.Tbl_Musteri.Count(X=> X.DURUM == true).ToString();
            label7.Text = db.Tbl_Musteri.Count(X=> X.DURUM == false).ToString();
            label13.Text = db.Tbl_ürün.Sum(Y=> Y.STOK).ToString();
            label21.Text = db.Tbl_Satis.Sum(Z=> Z.FIYAT).ToString();
            label11.Text = (from x in db.Tbl_ürün orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label9.Text = (from y in db.Tbl_ürün orderby y.FIYAT ascending select y.URUNAD).FirstOrDefault();
            label15.Text = db.Tbl_ürün.Count(X => X.KATEGORİ == 1).ToString();
            label17.Text = db.Tbl_ürün.Count(X => X.URUNAD == "BUZDOLABI").ToString();
            label23.Text = (from x in db.Tbl_Musteri select x.SEHIR).Distinct().Count().ToString();
            label19.Text = db.MARKAGETIR().FirstOrDefault();
        }
    }
}
