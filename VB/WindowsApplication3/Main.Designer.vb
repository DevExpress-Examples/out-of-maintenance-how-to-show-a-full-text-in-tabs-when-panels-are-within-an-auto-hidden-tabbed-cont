Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Docking
Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.hideContainerBottom = New DevExpress.XtraBars.Docking.AutoHideContainer()
			Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.hideContainerBottom.SuspendLayout()
			Me.panelContainer1.SuspendLayout()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel3.SuspendLayout()
			Me.dockPanel2.SuspendLayout()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' dockManager1
			' 
			Me.dockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() { Me.hideContainerBottom})
			Me.dockManager1.Controller = Me.barAndDockingController1
			Me.dockManager1.Form = Me
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' hideContainerBottom
			' 
			Me.hideContainerBottom.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(254))))))
			Me.hideContainerBottom.Controls.Add(Me.panelContainer1)
			Me.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.hideContainerBottom.Location = New System.Drawing.Point(0, 338)
			Me.hideContainerBottom.Name = "hideContainerBottom"
			Me.hideContainerBottom.Size = New System.Drawing.Size(410, 19)
			' 
			' panelContainer1
			' 
			Me.panelContainer1.ActiveChild = Me.dockPanel1
			Me.panelContainer1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(254))))))
			Me.panelContainer1.Appearance.Options.UseBackColor = True
			Me.panelContainer1.Controls.Add(Me.dockPanel3)
			Me.panelContainer1.Controls.Add(Me.dockPanel1)
			Me.panelContainer1.Controls.Add(Me.dockPanel2)
			Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
			Me.panelContainer1.FloatVertical = True
			Me.panelContainer1.ID = New System.Guid("b1c963c8-f1f6-4649-8afb-8832419fb686")
			Me.panelContainer1.Location = New System.Drawing.Point(0, 0)
			Me.panelContainer1.Name = "panelContainer1"
			Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
			Me.panelContainer1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
			Me.panelContainer1.SavedIndex = 0
			Me.panelContainer1.Size = New System.Drawing.Size(410, 200)
			Me.panelContainer1.Tabbed = True
			Me.panelContainer1.Text = "panelContainer1"
			Me.panelContainer1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(254))))))
			Me.dockPanel1.Appearance.Options.UseBackColor = True
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel1.FloatVertical = True
			Me.dockPanel1.ID = New System.Guid("279f5441-e472-4f82-a8c6-7d9c270c718b")
			Me.dockPanel1.Location = New System.Drawing.Point(2, 24)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(406, 174)
			Me.dockPanel1.Size = New System.Drawing.Size(406, 174)
			Me.dockPanel1.Text = "Output"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(406, 174)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' dockPanel3
			' 
			Me.dockPanel3.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(254))))))
			Me.dockPanel3.Appearance.Options.UseBackColor = True
			Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
			Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel3.ID = New System.Guid("722231be-65d4-4e4b-997d-df65e1e50035")
			Me.dockPanel3.Location = New System.Drawing.Point(2, 24)
			Me.dockPanel3.Name = "dockPanel3"
			Me.dockPanel3.OriginalSize = New System.Drawing.Size(406, 174)
			Me.dockPanel3.Size = New System.Drawing.Size(406, 174)
			Me.dockPanel3.Text = "Error List"
			' 
			' dockPanel3_Container
			' 
			Me.dockPanel3_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel3_Container.Name = "dockPanel3_Container"
			Me.dockPanel3_Container.Size = New System.Drawing.Size(406, 174)
			Me.dockPanel3_Container.TabIndex = 0
			' 
			' dockPanel2
			' 
			Me.dockPanel2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(254))))))
			Me.dockPanel2.Appearance.Options.UseBackColor = True
			Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
			Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel2.ID = New System.Guid("5eacdd56-9d77-46d2-8149-757bcb15d735")
			Me.dockPanel2.Location = New System.Drawing.Point(2, 24)
			Me.dockPanel2.Name = "dockPanel2"
			Me.dockPanel2.OriginalSize = New System.Drawing.Size(406, 174)
			Me.dockPanel2.Size = New System.Drawing.Size(406, 174)
			Me.dockPanel2.Text = "Breakpoints"
			' 
			' dockPanel2_Container
			' 
			Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel2_Container.Name = "dockPanel2_Container"
			Me.dockPanel2_Container.Size = New System.Drawing.Size(406, 174)
			Me.dockPanel2_Container.TabIndex = 0
			' 
			' barAndDockingController1
			' 
			Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(410, 357)
			Me.Controls.Add(Me.hideContainerBottom)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Main"
			Me.Text = "Full Tab Text"
'			Me.Load += New System.EventHandler(Me.OnFormLoad);
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.hideContainerBottom.ResumeLayout(False)
			Me.panelContainer1.ResumeLayout(False)
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel3.ResumeLayout(False)
			Me.dockPanel2.ResumeLayout(False)
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private dockManager1 As DockManager
		Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
		Private hideContainerBottom As AutoHideContainer
	End Class
End Namespace

