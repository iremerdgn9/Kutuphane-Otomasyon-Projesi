using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Projesi
{
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db= new KutuphaneOtomasyonEntities();

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullanicibtn.Visible = false; //ekle butonu kapalı
            silKullanicibtn.Visible = false; //sil butonu kapalı
            guncelleKullanicibtn.Visible = false;//güncelle butonu kapalı olsun demektir.
            textBox1.Visible = true;
            pictureBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true; //kullanıcılar butonuna basılınca açılacak demektir.
                silKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                textBox1.Visible = false;
                pictureBox1.Visible = false;
            }
            else
            {
                ekleKullanicibtn.Visible = false; //kullanıcı butonu açıksa kapanır yani basılmazsa kapalı konumda olacaklar.
                silKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                textBox1.Visible = true;
                pictureBox1.Visible = true;
            }
            KullaniciListeForm kListeForm = new KullaniciListeForm();
            kListeForm.MdiParent = this; //bunun parent'i IslemPaneli'idir.
            kListeForm.Show();
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            Kullanici.KullaniciEkleForm ekleForm = new Kullanici.KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }
    }
}
