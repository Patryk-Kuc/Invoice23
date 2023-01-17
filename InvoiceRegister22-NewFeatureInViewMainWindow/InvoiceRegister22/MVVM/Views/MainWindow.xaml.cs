using InvoiceRegister22.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InvoiceRegister22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BrushConverter brushConverter = new BrushConverter();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void DrawerMenu_MenuIconChecked(object sender, RoutedEventArgs e)
        {
            AppBackground.Opacity = 0.02;
            Window.Background = (Brush)brushConverter.ConvertFrom("#FF000000");
            GridView.IsEnabled = false;
            menu.ShadowColor = "#FFFFFFFF";
        }

        private void DrawerMenu_MenuIconUnchecked(object sender, RoutedEventArgs e)
        {
            AppBackground.Opacity = 0.1;
            Window.Background = (Brush)brushConverter.ConvertFrom("#FFFFFFFF");
            GridView.IsEnabled = true;
            menu.ShadowColor = "#FF000000";
        }

    }
}
