/*Maftoul Omar 2019*/

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WorldCup
{
    public  class Ui
    {
        public List<Rectangle> Rectangles { get; }
        public Dictionary<string,Image> ConfederationsImages { get; }
        public Ui(ref Canvas canvas)
        {
            Rectangles = new List<Rectangle>();
            ConfederationsImages = new Dictionary<string,Image>();
            InitRectanglesOnPots
            (
                (double)UiParameters.CanvasPotsParameters.CanvasMaxLeft,
                (double)UiParameters.CanvasPotsParameters.CanvasMaxTop, 
                ref canvas
            );
            CreateImages(
                (double) UiParameters.ImageParameters.Left,
                (double) UiParameters.ImageParameters.Top,
                ref canvas,
                (int) Confederation.ConfederationCode.SouthAmerica);
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
            AddElementOnCanvas(rect, left, top, ref canvas);
            //add rectangles to List of rectangles
            Rectangles.Add(rect);
        }

        private void AddElementOnCanvas(UIElement element,double left,double top, ref Canvas canvas)
        {
            Canvas.SetTop(element,top);
            Canvas.SetLeft(element,left);
            canvas.Children.Add(element);
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

        private void CreateImages(double left, double top, ref Canvas canvas, int imageNumber)
        {
            while (true)
            {
                if (top < 0) return;
                var confederation = (Confederation.ConfederationCode) imageNumber;
                var image = new Image {Width = (double) UiParameters.ImageParameters.Width, Height = (double) UiParameters.ImageParameters.Height, Cursor = Cursors.Hand, ToolTip = confederation.ToString()};
                ConfederationsImages.Add(confederation.ToString(), image);
                AddElementOnCanvas(image, left, top, ref canvas);
                InsertImage(image, imageNumber);
                top -= (double) UiParameters.ImageParameters.AddByOnTop;
                imageNumber--;
            }
        }

        private void InsertImage(Image image,int imageNumber)
        {
            var directory = @"pack://application:,,,/ConfederationImages/";
            var extention = ".png";
            var imageNumberToString = imageNumber.ToString();
            var relativePath = directory + imageNumberToString+extention;
            var url =new Uri(relativePath);
            image.Source = new BitmapImage(url);
        }
    }

    
}