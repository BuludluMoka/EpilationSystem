using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Epilation.Entity;

namespace Epilation.Formlar
{
    public partial class FrmHesabat : Form
    {
        public FrmHesabat()
        {
            InitializeComponent();
        }
        EpilationDbEntities db = new EpilationDbEntities();
     
        private void FrmHesabat_Load(object sender, EventArgs e)
        {
            lblPersoneller.Text = db.tblemployees.Count().ToString();
            lblMusteriler.Text = db.tblcustomers.Count().ToString();
            lblTeyinatlar.Text = db.tblservicerendereds.Count().ToString();
            var degerler = (from x in db.tblservicerendereds
                            join b in db.tblemployees on x.EmployeeID equals b.EmployeeID
                            join c in db.tblservices on b.ServiceID equals c.ServiceID
                            select new
                            {
                                Qiymet = c.ServicePrice + x.ServiceExtendedPrice
                            }).Sum(x=> x.Qiymet);
            lblUmumiGelir.Text = degerler.ToString(); 
        }
    }
}
