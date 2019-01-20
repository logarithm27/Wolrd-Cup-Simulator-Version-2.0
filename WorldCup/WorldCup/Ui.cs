/*Maftoul Omar 2019*/

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
            InitRectanglesOnPots
            (
                (double)UiParameters.CanvasPotsParameters.CanvasMaxLeft,
                (double)UiParameters.CanvasPotsParameters.CanvasMaxTop, 
                ref canvas
            );
        }
      
        private void InitRectanglesOnPots(double left,double top,ref Canvas canvas)
        {
            if (top<0)
            {
                left -= (double)UiParameters.CanvasPotsParameters.AddByOnCanvasLeft;
                top = (double)UiParameters.CanvasPotsParameters.CanvasMaxTop;
            }
            if (left < 0)
                return;
            AddRectangleOnCanvas(left, top, ref canvas);
            top -= (double)UiParameters.CanvasPotsParameters.AddByOnCanvasTop;
            InitRectanglesOnPots(left, top, ref canvas);
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
                Height = (double)UiParameters.ShapeParameters.Height,
                Width = (double)UiParameters.ShapeParameters.Width,
                Stroke = Brushes.Black,
            };
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FFF4F4F5");
            rect.Fill = brush;
            rect.StrokeThickness = (double)UiParameters.ShapeParameters.StrokeThickness;
            return rect;
        }
    }

    
}