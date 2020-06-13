using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using HackatonProject.Data;

using Microcharts;
using SkiaSharp;

namespace HackatonProject.ViewModels.MicroCharts
{
    public class VentasViewModel : BaseViewModel
    {
        private Chart _ventasChart;

        public Chart VentasChart
        {
            get { return _ventasChart; }
            set { SetProperty(ref _ventasChart, value); }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private List<string> _colors;

        public VentasViewModel(string title, Chart chartType, List<string> colors)
        {
            _ventasChart = chartType;
            _colors = new List<string>() { "#FFCC33", "#00FF66", "#33CC33", "#009900", "#0099FF" };
            _title = $"Финансы (MicroCharts - {title})";

            InicializarAsync();
        }

        private async Task InicializarAsync()
        {
            var ventas = await MockDatabase.ObtenerVentas();

            _ventasChart.Entries = ventas.Select(
                (v, index) => new Entry(v.Monto)
                {
                    Color = SKColor.Parse(_colors[index]),
                });
            VentasChart.LabelTextSize = 50;
        }
    }
}
