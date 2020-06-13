using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();

            this.chart();

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Оплачено",
                    Values = new ChartValues<double> { 345000, 550000, 380000, 250000 }
                }
            };

            SeriesCollection[0].Values.Add(5d);

            Labels = new[]  { "Март", "Апрель", "Май", "Июнь" };
           
            Formatter = value => value.ToString("C");

            DataContext = this;
        }

        public void chart()
        {
            PointLabel = chartPoint =>
             string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataContext = this;
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }


        /*<Wpf:CartesianChart Series= "{Binding SeriesCollection}" LegendLocation= "Left" Margin="655,49,42,270">
                 <Wpf:CartesianChart.AxisX>
                     <Wpf:Axis Title= "Salesman" Labels= "{Binding Labels}"></Wpf:Axis>
                 </Wpf:CartesianChart.AxisX>
                 <Wpf:CartesianChart.AxisY>
                     <Wpf:Axis Title= "Sold Apps" LabelFormatter= "{Binding Formatter}"></Wpf:Axis>
                 </Wpf:CartesianChart.AxisY>
             </Wpf:CartesianChart>
        */



        private void Chart_OnDataClick(object sender, ChartPoint chartPoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartPoint.SeriesView;
            selectedSeries.PushOut = 8;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    new Window1().ShowDialog();
                    break;
                case "ItemCreate":
                    usc = new applicationsControl();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemDelete":
                    usc = new СhatControl();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemSearch":
                    usc = new financeControl();
                    GridMain.Children.Add(usc);
                    break;

                default:
                    break;
            }
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
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

        private void PieSeries_StylusOutOfRange(object sender, StylusEventArgs e)
        {

        }



        



    }

}
