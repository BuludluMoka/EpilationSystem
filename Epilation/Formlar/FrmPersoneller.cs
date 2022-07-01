using DevExpress.XtraEditors;
using Epilation.Entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Epilation.Formlar
{
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        
        EpilationDbEntities db = new EpilationDbEntities();
       
        void PersonelListele()
        {
            EpilationDbEntities db = new EpilationDbEntities();
            var degerler = from em in db.tblemployees
                           where em.Durumu == true
                           select new
                           {
                               ID= em.EmployeeID,
                               Name =  em.EmpFirstName,
                               LastName=em.EmpLastName,
                               Service = em.tblservice.ServiceName,
                               Phone = em.EmpPhoneNumber,
                               em.Salary,
                               em.JobDesc,
                               Street= em.EmpStreet,

                           };

            gridControl1.DataSource = degerler.ToList();

        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            PersonelListele();
            gridView1.Columns["ID"].Visible = false;
            var services = (from x in db.tblservices
                           select new
                           {
                               x.ServiceID,
                               x.ServiceName
                           }).ToList();
                           
            lookUpEdit1.Properties.ValueMember = "ServiceID";
            lookUpEdit1.Properties.DisplayMember = "ServiceName";
            lookUpEdit1.Properties.DataSource = services; 
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void BtnElaveEt_Click(object sender, EventArgs e)
        {
            tblemployee em = new tblemployee();
            em.ServiceID = int.Parse(lookUpEdit1.EditValue.ToString());
            em.EmpFirstName = txtFirstName.Text;
            em.EmpLastName = txtLastName.Text;
            em.EmpPhoneNumber = txtNumber.Text;
            em.EmpStreet = txtStreet.Text;
            em.Salary = int.Parse(txtSalary.Text);
            em.JobDesc = txtJobDesc.Text;
            em.Durumu = true;
            db.tblemployees.Add(em);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Personel elave edildi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblemployees.Find(id);
            deger.Durumu = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personeli sildiniz", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PersonelListele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.tblemployees.Find(id);
            deger.ServiceID = int.Parse(lookUpEdit1.EditValue.ToString());
            deger.EmpFirstName = txtFirstName.Text;
            deger.EmpLastName = txtLastName.Text;
            deger.EmpPhoneNumber = txtNumber.Text;
            deger.EmpStreet = txtStreet.Text;
            deger.Salary = int.Parse(txtSalary.Text);
            deger.JobDesc = txtJobDesc.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Personel Guncellendi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtFirstName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            txtLastName.Text = gridView1.GetFocusedRowCellValue("LastName").ToString();
            txtNumber.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
            txtStreet.Text = gridView1.GetFocusedRowCellValue("Street").ToString();
            txtSalary.Text = gridView1.GetFocusedRowCellValue("Salary").ToString();
            txtJobDesc.Text = gridView1.GetFocusedRowCellValue("JobDesc").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Service").ToString();
        }
    }
}
