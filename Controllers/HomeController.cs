using System.Diagnostics;
using AppPYLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppPYLL.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            var ingresos = 0m;
            var egresos = 0m;
            var clientes = 20;

            List<Pago> pagos;

            pagos = new List<Pago>
            {
                new Pago { Monto = 2000m, FechaPago = DateTime.Now.AddDays(-10), Positivo = true, Descripcion = "Pago de cliente A" },
                new Pago { Monto = 1500m, FechaPago = DateTime.Now.AddDays(-8), Positivo = true, Descripcion = "Pago de cliente B" },
                new Pago { Monto = 3000m, FechaPago = DateTime.Now.AddDays(-5), Positivo = false, Descripcion = "Gasto A" },
                new Pago { Monto = 2500m, FechaPago = DateTime.Now.AddDays(-3), Positivo = true, Descripcion = "Pago de cliente C" },
                new Pago { Monto = 1000m, FechaPago = DateTime.Now.AddDays(-1), Positivo = false, Descripcion = "Gasto B" }
            };

            foreach(var pago in pagos)
            {
                if(pago.Positivo)
                {
                    ingresos += pago.Monto;
                }
                else
                {
                    egresos += pago.Monto;
                }
            }

            ViewData["ingresos"] = ingresos.ToString("C2");
            ViewData["egresos"] = egresos.ToString("C2");
            ViewData["diferencia"] = (ingresos - egresos).ToString("C2");
            ViewData["clientes"] = clientes;
            ViewData["pagos"] = pagos;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
