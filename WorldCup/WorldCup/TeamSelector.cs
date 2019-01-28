using System.Windows;
using System.Windows.Controls;

namespace WorldCup
{
    public class TeamSelector : UIElement
    {
        private ListBox _teamList;
        public ListBox TeamList {get => _teamList;set => _teamList=value;}
        private Label _teamName;
        public Label TeamName { get => _teamName; set => _teamName = value; }
        private Canvas _canvas;


    }
}