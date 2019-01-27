using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;


namespace WorldCup
{
    /// <summary>
    /// Interaction logic for MainWorldCupWindow.xaml
    /// </summary>
    public partial class MainWorldCupWindow 
    {
        //private List<List<Rectangle>> _pots;
        //private List<Rectangle> _teams;
        private readonly Ui _userInterface;
        public MainWorldCupWindow()
        {
            InitializeComponent();
            //_pots = new List<List<Rectangle>>(Rule.TeamsPerPot);
            _userInterface = new Ui(ref Canvas);
        }


        private void DrawButtonClick(object sender, RoutedEventArgs e)
        {
            var rectanlge = _userInterface.Rectangles()[31];
            var top = Canvas.GetTop(rectanlge);
            var left = Canvas.GetLeft(rectanlge);
            //Translates (moves) an object in the 2-D x-y coordinate system.
            TranslateTransform trans = new TranslateTransform();
            rectanlge.RenderTransform = trans;
            //creates a transition between two double values (From-->To)
            DoubleAnimation topAnimation =
                new DoubleAnimation(
                    top,
                    (double)UiParameters.CanvasGroupsParameters.CanvasMinTop - top,
                    TimeSpan.FromSeconds(5)
                );
            DoubleAnimation leftAnimation =
                new DoubleAnimation(
                    left,
                    (double)UiParameters.CanvasGroupsParameters.CanvasMinLeft
                    + (double)UiParameters.CanvasGroupsParameters.AddByOnCanvasLeft - left,
                    TimeSpan.FromSeconds(5)
                );
            // BeginAnimation Starts an animation for a specified animated property on this element.
            topAnimation.EasingFunction = new BounceEase();
            leftAnimation.EasingFunction = new BounceEase();
            trans.BeginAnimation(TranslateTransform.YProperty, topAnimation);
            trans.BeginAnimation(TranslateTransform.XProperty, leftAnimation);
        }
    }
}
