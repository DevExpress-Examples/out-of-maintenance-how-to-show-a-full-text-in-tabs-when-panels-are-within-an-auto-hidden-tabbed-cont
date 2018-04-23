using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Docking.Paint;
using DevExpress.XtraBars.Docking.Helpers;
using DevExpress.Utils;
using DevExpress.XtraBars.Styles;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e) {
            barAndDockingController1.PaintStyles.Add(new MyPaintStyle(barAndDockingController1.PaintStyles));
            barAndDockingController1.PaintStyleName = "FullTabTextStyle";
        }
    }

    public class MyPaintStyle : SkinBarManagerPaintStyle
    {
        public MyPaintStyle(BarManagerPaintStyleCollection collection)
            : base(collection)
        {
        }
        public override string Name { get { return "FullTabTextStyle"; } }
        protected override void CreatePainters()
        {
            base.CreatePainters();
            fElementsPainter = new MyDockElementsSkinPainter(this);
        }
    }

    public class MyDockElementsSkinPainter : DockElementsSkinPainter
    {
        public MyDockElementsSkinPainter(SkinBarManagerPaintStyle paintStyle) : base(paintStyle) { }
        protected override void CreateElementPainters()
        {
            base.CreateElementPainters();
            this.fHideBarPainter = new MyHideBarPainter(this);
        }
    }

    public class MyHideBarPainter : HideBarSkinPainter
    {
        DockLayout layout = null;
        public MyHideBarPainter(DockElementsSkinPainter painter) : base(painter) { }
        public override int GetButtonWidth(DockLayout dockLayout, AppearanceObject appearance, bool isHorizontal)
        {
            int result = 0;
            Graphics g = Painter.AddGraphics(null);
            if (dockLayout.Tabbed)
            {
                try
                {
                    int imageSize = (isHorizontal ? GetImageSize(dockLayout).Width : GetImageSize(dockLayout).Height);
                    int defImageSize = (isHorizontal ? GetDefaultImageSize(dockLayout).Width : GetDefaultImageSize(dockLayout).Height);
                    int imageInterval = (imageSize > 0 ? HideBarHorzInterval : 0);
                    for (int i = 0; i < dockLayout.Count; i++)
                    {
                        if (dockLayout[i].Visibility == DockVisibility.Visible)
                        {
                            layout = dockLayout[i];
                            int width = GetTabButtonWidth(dockLayout[i]);
                            result += width + TabButtonsInterval;
                        }
                    }
                }
                finally
                {
                    Painter.ReleaseGraphics();
                }
            }
            else return base.GetButtonWidth(dockLayout, appearance, isHorizontal);
            return result;
        }
       
        public override void DrawHideBarButton(DrawHideBarButtonArgs args)
        {
            Rectangle bounds = args.Bounds;
            Rectangle tabRect = bounds, activeTabBounds = bounds;
            DockLayout dockLayout = args.DockLayout;
            if (args.DockLayout.Tabbed)
            {
                for (int i = 0; i < dockLayout.Count; i++)
                {
                    int size = GetTabButtonWidth(dockLayout[i]);
                    if (args.IsVertical)
                    {
                        if (dockLayout.ActiveChildIndex != i)
                            DrawInactiveTabContainerItem(args, dockLayout[i], GetTabRectByIndex(i, dockLayout, bounds, args.IsVertical), i == 0, false);
                    }
                    else
                    {
                        if (dockLayout.ActiveChildIndex != i)
                            DrawInactiveTabContainerItem(args, dockLayout[i], GetTabRectByIndex(i, dockLayout, bounds, args.IsVertical), i == 0, false);
                    }
                }
                activeTabBounds = GetTabRectByIndex(args.DockLayout.ActiveChildIndex, dockLayout, bounds, args.IsVertical);
                dockLayout = args.DockLayout.ActiveChild;
                bounds = activeTabBounds;
                args = new DrawHideBarButtonArgs(args, activeTabBounds, args.IsActive, ObjectState.Normal);
            }
            DrawHideBarButtonEdges(args);
            if (dockLayout == null) return;
            DrawHideBarControlButtonContent(args, bounds, dockLayout, null, EdgePositions.None);
        }

        protected override Rectangle GetTabChildButtonBounds(DockLayout dockLayout, int index, Rectangle bounds, bool isVertical)
        {
            return GetTabRectByIndex(index, dockLayout, bounds, isVertical);
        }

        Rectangle GetTabRectByIndex(int index, DockLayout dockLayout, Rectangle bounds, bool isVertical)
        {
            Rectangle tabRect = bounds;
            for (int i = 0; i < dockLayout.Count; i++)
            {
                int size = GetTabButtonWidth(dockLayout[i]);
                if (isVertical)
                {
                    tabRect = new Rectangle(tabRect.X, tabRect.Y, tabRect.Width, size);
                    if (i == index) return tabRect;
                    tabRect.Y += size + TabButtonsInterval;
                }
                else
                {
                    tabRect = new Rectangle(tabRect.X, tabRect.Y, size, tabRect.Height);
                    if (i == index) return tabRect;
                    tabRect.X += size + TabButtonsInterval;
                }
            }
            return tabRect;
        }

        protected int GetTabButtonWidth(DockLayout layout)
        {
            AppearanceObject appearance = layout.DockManager.ActivePanel == layout.Panel ? layout.ActiveTabAppearance : layout.TabsAppearance;
            Graphics g = Painter.AddGraphics(null);
            int imageSize = (layout.IsHorizontal ? GetImageSize(layout).Width : GetImageSize(layout).Height);
            int defImageSize = (layout.IsHorizontal ? GetDefaultImageSize(layout).Width : GetDefaultImageSize(layout).Height);
            int imageInterval = (imageSize > 0 ? HideBarHorzInterval : 0);
            int width = Math.Max(DockElementsPainter.CalcTextSize(g, appearance, layout.TabText).Width + imageSize + imageInterval, defImageSize) + 10;
            Painter.ReleaseGraphics();
            return width;
        }
    }
}
