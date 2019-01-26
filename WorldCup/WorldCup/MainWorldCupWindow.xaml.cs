using System.Windows;


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
            _userInterface = new Ui(ref _canvas);
        }


        private void DrawButtonClick(object sender, RoutedEventArgs e)
        {

            //var top = Canvas.GetTop(_userInterface.Rectangles[31]);
            //var left = Canvas.GetLeft(_userInterface.Rectangles[31]);
            ////Translates (moves) an object in the 2-D x-y coordinate system.
            //TranslateTransform trans = new TranslateTransform();
            //_userInterface.Rectangles[31].RenderTransform = trans;
            ////creates a transition between two double values (From-->To)
            //DoubleAnimation topAnimation =
            //    new DoubleAnimation(
            //        top,
            //        (double) UiParameters.CanvasGroupsParameters.CanvasMinTop - top,
            //        TimeSpan.FromSeconds(2.3)
            //    );
            //DoubleAnimation leftAnimation =
            //    new DoubleAnimation(
            //        left,
            //        (double) UiParameters.CanvasGroupsParameters.CanvasMinLeft
            //        + (double) UiParameters.CanvasGroupsParameters.AddByOnCanvasLeft - left,
            //        TimeSpan.FromSeconds(2.3)
            //    );
            //// BeginAnimation Starts an animation for a specified animated property on this element.
            //trans.BeginAnimation(TranslateTransform.YProperty, topAnimation);
            //trans.BeginAnimation(TranslateTransform.XProperty, leftAnimation);
        }
    }
}
