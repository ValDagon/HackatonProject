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
using System.Windows.Shapes;

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Логика взаимодействия для StartRegister1.xaml
    /// </summary>
    public partial class StartRegister1 : Window
    {
        public StartRegister1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.Sleep(500);// задежка в 0.5 секунд
            Application.Current.Shutdown(); // закрытие программы 

            this.WindowState = WindowState.Minimized; // свернуть программу

        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            this.WindowState = WindowState.Minimized; // свернуть программу

        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            usc = new StartLogin();
            GlobalGrid.Children.Add(usc);
        }
    }
}
