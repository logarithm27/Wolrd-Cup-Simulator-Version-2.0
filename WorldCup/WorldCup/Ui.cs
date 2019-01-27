﻿/*Maftoul Omar 2019*/

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace WorldCup
{
    public  class Ui
    {
        private List<Rectangle> _rectangles;
        public List<Rectangle> Rectangles()=>_rectangles;
        private readonly Dictionary<object, object> _confederationsImages;
        private ListBox _teamSelector;
        public ListBox TeamSelector { get => _teamSelector; set => _teamSelector = value; }

        public Ui(ref Canvas canvas)
        {
            _rectangles = new List<Rectangle>();
            _confederationsImages = new Dictionary<object,object>();
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
                Rule.MxNumOfConfederations);
            TeamSelector = new ListBox(){Width = 135,Height = 80};
            AddElementOnCanvas(TeamSelector, 550,128, ref canvas);
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
            InitRectanglesOnPots(left, top -(double)UiParameters.CanvasPotsParameters.AddByOnCanvasTop, ref canvas);
        }


        private void AddRectangleOnCanvas(double left, double top, ref Canvas canvas)
        {
            var rectangle = CreateRectangle();
            AddElementOnCanvas(rectangle, left, top, ref canvas);
            //add rectangles to List of rectangles
            _rectangles.Add(rectangle);
        }

        private void AddElementOnCanvas(UIElement element,double left,double top, ref Canvas canvas)
        {
            Canvas.SetTop(element,top);
            Canvas.SetLeft(element,left);
            canvas.Children.Add(element);
        }
        private Rectangle CreateRectangle()
        {
            var rectangle =  new Rectangle
            {
                Height = (double) UiParameters.ShapeParameters.Height,
                Width = (double) UiParameters.ShapeParameters.Width,
                Stroke = Brushes.Black,
                Fill = (Brush)new BrushConverter().ConvertFromString("#FFF4F4F5"),
                StrokeThickness = (double) UiParameters.ShapeParameters.StrokeThickness
        };
            rectangle.MouseLeftButtonUp += OnRectangleClick;
            return rectangle;
        }
        //Create Images of confederation
        private void CreateImages(double left, double top, ref Canvas canvas, int imageNumber)
        {
            while (true)
            {
                if (top < 0) return;
                var confederation = ((Confederation.ConfederationCode)imageNumber).DescriptionAttr();
                var image = new Image {Width = (double) UiParameters.ImageParameters.Width, Height = (double) UiParameters.ImageParameters.Height, Cursor = Cursors.Hand, ToolTip = confederation, Source = new BitmapImage(new Uri(@"pack://application:,,,/ConfederationImages/" + imageNumber + ".png")) };
                image.MouseEnter += onMouseOverImage;
                image.MouseLeave += onMouseOutsideImage;
                image.MouseLeftButtonUp += OnMouseClickImage;
                _confederationsImages.Add(confederation, image);
                AddElementOnCanvas(image, left, top, ref canvas);
                top -= (double) UiParameters.ImageParameters.AddByOnTop;
                imageNumber--;
            }
        }

        private void onMouseOverImage(object sender, MouseEventArgs e)
        {
            var image = (Image) sender;
            image.Opacity = 0.5;
        }

        private void onMouseOutsideImage(object sender, MouseEventArgs e)
        {
            var image = (Image) sender;
            image.Opacity = 1;
        }
        /*Dumb method*/
        private void OnMouseClickImage(object sender, MouseEventArgs e)
        {
            _teamSelector.Items.Clear();
            _teamSelector.Items.Insert(0, Utility.GetKeyByValue(_confederationsImages, sender));
            //Get the corresponding confederation to the clicked image and insert on combobox's first item
            for (int i = 1; i < 80; i++)
            {
                var confederation = "test";
                Label label = new Label();
                label.Content = confederation;
                Canvas canvas = new Canvas { Width = 45, Height = 25 };
                var rectangle = new Rectangle
                {
                    Width = 40,
                    Height = 20,
                    Stroke = Brushes.Black,
                };
                Canvas.SetTop(rectangle, 3);
                Canvas.SetLeft(rectangle, -1);
                Canvas.SetLeft(label, Canvas.GetLeft(rectangle) + 40);
                canvas.Children.Add(rectangle);
                canvas.Children.Add(label);
                _teamSelector.Items.Insert(i, canvas);
            }
        }

        private void OnRectangleClick(object sender, MouseEventArgs e)
        {  
                var rectangle = (Rectangle)sender;
            rectangle.Stroke = Brushes.Brown;
            rectangle.Effect=new DropShadowEffect();
            /*TO DO*/

        }

    }
}