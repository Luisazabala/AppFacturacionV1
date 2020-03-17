using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacturacionV1
{
    class Producto
    {
        string nombreProducto;
        string estadoProducto = "Habilitado";
        double valorUnitario;
        int cantidad;

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string EstadoProducto { get => estadoProducto; set => estadoProducto = value; }
        public double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double ValorTotal()
        {
            return this.cantidad * this.valorUnitario;
        }
    }
}
