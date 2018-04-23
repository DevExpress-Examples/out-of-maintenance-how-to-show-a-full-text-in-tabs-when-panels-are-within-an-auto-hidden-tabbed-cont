Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Docking.Paint
Imports DevExpress.XtraBars.Docking.Helpers
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Styles


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			barAndDockingController1.PaintStyles.Add(New MyPaintStyle(barAndDockingController1.PaintStyles))
			barAndDockingController1.PaintStyleName = "FullTabTextStyle"
		End Sub
	End Class

	Public Class MyPaintStyle
		Inherits SkinBarManagerPaintStyle
		Public Sub New(ByVal collection As BarManagerPaintStyleCollection)
			MyBase.New(collection)
		End Sub
		Public Overrides ReadOnly Property Name() As String
			Get
				Return "FullTabTextStyle"
			End Get
		End Property
		Protected Overrides Sub CreatePainters()
			MyBase.CreatePainters()
			fElementsPainter = New MyDockElementsSkinPainter(Me)
		End Sub
	End Class

	Public Class MyDockElementsSkinPainter
		Inherits DockElementsSkinPainter
		Public Sub New(ByVal paintStyle As SkinBarManagerPaintStyle)
			MyBase.New(paintStyle)
		End Sub
		Protected Overrides Sub CreateElementPainters()
			MyBase.CreateElementPainters()
			Me.fHideBarPainter = New MyHideBarPainter(Me)
		End Sub
	End Class

	Public Class MyHideBarPainter
		Inherits HideBarSkinPainter
		Private layout As DockLayout = Nothing
		Public Sub New(ByVal painter As DockElementsSkinPainter)
			MyBase.New(painter)
		End Sub
		Public Overrides Function GetButtonWidth(ByVal dockLayout As DockLayout, ByVal appearance As AppearanceObject, ByVal isHorizontal As Boolean) As Integer
			Dim result As Integer = 0
			Dim g As Graphics = Painter.AddGraphics(Nothing)
			If dockLayout.Tabbed Then
				Try
					Dim imageSize As Integer
					If isHorizontal Then
						imageSize = (GetImageSize(dockLayout).Width)
					Else
						imageSize = (GetImageSize(dockLayout).Height)
					End If
					Dim defImageSize As Integer
					If isHorizontal Then
						defImageSize = (GetDefaultImageSize(dockLayout).Width)
					Else
						defImageSize = (GetDefaultImageSize(dockLayout).Height)
					End If
					Dim imageInterval As Integer
					If imageSize > 0 Then
						imageInterval = (HideBarHorzInterval)
					Else
						imageInterval = (0)
					End If
					For i As Integer = 0 To dockLayout.Count - 1
						If dockLayout(i).Visibility = DockVisibility.Visible Then
							layout = dockLayout(i)
							Dim width As Integer = GetTabButtonWidth(dockLayout(i))
							result += width + TabButtonsInterval
						End If
					Next i
				Finally
					Painter.ReleaseGraphics()
				End Try
			Else
				Return MyBase.GetButtonWidth(dockLayout, appearance, isHorizontal)
			End If
			Return result
		End Function

		Public Overrides Sub DrawHideBarButton(ByVal args As DrawHideBarButtonArgs)
			Dim bounds As Rectangle = args.Bounds
			Dim tabRect As Rectangle = bounds, activeTabBounds As Rectangle = bounds
			Dim dockLayout As DockLayout = args.DockLayout
			If args.DockLayout.Tabbed Then
				For i As Integer = 0 To dockLayout.Count - 1
					Dim size As Integer = GetTabButtonWidth(dockLayout(i))
					If args.IsVertical Then
						If dockLayout.ActiveChildIndex <> i Then
							DrawInactiveTabContainerItem(args, dockLayout(i), GetTabRectByIndex(i, dockLayout, bounds, args.IsVertical), i = 0, False)
						End If
					Else
						If dockLayout.ActiveChildIndex <> i Then
							DrawInactiveTabContainerItem(args, dockLayout(i), GetTabRectByIndex(i, dockLayout, bounds, args.IsVertical), i = 0, False)
						End If
					End If
				Next i
				activeTabBounds = GetTabRectByIndex(args.DockLayout.ActiveChildIndex, dockLayout, bounds, args.IsVertical)
				dockLayout = args.DockLayout.ActiveChild
				bounds = activeTabBounds
				args = New DrawHideBarButtonArgs(args, activeTabBounds, args.IsActive, ObjectState.Normal)
			End If
			DrawHideBarButtonEdges(args)
			If dockLayout Is Nothing Then
				Return
			End If
			DrawHideBarControlButtonContent(args, bounds, dockLayout, Nothing, EdgePositions.None)
		End Sub

		Protected Overrides Function GetTabChildButtonBounds(ByVal dockLayout As DockLayout, ByVal index As Integer, ByVal bounds As Rectangle, ByVal isVertical As Boolean) As Rectangle
			Return GetTabRectByIndex(index, dockLayout, bounds, isVertical)
		End Function

		Private Function GetTabRectByIndex(ByVal index As Integer, ByVal dockLayout As DockLayout, ByVal bounds As Rectangle, ByVal isVertical As Boolean) As Rectangle
			Dim tabRect As Rectangle = bounds
			For i As Integer = 0 To dockLayout.Count - 1
				Dim size As Integer = GetTabButtonWidth(dockLayout(i))
				If isVertical Then
					tabRect = New Rectangle(tabRect.X, tabRect.Y, tabRect.Width, size)
					If i = index Then
						Return tabRect
					End If
					tabRect.Y += size + TabButtonsInterval
				Else
					tabRect = New Rectangle(tabRect.X, tabRect.Y, size, tabRect.Height)
					If i = index Then
						Return tabRect
					End If
					tabRect.X += size + TabButtonsInterval
				End If
			Next i
			Return tabRect
		End Function

		Protected Function GetTabButtonWidth(ByVal layout As DockLayout) As Integer
			Dim appearance As AppearanceObject
			If layout.DockManager.ActivePanel Is layout.Panel Then
				appearance = layout.ActiveTabAppearance
			Else
				appearance = layout.TabsAppearance
			End If
			Dim g As Graphics = Painter.AddGraphics(Nothing)
			Dim imageSize As Integer
			If layout.IsHorizontal Then
				imageSize = (GetImageSize(layout).Width)
			Else
				imageSize = (GetImageSize(layout).Height)
			End If
			Dim defImageSize As Integer
			If layout.IsHorizontal Then
				defImageSize = (GetDefaultImageSize(layout).Width)
			Else
				defImageSize = (GetDefaultImageSize(layout).Height)
			End If
			Dim imageInterval As Integer
			If imageSize > 0 Then
				imageInterval = (HideBarHorzInterval)
			Else
				imageInterval = (0)
			End If
			Dim width As Integer = Math.Max(DockElementsPainter.CalcTextSize(g, appearance, layout.TabText).Width + imageSize + imageInterval, defImageSize) + 10
			Painter.ReleaseGraphics()
			Return width
		End Function
	End Class
End Namespace
