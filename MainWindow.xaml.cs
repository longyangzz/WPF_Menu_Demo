using Dialog;
using Mapsui;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //构建一个底图引擎
            //var mapControl = new Mapsui.UI.Wpf.MapControl();

            //mapControl.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
            //初始化 定位中国经纬度范围
            //MRect mRect = new MRect(73.44696044921875, 18.15999984741211, 135.08544921875, 53.560001373291016);
            //mapControl.Map.Navigator.ZoomToBox(mRect);

            //map.CRS = "EPSG:3857";
            //mapControl.Map.Home = n => n.CenterOnAndZoomTo(new MPoint(12412846.80014016, 3664472.687460804), n.Resolutions[4]);

            //添加到 GridContent中
            //GridMapContent.Children.Add(mapControl);
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void GridTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Dialog_Selected(object sender, RoutedEventArgs e)
        {
            DataImportMain dimport = new DataImportMain();
            dimport.Owner = Application.Current.MainWindow;
            dimport.ShowDialog();
        }
    }
}