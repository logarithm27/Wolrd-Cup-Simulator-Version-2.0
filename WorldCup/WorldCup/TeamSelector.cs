using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WorldCup
{
    public class TeamSelector : UIElement
    {
        private ListBox _teamList;
        public ListBox TeamList() => _teamList;
        private Dictionary<object,object> _teamsInDropDownMenu;
        public Dictionary<object, object> TeamsInDropDownMenu => _teamsInDropDownMenu;
        public TeamSelector()
        {
            _teamList = new ListBox{Width= 135,Height = 80};
            _teamsInDropDownMenu=new Dictionary<object, object>();
        }

        public void OnImageClick(object sender,Dictionary<object,object> _confederationsImages)
        {
            _teamList.Items.Clear();
            _teamList.Items.Insert(0, Utility.GetKeyByValue(_confederationsImages, sender));
            for (int i = 1; i < 80; i++)
            {
                var confederation = "test"+i;
                Label label = new Label();
                label.Content = confederation;
                Canvas canvas = new Canvas { Width = 45, Height = 25 };
                var rectangle = new Rectangle
                {
                    Width = (double)UiParameters.ShapeParameters.Width,
                    Height = (double)UiParameters.ShapeParameters.Height,
                    Stroke = Brushes.Black,
                };
                Canvas.SetTop(rectangle, 3);
                Canvas.SetLeft(rectangle, -1);
                Canvas.SetLeft(label, Canvas.GetLeft(rectangle) + 40);
                canvas.Children.Add(rectangle);
                canvas.Children.Add(label);
                canvas.MouseLeftButtonUp += OnTeamSelected;
               _teamList.Items.Insert(i, canvas);
                _teamsInDropDownMenu.Add(canvas,label);
            }

        }

        private void OnTeamSelected(object sender, MouseEventArgs e)
        {
            var team =(Label)Utility.GetKeyByValue(TeamsInDropDownMenu, sender);
            MessageBox.Show(team.Content.ToString());
        }


    }
}