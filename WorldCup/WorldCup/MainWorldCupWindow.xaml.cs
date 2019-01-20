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

            //var top = Canvas.GetTop(pot_1_rect_1);
            //var left = Canvas.GetLeft(pot_1_rect_1);
            ////Translates (moves) an object in the 2-D x-y coordinate system.
            //TranslateTransform trans = new TranslateTransform();
            //pot_1_rect_1.RenderTransform = trans;
            ////creates a transition between two double values (From-->To)
            //DoubleAnimation topAnimation = 
            //    new DoubleAnimation(top, 500 - top, TimeSpan.FromSeconds(1));
            //DoubleAnimation leftAnimation = 
            //    new DoubleAnimation(left, 600- left, TimeSpan.FromSeconds(1));
            //// BeginAnimation Starts an animation for a specified animated property on this element.
            //trans.BeginAnimation(TranslateTransform.XProperty, topAnimation);
            //trans.BeginAnimation(TranslateTransform.YProperty, leftAnimation);
            MessageBox.Show(_userInterface.Rectangles.Count.ToString());
        }
    }
}
