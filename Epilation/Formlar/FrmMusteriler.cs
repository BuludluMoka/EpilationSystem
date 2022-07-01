using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Epilation.Entity;

namespace Epilation.Formlar
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
           
        }
        EpilationDbEntities db = new EpilationDbEntities();
       
        void MusterileriListele()
        {
            var degerler = from cust in db.tblcustomers
                           where cust.Durumu == true
                           select new
                           {
                              ID = cust.CustomerID,
                              Name =  cust.CustFirstName,
                              LastName= cust.CustLastName,
                              Phone = cust.CustPhoneNumber,
                              Adress = cust.CustStreet,
                              Gender = cust.CustGender
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            MusterileriListele();
            gridView1.Columns["ID"].Visible = false;
        }

        
        private void BtnElaveEt_Click(object sender, EventArgs e)
        {
            tblcustomer cus = new tblcustomer();
            cus.CustFirstName = txtFirstName.Text;
            cus.CustLastName = txtLastName.Text;
            cus.CustPhoneNumber = txtNumber.Text;
            cus.CustStreet = txtStreet.Text;
            cus.CustGender = cmbGender.Text;
            cus.Durumu = true;
            db.tblcustomers.Add(cus);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni musteri elave edildi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MusterileriListele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtFirstName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            txtLastName.Text = gridView1.GetFocusedRowCellValue("LastName").ToString();
            txtNumber.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
            txtStreet.Text = gridView1.GetFocusedRowCellValue("Adress").ToString();
            cmbGender.Text = gridView1.GetFocusedRowCellValue("Gender").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblcustomers.Find(id);
            
            deger.CustFirstName = txtFirstName.Text;
            deger.CustLastName = txtLastName.Text;
            deger.CustPhoneNumber = txtNumber.Text;
            deger.CustStreet = txtStreet.Text;
            deger.CustGender = cmbGender.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Musteri Guncellendi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MusterileriListele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblcustomers.Find(id);
            deger.Durumu = false;
            db.SaveChanges();
            XtraMessageBox.Show("Musteri silindi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MusterileriListele();
        }
    }
}
