using System.Collections.Generic;
using System.Threading.Tasks;

using HackatonProject.Models;
using static HackatonProject.Helpers.MathHelper;

namespace HackatonProject.Data
{
    public static class MockDatabase
    {
        public static async Task<List<Ventas>> ObtenerVentas()
        {
            var li = 1000;
            var ls = 3500;

            return new List<Ventas>()
            {
                new Ventas() { Mes = "Январь", Monto = GetRandomValue(li, ls)},
                new Ventas() { Mes = "Февраль", Monto = GetRandomValue(li, ls)},
                new Ventas() { Mes = "Март", Monto = GetRandomValue(li, ls)},
                new Ventas() { Mes = "Апрель", Monto = GetRandomValue(li, ls)},
                new Ventas() { Mes = "Май", Monto = GetRandomValue(li, ls)},
            };
        }

        public static async Task<double[,]> ObtenerPuntosRastrigin(double x0, double x1, double y0, double y1, int n)
        {
            var xx = CreateVector(x0, x1, n);
            var yy = CreateVector(y0, y1, n);
            var nn = n + 1;

            var datos = new double[nn, nn];

            for (int i = 0; i < nn; i++)
                for (int j = 0; j < nn; j++)
                    datos[i, j] = Rastrigin(xx[i], yy[j]);

            return datos;
        }
    }
}
