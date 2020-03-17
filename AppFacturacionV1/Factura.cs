using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacturacionV1
{
    class Factura
    {
        public string nombreCliente;
        public int documentoCliente;
        public string estadoCliente = "Habilitado";
        public int telefonoCliente;
        public int numeroFactura;
        public string fecha;
        public double totalFactura = 0;
        public List<Producto> productos = new List<Producto>();
    }
}
