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
    public partial class RegisterForm : DevExpress.XtraEditors.XtraForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.QuickContact' table. You can move, or remove it, as needed.
            this.quickContactTableAdapter.Fill(this.registrationDataSet.QuickContact);

        }

        public void Save(FormClosingEventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.BaseView view = gridControl1.FocusedView;
            if (!(view.PostEditor() && view.UpdateCurrentRow()))
            {
                if(e != null)
                    e.Cancel = true;
                return;
            }
            quickContactTableAdapter.Update(registrationDataSet.QuickContact);
            

        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save(e);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (layoutView1.SelectedRowsCount > 0)
            {
                int printId = Convert.ToInt32(layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, colQuickContactId));
                string printName = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, colName).ToString();
                string printDepartment = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, colDepartment).ToString();
                RegisterarPrint print = new RegisterarPrint();
                print.LoadData(printId, printName, printDepartment);
                print.CreateDocument();
                //print.();
            }
        }
    }
}