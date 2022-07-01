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
    public partial class FrmSelahiyyetler : Form
    {
        public FrmSelahiyyetler()
        {
            InitializeComponent();
        }
        EpilationDbEntities db = new EpilationDbEntities();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var adminval = db.tbladmins.Where(x => x.Kullanici == txtLogin.Text && x.Sifre == txtPassword.Text).FirstOrDefault();
            if (adminval !=null)
            {
                XtraMessageBox.Show("Xos geldiniz", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin admin = new Admin();
                this.Hide();
                admin.Show();
                
             
                
                
            }
            else
            {
                XtraMessageBox.Show("Yanlis giris","Melumat",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
