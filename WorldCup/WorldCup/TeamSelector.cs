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
        private Canvas _canvas;

        public TeamSelector()
        {
            _teamList = new ListBox{MaxWidth= 135,MaxHeight = 80};
        }
    }
}