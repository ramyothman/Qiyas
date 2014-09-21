using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ITDayRegistration
{
    public partial class RegistrationsView : DevExpress.XtraEditors.XtraForm
    {
        public RegistrationsView()
        {
            InitializeComponent();
        }

        private void RegistrationsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.QuickContact' table. You can move, or remove it, as needed.
            this.quickContactTableAdapter.Fill(this.registrationDataSet.QuickContact);

        }

        private void RegistrationsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save(e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save(null);
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Save(FormClosingEventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.BaseView view = gridControl1.FocusedView;
            if (!(view.PostEditor() && view.UpdateCurrentRow()))
            {
                if (e != null)
                    e.Cancel = true;
                return;
            }
            quickContactTableAdapter.Update(registrationDataSet.QuickContact);


        }
    }
}