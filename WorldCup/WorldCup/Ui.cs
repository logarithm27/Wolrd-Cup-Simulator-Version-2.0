/*Maftoul Omar  2019*/

using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WorldCup
{
    public  class Ui
    {

        public List<Rectangle> Rectangles { get; }
        public Ui(ref Canvas canvas)
        {
            Rectangles = new List<Rectangle>();
            InitRectangles
            (
                (double)CanvasParameters.CanvasMaxLeft,
                (double)CanvasParameters.CanvasMaxTop, 
                ref canvas
            );
        }
        private enum ShapeParameters
        {
            Width=40,
            Height=21,
            StrokeThickness = 1,
        }

        private enum CanvasParameters
        {
            CanvasMaxTop = 282,
            CanvasMaxLeft= 490,
            AddByOnCanvasTop = 40,
            AddByOnCanvasLeft = 160,
        }

        private void InitRectangles(double left,double top,ref Canvas canvas)
        {
            if (top<0)
            {
                left -= (double)CanvasParameters.AddByOnCanvasLeft;
                top = (double)CanvasParameters.CanvasMaxTop;
            }
            if (left < 0)
                return;
            AddRectangleOnCanvas(left, top, ref canvas);
            top -= (double)CanvasParameters.AddByOnCanvasTop;
            InitRectangles(left, top, ref canvas);
        }

        private void AddRectangleOnCanvas(double left, double top, ref Canvas canvas)
        {
            var rect = CreateRectangle();
            Canvas.SetTop(rect, top);
            Canvas.SetLeft(rect, left);
            canvas.Children.Add(rect);
            Rectangles.Add(rect);
        }
        private Rectangle CreateRectangle()
        {
             var rect = new Rectangle
            {
                Height = (double)ShapeParameters.Height,
                Width = (double)ShapeParameters.Width,
                Stroke = Brushes.Black,
            };
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FFF4F4F5");
            rect.Fill = brush;
            rect.StrokeThickness = (double)ShapeParameters.StrokeThickness;
            return rect;
        }
    }
}