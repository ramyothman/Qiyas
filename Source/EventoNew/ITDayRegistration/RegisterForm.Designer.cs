namespace ITDayRegistration
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.quickContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationDataSet = new ITDayRegistration.RegistrationDataSet();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colQuickContactId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colQuickContactId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colDepartment = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colDepartment = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colEmail = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colEmail = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colOfficePhone = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colOfficePhone = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colMobile = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colMobile = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.item1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.quickContactTableAdapter = new ITDayRegistration.RegistrationDataSetTableAdapters.QuickContactTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colQuickContactId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colOfficePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.quickContactBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.AllowDrop = true;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(627, 359);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // quickContactBindingSource
            // 
            this.quickContactBindingSource.DataMember = "QuickContact";
            this.quickContactBindingSource.DataSource = this.registrationDataSetBindingSource;
            // 
            // registrationDataSetBindingSource
            // 
            this.registrationDataSetBindingSource.DataSource = this.registrationDataSet;
            this.registrationDataSetBindingSource.Position = 0;
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "RegistrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(500, 260);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colQuickContactId,
            this.colName,
            this.colDepartment,
            this.colEmail,
            this.colOfficePhone,
            this.colMobile});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.layoutView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colQuickContactId
            // 
            this.colQuickContactId.AppearanceCell.Font = new System.Drawing.Font("Calibri", 12F);
            this.colQuickContactId.AppearanceCell.Options.UseFont = true;
            this.colQuickContactId.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.colQuickContactId.AppearanceHeader.Options.UseFont = true;
            this.colQuickContactId.Caption = "Id";
            this.colQuickContactId.FieldName = "QuickContactId";
            this.colQuickContactId.LayoutViewField = this.layoutViewField_colQuickContactId;
            this.colQuickContactId.Name = "colQuickContactId";
            this.colQuickContactId.OptionsColumn.ReadOnly = true;
            // 
            // layoutViewField_colQuickContactId
            // 
            this.layoutViewField_colQuickContactId.EditorPreferredWidth = 92;
            this.layoutViewField_colQuickContactId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colQuickContactId.Name = "layoutViewField_colQuickContactId";
            this.layoutViewField_colQuickContactId.Size = new System.Drawing.Size(211, 20);
            this.layoutViewField_colQuickContactId.TextSize = new System.Drawing.Size(110, 13);
            this.layoutViewField_colQuickContactId.TextToControlDistance = 5;
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Calibri", 12F);
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.FieldName = "Name";
            this.colName.LayoutViewField = this.layoutViewField_colName;
            this.colName.Name = "colName";
            // 
            // layoutViewField_colName
            // 
            this.layoutViewField_colName.EditorPreferredWidth = 92;
            this.layoutViewField_colName.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_colName.Name = "layoutViewField_colName";
            this.layoutViewField_colName.Size = new System.Drawing.Size(211, 20);
            this.layoutViewField_colName.TextSize = new System.Drawing.Size(110, 13);
            this.layoutViewField_colName.TextToControlDistance = 5;
            // 
            // colDepartment
            // 
            this.colDepartment.AppearanceCell.Font = new System.Drawing.Font("Calibri", 12F);
            this.colDepartment.AppearanceCell.Options.UseFont = true;
            this.colDepartment.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.colDepartment.AppearanceHeader.Options.UseFont = true;
            this.colDepartment.Caption = "Department/Company";
            this.colDepartment.FieldName = "Department";
            this.colDepartment.LayoutViewField = this.layoutViewField_colDepartment;
            this.colDepartment.Name = "colDepartment";
            // 
            // layoutViewField_colDepartment
            // 
            this.layoutViewField_colDepartment.EditorPreferredWidth = 92;
            this.layoutViewField_colDepartment.Location = new System.Drawing.Point(0, 40);
            this.layoutViewField_colDepartment.Name = "layoutViewField_colDepartment";
            this.layoutViewField_colDepartment.Size = new System.Drawing.Size(211, 20);
            this.layoutViewField_colDepartment.TextSize = new System.Drawing.Size(110, 13);
            this.layoutViewField_colDepartment.TextToControlDistance = 5;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Font = new System.Drawing.Font("Calibri", 12F);
            this.colEmail.AppearanceCell.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.colEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmail.FieldName = "Email";
            this.colEmail.LayoutViewField = this.layoutViewField_colEmail;
            this.colEmail.Name = "colEmail";
            // 
            // layoutViewField_colEmail
            // 
            this.layoutViewField_colEmail.EditorPreferredWidth = 92;
            this.layoutViewField_colEmail.Location = new System.Drawing.Point(0, 62);
            this.layoutViewField_colEmail.Name = "layoutViewField_colEmail";
            this.layoutViewField_colEmail.Size = new System.Drawing.Size(211, 20);
            this.layoutViewField_colEmail.TextSize = new System.Drawing.Size(110, 13);
            this.layoutViewField_colEmail.TextToControlDistance = 5;
            // 
            // colOfficePhone
            // 
            this.colOfficePhone.AppearanceCell.Font = new System.Drawing.Font("Calibri", 12F);
            this.colOfficePhone.AppearanceCell.Options.UseFont = true;
            this.colOfficePhone.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.colOfficePhone.AppearanceHeader.Options.UseFont = true;
            this.colOfficePhone.Caption = "Office Phone";
            this.colOfficePhone.FieldName = "OfficePhone";
            this.colOfficePhone.LayoutViewField = this.layoutViewField_colOfficePhone;
            this.colOfficePhone.Name = "colOfficePhone";
            // 
            // layoutViewField_colOfficePhone
            // 
            this.layoutViewField_colOfficePhone.EditorPreferredWidth = 92;
            this.layoutViewField_colOfficePhone.Location = new System.Drawing.Point(0, 82);
            this.layoutViewField_colOfficePhone.Name = "layoutViewField_colOfficePhone";
            this.layoutViewField_colOfficePhone.Size = new System.Drawing.Size(211, 20);
            this.layoutViewField_colOfficePhone.TextSize = new System.Drawing.Size(110, 13);
            this.layoutViewField_colOfficePhone.TextToControlDistance = 5;
            // 
            // colMobile
            // 
            this.colMobile.AppearanceCell.Font = new System.Drawing.Font("Calibri", 12F);
            this.colMobile.AppearanceCell.Options.UseFont = true;
            this.colMobile.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.colMobile.AppearanceHeader.Options.UseFont = true;
            this.colMobile.FieldName = "Mobile";
            this.colMobile.LayoutViewField = this.layoutViewField_colMobile;
            this.colMobile.Name = "colMobile";
            // 
            // layoutViewField_colMobile
            // 
            this.layoutViewField_colMobile.EditorPreferredWidth = 92;
            this.layoutViewField_colMobile.Location = new System.Drawing.Point(0, 102);
            this.layoutViewField_colMobile.Name = "layoutViewField_colMobile";
            this.layoutViewField_colMobile.Size = new System.Drawing.Size(211, 20);
            this.layoutViewField_colMobile.TextSize = new System.Drawing.Size(110, 13);
            this.layoutViewField_colMobile.TextToControlDistance = 5;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colQuickContactId,
            this.layoutViewField_colName,
            this.layoutViewField_colDepartment,
            this.layoutViewField_colEmail,
            this.layoutViewField_colOfficePhone,
            this.layoutViewField_colMobile,
            this.item1});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // item1
            // 
            this.item1.CustomizationFormText = "item1";
            this.item1.Location = new System.Drawing.Point(0, 60);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(211, 2);
            this.item1.Text = "item1";
            // 
            // quickContactTableAdapter
            // 
            this.quickContactTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(631, 96);
            this.panelControl1.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::ITDayRegistration.Properties.Resources.print_printer;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(155, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 78);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ITDayRegistration.Properties.Resources.Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(25, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 78);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = global::ITDayRegistration.Properties.Resources.wewslogo;
            this.pictureEdit1.Location = new System.Drawing.Point(526, 5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 86);
            this.pictureEdit1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 96);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(631, 363);
            this.panelControl2.TabIndex = 3;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 459);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colQuickContactId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colOfficePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private System.Windows.Forms.BindingSource registrationDataSetBindingSource;
        private RegistrationDataSet registrationDataSet;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colQuickContactId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colQuickContactId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDepartment;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDepartment;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colEmail;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colEmail;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colOfficePhone;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colOfficePhone;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMobile;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMobile;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.SimpleSeparator item1;
        private System.Windows.Forms.BindingSource quickContactBindingSource;
        private RegistrationDataSetTableAdapters.QuickContactTableAdapter quickContactTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}