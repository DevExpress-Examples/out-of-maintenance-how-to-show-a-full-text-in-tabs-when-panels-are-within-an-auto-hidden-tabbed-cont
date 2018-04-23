using DevExpress.XtraBars.Docking;
namespace DXSample {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerBottom = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.hideContainerBottom.SuspendLayout();
            this.panelContainer1.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // dockManager1
            // 
            this.dockManager1.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerBottom});
            this.dockManager1.Controller = this.barAndDockingController1;
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // hideContainerBottom
            // 
            this.hideContainerBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.hideContainerBottom.Controls.Add(this.panelContainer1);
            this.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hideContainerBottom.Location = new System.Drawing.Point(0, 338);
            this.hideContainerBottom.Name = "hideContainerBottom";
            this.hideContainerBottom.Size = new System.Drawing.Size(410, 19);
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dockPanel1;
            this.panelContainer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.panelContainer1.Appearance.Options.UseBackColor = true;
            this.panelContainer1.Controls.Add(this.dockPanel3);
            this.panelContainer1.Controls.Add(this.dockPanel1);
            this.panelContainer1.Controls.Add(this.dockPanel2);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.ID = new System.Guid("b1c963c8-f1f6-4649-8afb-8832419fb686");
            this.panelContainer1.Location = new System.Drawing.Point(0, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.panelContainer1.SavedIndex = 0;
            this.panelContainer1.Size = new System.Drawing.Size(410, 200);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            this.panelContainer1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dockPanel1.Appearance.Options.UseBackColor = true;
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.FloatVertical = true;
            this.dockPanel1.ID = new System.Guid("279f5441-e472-4f82-a8c6-7d9c270c718b");
            this.dockPanel1.Location = new System.Drawing.Point(2, 24);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(406, 174);
            this.dockPanel1.Size = new System.Drawing.Size(406, 174);
            this.dockPanel1.Text = "Output";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(406, 174);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel3
            // 
            this.dockPanel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dockPanel3.Appearance.Options.UseBackColor = true;
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel3.ID = new System.Guid("722231be-65d4-4e4b-997d-df65e1e50035");
            this.dockPanel3.Location = new System.Drawing.Point(2, 24);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.OriginalSize = new System.Drawing.Size(406, 174);
            this.dockPanel3.Size = new System.Drawing.Size(406, 174);
            this.dockPanel3.Text = "Error List";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(406, 174);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dockPanel2.Appearance.Options.UseBackColor = true;
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.ID = new System.Guid("5eacdd56-9d77-46d2-8149-757bcb15d735");
            this.dockPanel2.Location = new System.Drawing.Point(2, 24);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(406, 174);
            this.dockPanel2.Size = new System.Drawing.Size(406, 174);
            this.dockPanel2.Text = "Breakpoints";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(406, 174);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 357);
            this.Controls.Add(this.hideContainerBottom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Full Tab Text";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.hideContainerBottom.ResumeLayout(false);
            this.panelContainer1.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private AutoHideContainer hideContainerBottom;
    }
}

