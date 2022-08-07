namespace Epilation.Formlar
{
    partial class FrmTeyinatlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeyinatlar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LueService = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtServiceExPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.LueEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LueCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnElaveEt = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceExPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LueService);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtServiceExPrice);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.LueEmployee);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.LueCustomer);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnElaveEt);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Location = new System.Drawing.Point(970, 5);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(373, 589);
            this.groupControl1.TabIndex = 8;
            // 
            // LueService
            // 
            this.LueService.EditValue = "";
            this.LueService.Location = new System.Drawing.Point(134, 148);
            this.LueService.Name = "LueService";
            this.LueService.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueService.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServiceName", "Service")});
            this.LueService.Properties.Tag = "<Null>";
            this.LueService.Size = new System.Drawing.Size(219, 22);
            this.LueService.TabIndex = 28;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 198);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 16);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Extendent Price:";
            // 
            // txtServiceExPrice
            // 
            this.txtServiceExPrice.Location = new System.Drawing.Point(134, 195);
            this.txtServiceExPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServiceExPrice.Name = "txtServiceExPrice";
            this.txtServiceExPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtServiceExPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtServiceExPrice.Properties.NullText = "0";
            this.txtServiceExPrice.Size = new System.Drawing.Size(219, 22);
            this.txtServiceExPrice.TabIndex = 26;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(51, 104);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 16);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Personel:";
            // 
            // LueEmployee
            // 
            this.LueEmployee.EditValue = "";
            this.LueEmployee.Location = new System.Drawing.Point(134, 101);
            this.LueEmployee.Name = "LueEmployee";
            this.LueEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueEmployee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Personel", "Personel")});
            this.LueEmployee.Properties.Tag = "<Null>";
            this.LueEmployee.Size = new System.Drawing.Size(219, 22);
            this.LueEmployee.TabIndex = 24;
            this.LueEmployee.TextChanged += new System.EventHandler(this.LueEmployee_TextChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(58, 245);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 16);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Musteri:";
            // 
            // LueCustomer
            // 
            this.LueCustomer.EditValue = "";
            this.LueCustomer.Location = new System.Drawing.Point(134, 242);
            this.LueCustomer.Name = "LueCustomer";
            this.LueCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Musteri", "Musteri")});
            this.LueCustomer.Properties.Tag = "<Null>";
            this.LueCustomer.Size = new System.Drawing.Size(219, 22);
            this.LueCustomer.TabIndex = 19;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(58, 151);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 16);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Service:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(134, 535);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(229, 43);
            this.BtnGuncelle.TabIndex = 7;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnElaveEt
            // 
            this.BtnElaveEt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnElaveEt.ImageOptions.Image")));
            this.BtnElaveEt.Location = new System.Drawing.Point(134, 411);
            this.BtnElaveEt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnElaveEt.Name = "BtnElaveEt";
            this.BtnElaveEt.Size = new System.Drawing.Size(229, 43);
            this.BtnElaveEt.TabIndex = 6;
            this.BtnElaveEt.Text = "Elave Et";
            this.BtnElaveEt.Click += new System.EventHandler(this.BtnElaveEt_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(134, 473);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(229, 43);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 92);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 16);
            this.labelControl2.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 57);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Teyinat ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(134, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(219, 22);
            this.txtID.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(1, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(963, 589);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // FrmTeyinatlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 598);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmTeyinatlar";
            this.Text = "Teyinatlar";
            this.Load += new System.EventHandler(this.FrmTeyinatlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceExPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit LueCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnElaveEt;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit LueEmployee;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtServiceExPrice;
        private DevExpress.XtraEditors.LookUpEdit LueService;
    }
}