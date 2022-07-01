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
    public partial class FrmTeyinatlar : Form
    {
        public FrmTeyinatlar()
        {
            InitializeComponent();
        }
        EpilationDbEntities db = new EpilationDbEntities();
        public void TeyinatlariListele()
        {
            gridControl1.DataSource = (from x in db.tblservicerendereds
                                       select new
                                       {
                                           ID = x.AppointmentID,
                                           Personel = x.tblemployee.EmpFirstName + " " + x.tblemployee.EmpLastName,
                                           x.tblemployee.tblservice.ServiceName,
                                           x.CreatedDate,
                                           Musteri = x.tblcustomer.CustFirstName + " " + x.tblcustomer.CustLastName,
                                           ExPrice = x.ServiceExtendedPrice
                                       }).ToList();
        }
        public void MusterileriDoldur()
        {
            var Musteriler = from x in db.tblcustomers
                             select new
                             {
                                 x.CustomerID,
                                 Musteri = x.CustFirstName + " " + x.CustLastName
                             };
            LueCustomer.Properties.ValueMember = "CustomerID";
            LueCustomer.Properties.DisplayMember = "Musteri";
            LueCustomer.Properties.DataSource = Musteriler.ToList();

        }
        public void PersonelDoldur()
        {

            var Personeller = (from x in db.tblemployees
                               select new
                               {
                                   x.EmployeeID,
                                   Personel = x.EmpFirstName + " " + x.EmpLastName,

                               }).ToList();



            LueEmployee.Properties.ValueMember = "EmployeeID";
            LueEmployee.Properties.DisplayMember = "Personel";
            LueEmployee.Properties.DataSource = Personeller;
        }
        private void FrmTeyinatlar_Load(object sender, EventArgs e)
        {

            TeyinatlariListele();

            MusterileriDoldur();


            PersonelDoldur();







        }

        private void BtnElaveEt_Click(object sender, EventArgs e)
        {
            tblservicerendered rd = new tblservicerendered();
            rd.CreatedDate = DateTime.Now;
            rd.ServiceExtendedPrice = decimal.Parse(txtServiceExPrice.Text);
            rd.EmployeeID = int.Parse(LueEmployee.EditValue.ToString());
            rd.CustomerID = int.Parse(LueCustomer.EditValue.ToString());
            db.tblservicerendereds.Add(rd);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni gorus elave edildi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TeyinatlariListele();
        }

        private void LueEmployee_TextChanged(object sender, EventArgs e)
        {
            int ServiceID = int.Parse(LueEmployee.EditValue.ToString());
            var Service = (from x in db.tblemployees
                           where x.EmployeeID == ServiceID
                           select new
                           {
                               x.ServiceID,
                               x.tblservice.ServiceName
                           }).ToList();

            LueService.Properties.ValueMember = "ServiceID";
            LueService.Properties.DisplayMember = "ServiceName";
            LueService.Properties.DataSource = Service.ToList();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblservicerendereds.Find(id);
            db.tblservicerendereds.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Teyinati sildiniz", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            TeyinatlariListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtServiceExPrice.Text = gridView1.GetFocusedRowCellValue("ExPrice").ToString();
            LueEmployee.Text = gridView1.GetFocusedRowCellValue("Personel").ToString();
            LueService.Text = gridView1.GetFocusedRowCellValue("ServiceName").ToString();
            LueCustomer.Text = gridView1.GetFocusedRowCellValue("Musteri").ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblservicerendereds.Find(id);
            deger.EmployeeID = int.Parse(LueEmployee.EditValue.ToString());
            deger.CustomerID = int.Parse(LueCustomer.EditValue.ToString());
            deger.ServiceExtendedPrice = decimal.Parse(txtServiceExPrice.Text);
            db.SaveChanges();
            XtraMessageBox.Show("Teyinat Guncellendi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TeyinatlariListele();
        }
    }
}
