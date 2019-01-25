/*Maftoul Omar 2019
 * All components (rectangles on pots/groups) are relative to canvas (it's important to remember).
        *VALUES ARE CONSISTENT with :
        *         -The graphical visualization
        *         -Number of rectangles to draw
        *before changing these values, make sure having a nice UI to see,
        *and do the calculations that will varies on how much teams you want to have
        *i.e : i draw a rectangle that have 282 (as max top value),
        * and I drew another one by subtracting -40 from 282 until I reach 0, hence 282/40 ~=7 (I need 8 Teams)
        *Each pot holds 8 rectangles (teams), 
*/
namespace WorldCup
{
    public  struct UiParameters
    {
        //Parameters of rectangles ( rectangles will holds flag of national team)
        public  enum ShapeParameters
        {
            Width = 40,
            Height = 20,
            StrokeThickness = 1,
        }

        public enum ImageParameters
        {
            Width = 50,
            Height=50,
            Top = 260,
            Left = 700,
            AddByOnTop=50
        }
       
        public enum CanvasPotsParameters
        {

            CanvasMaxTop = 282, // Maximum TOP value to not exceed  
            CanvasMaxLeft = 490,
            AddByOnCanvasTop = 40, // i.e : The first Rectangle has a 282 Top Value, hence the next rectangle will have (282-40) on Top Value and etc..
            AddByOnCanvasLeft = 160,
        }

        public enum CanvasGroupsParameters
        {
            CanvasMinTop = 370,
            CanvasMinLeft = 6,
            CanvasMaxTop = 460,
            CanvasMaxLeft = 706,
            AddByOnCanvasTop = 30,
            AddByOnCanvasLeft = 100,
        }

        
    }
}
