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

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullanicibtn.Visible = false; //ekle butonu kapalı
            silKullanicibtn.Visible = false; //sil butonu kapalı
            guncelleKullanicibtn.Visible = false;//güncelle butonu kapalı olsun demektir.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true; //kullanıcılar butonuna basılınca açılacak demektir.
                silKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false; //açıksa kapanır.
                silKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
            }
          
        }
    }
}
