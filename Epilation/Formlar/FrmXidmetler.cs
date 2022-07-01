using DevExpress.XtraEditors;
using Epilation.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epilation.Formlar
{
    public partial class FrmXidmetler : Form
    {
        public FrmXidmetler()
        {
            InitializeComponent();
        }
        EpilationDbEntities db = new EpilationDbEntities();
        void XidmetleriListele()
        {

            var degerler = (from serv in db.tblservices
                            select new
                            {
                                serv.ServiceID,
                                serv.ServiceName,
                                serv.ServicePrice

                            }).ToList();

            gridControl1.DataSource = degerler;

        }
        private void BtnListele_Click(object sender, EventArgs e)
        {
            XidmetleriListele();
        }

        private void BtnElaveEt_Click(object sender, EventArgs e)
        {
            tblservice serv = new tblservice();
            serv.ServiceName = txtName.Text;
            serv.ServicePrice = Convert.ToDecimal(txtPrice.Text);
            db.tblservices.Add(serv);
            db.SaveChanges();
            XtraMessageBox.Show("Xidmet sisteme elave olundu", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XidmetleriListele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblservices.Find(id);
            db.tblservices.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Xidmeti sildiniz", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            XidmetleriListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ServiceID").ToString();
            txtName.Text = gridView1.GetFocusedRowCellValue("ServiceName").ToString();
            txtPrice.Text = gridView1.GetFocusedRowCellValue("ServicePrice").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblservices.Find(id);
            deger.ServiceName = txtName.Text;
            deger.ServicePrice = Convert.ToDecimal(txtPrice.Text);
            db.SaveChanges();
            XtraMessageBox.Show("Xidmeti Guncellediniz", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XidmetleriListele();
        }

        private void FrmXidmetler_Load(object sender, EventArgs e)
        {
            XidmetleriListele();
            gridView1.Columns["ServiceID"].Visible = false;
        }
    }
}
