namespace ITDayRegistration
{
    partial class LabelReportPrinting
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xcellId = new DevExpress.XtraReports.UI.XRLabel();
            this.xcellDepartment = new DevExpress.XtraReports.UI.XRLabel();
            this.xcellName = new DevExpress.XtraReports.UI.XRLabel();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.Detail.HeightF = 101F;
            this.Detail.MultiColumn.ColumnSpacing = 15F;
            this.Detail.MultiColumn.ColumnWidth = 210F;
            this.Detail.MultiColumn.Direction = DevExpress.XtraReports.UI.ColumnDirection.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel1.CanGrow = false;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xcellId,
            this.xcellDepartment,
            this.xcellName});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(199F, 99F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xcellId
            // 
            this.xcellId.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xcellId.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xcellId.LocationFloat = new DevExpress.Utils.PointFloat(128.3333F, 4.916668F);
            this.xcellId.Name = "xcellId";
            this.xcellId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xcellId.SizeF = new System.Drawing.SizeF(66.66667F, 23F);
            this.xcellId.StylePriority.UseBorders = false;
            this.xcellId.StylePriority.UseFont = false;
            this.xcellId.StylePriority.UseTextAlignment = false;
            this.xcellId.Text = "1323";
            this.xcellId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xcellDepartment
            // 
            this.xcellDepartment.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xcellDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xcellDepartment.LocationFloat = new DevExpress.Utils.PointFloat(5F, 67.00001F);
            this.xcellDepartment.Name = "xcellDepartment";
            this.xcellDepartment.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xcellDepartment.SizeF = new System.Drawing.SizeF(190F, 23F);
            this.xcellDepartment.StylePriority.UseBorders = false;
            this.xcellDepartment.StylePriority.UseFont = false;
            this.xcellDepartment.StylePriority.UseTextAlignment = false;
            this.xcellDepartment.Text = "Computer Department";
            this.xcellDepartment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xcellName
            // 
            this.xcellName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xcellName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xcellName.LocationFloat = new DevExpress.Utils.PointFloat(5F, 32.91667F);
            this.xcellName.Name = "xcellName";
            this.xcellName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xcellName.SizeF = new System.Drawing.SizeF(190F, 23F);
            this.xcellName.StylePriority.UseBorders = false;
            this.xcellName.StylePriority.UseFont = false;
            this.xcellName.StylePriority.UseTextAlignment = false;
            this.xcellName.Text = "Ramy Mohamed Mostafa";
            this.xcellName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 0F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 98F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // LabelReportPrinting
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 98);
            this.PageHeight = 200;
            this.PageWidth = 300;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PaperName = "User defined";
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRLabel xcellName;
        private DevExpress.XtraReports.UI.XRLabel xcellId;
        private DevExpress.XtraReports.UI.XRLabel xcellDepartment;
    }
}
