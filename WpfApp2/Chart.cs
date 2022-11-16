using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WpfApp2
{
    internal class Chart : FrameworkElement
    {
        DrawingVisual visual;
        DrawingGroup group;
        public Chart()
        {
            group = new DrawingGroup();
            visual = new DrawingVisual();
            using (DrawingContext ctx = visual.RenderOpen()) ctx.DrawDrawing(group);
        }

        protected override int VisualChildrenCount => 1;

        int cnt = 0;
        protected override Visual GetVisualChild(int index)
        {
            using (var ctx = group.Open())
            {
#pragma warning disable CS0618
                ctx.DrawText(
                    new FormattedText($"Click Me! {cnt++}",
                        CultureInfo.GetCultureInfo("en-us"),
                        FlowDirection.LeftToRight,
                        new Typeface("Verdana"),
                        36, Brushes.Black),
                    new Point(200 + cnt, 116));
#pragma warning restore CS0618
            }

            return visual;
        }
    }
}
