using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epilation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmPersoneller person;
        
        private void BtnPersonelListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (person == null || person.IsDisposed)
            {
                person = new Formlar.FrmPersoneller();
                person.MdiParent = this;
                person.Show();
            }
            MessageBox.Show("Form1");

        }
        Formlar.FrmXidmetler xidmet;
        private void BtnXidmetListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xidmet == null || xidmet.IsDisposed)
            {

                xidmet = new Formlar.FrmXidmetler();
                xidmet.MdiParent = this;
                xidmet.Show();
            }
        }
        Formlar.FrmMusteriler musteri;
        private void BtnMusteriListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteri == null || musteri.IsDisposed)
            {
                musteri = new Formlar.FrmMusteriler();

                musteri.MdiParent = this;
                musteri.Show();
            }

        }
        Formlar.FrmTeyinatlar teyinat;
        private void BtnTeyinatListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (teyinat == null || teyinat.IsDisposed)
            {
                teyinat = new Formlar.FrmTeyinatlar();
                teyinat.MdiParent = this;
                teyinat.Show();
            }



        }
        Formlar.FrmHesabat hesabat;
        private void BtnHesabat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hesabat == null || hesabat.IsDisposed)
            {
                hesabat = new Formlar.FrmHesabat();
                hesabat.MdiParent = this;
                hesabat.Show();
            }

        }

        private void BtnSelahiyyetler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmSelahiyyetler Selahiyet = new Formlar.FrmSelahiyyetler();
            Selahiyet.Show();
        }

        Formlar.FrmAnasəhifə anasəhifə;
        private void BtnAnaseyfe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anasəhifə == null || anasəhifə.IsDisposed)
            {
                anasəhifə = new Formlar.FrmAnasəhifə();
                anasəhifə.MdiParent = this;
                anasəhifə.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
