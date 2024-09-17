using Microsoft.Maui.Maps;
namespace Maps
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            var location = new Location(-23.51932790342499, -46.59672490400843);
            var mapSpan = new MapSpan(location, 0.01, 0.01);
            map.MoveToRegion(mapSpan);
        }

    }

}
