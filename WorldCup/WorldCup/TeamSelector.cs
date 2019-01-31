using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WorldCup
{
    public class TeamSelector : UIElement
    {
        private ListBox _teamList;
        public ListBox TeamList() => _teamList;
        private Label _teamName;
        public Label TeamName { get => _teamName; set => _teamName = value; }
        private Dictionary<object,object> _teamsOfDropDownMenu;

        public TeamSelector()
        {
            _teamList = new ListBox{MaxWidth= 135,MaxHeight = 80};

        }
        // CLIPBOARD
        /*
         *      _teamSelector.Items.Clear();
           _teamSelector.Items.Insert(0, Utility.GetKeyByValue(_confederationsImages, sender));
           
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
         */
    }
}