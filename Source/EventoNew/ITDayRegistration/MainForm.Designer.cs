namespace ITDayRegistration
{
    partial class MainForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbIRegistration = new DevExpress.XtraBars.BarButtonItem();
            this.bbIRegistrars = new DevExpress.XtraBars.BarButtonItem();
            this.btnDrowal = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.ApplicationIcon = global::ITDayRegistration.Properties.Resources.wewlogonew;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbIRegistration,
            this.bbIRegistrars,
            this.btnDrowal});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.SelectedPage = this.ribbonPage1;
            this.ribbon.Size = new System.Drawing.Size(747, 141);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbIRegistration
            // 
            this.bbIRegistration.Caption = "New Registration";
            this.bbIRegistration.Id = 1;
            this.bbIRegistration.LargeGlyph = global::ITDayRegistration.Properties.Resources.contact_new;
            this.bbIRegistration.Name = "bbIRegistration";
            this.bbIRegistration.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbIRegistration_ItemClick);
            // 
            // bbIRegistrars
            // 
            this.bbIRegistrars.Caption = "Registrars";
            this.bbIRegistrars.Id = 2;
            this.bbIRegistrars.LargeGlyph = global::ITDayRegistration.Properties.Resources.preferences_contact_list;
            this.bbIRegistrars.Name = "bbIRegistrars";
            this.bbIRegistrars.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbIRegistrars_ItemClick);
            // 
            // btnDrowal
            // 
            this.btnDrowal.Caption = "Drowal";
            this.btnDrowal.Id = 3;
            this.btnDrowal.LargeGlyph = global::ITDayRegistration.Properties.Resources._1288094986_Gift_Box;
            this.btnDrowal.Name = "btnDrowal";
            this.btnDrowal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDrowal_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbIRegistration);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbIRegistrars);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDrowal);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Main Group";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 465);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(747, 25);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 490);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbIRegistration;
        private DevExpress.XtraBars.BarButtonItem bbIRegistrars;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnDrowal;
    }
}