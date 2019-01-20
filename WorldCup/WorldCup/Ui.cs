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
         //Initializing rectangles in each pot
        //Left and Top are margins relatives to the canvas (Rectangles are inside Canvas)
        private void InitRectanglesOnPots(double left,double top,ref Canvas canvas)
        {
            //starting from the highest Top margin value until it reach a negative value
            //we've Initialized all rectangles of the previous pot
            if (top<0)
            {
                //we start again until we have a negative value on left margin
                left -= (double)UiParameters.CanvasPotsParameters.AddByOnCanvasLeft;
                //Initializing rectangles on a new pot
                top = (double)UiParameters.CanvasPotsParameters.CanvasMaxTop;
            }
            //We've done with all rectangles of all pots
            if (left < 0)
                return;
            //Add each rectangle to Canvas
            AddRectangleOnCanvas(left, top, ref canvas);
            //Draw next rectangle on the same pot
            top -= (double)UiParameters.CanvasPotsParameters.AddByOnCanvasTop;
            InitRectanglesOnPots(left, top, ref canvas);
        }


        private void AddRectangleOnCanvas(double left, double top, ref Canvas canvas)
        {
            var rect = CreateRectangle();
            Canvas.SetTop(rect, top);
            Canvas.SetLeft(rect, left);
            canvas.Children.Add(rect);
            //add rectangles to List of rectangles
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