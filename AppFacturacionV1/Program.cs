using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacturacionV1
{
    class Program
    {
        static void Main(string[] args)
        {
                List<Factura> listaFacturas = new List<Factura>();
                int respuesta = 0;
                int numeroFactura;
                bool resp = true;


                while (respuesta != 5)
                {
                    Console.WriteLine("Digite (1) para facturar, (2) ver todas (3) para consultar,"
                        + " (4) para modificar o (5) para salir");

                    respuesta = int.Parse(Console.ReadLine());

                    if (respuesta == 1)
                    {
                        //Obtenemos los datos de la factura
                        //Construimos la factura

                        Factura factura = new Factura();
                        Console.WriteLine("Nombre del cliente: ");
                        factura.nombreCliente = Console.ReadLine();
                        Console.WriteLine("Documento del cliente: ");
                        factura.documentoCliente = int.Parse(Console.ReadLine());
                        Console.WriteLine("Telefono del cliente: ");
                        factura.telefonoCliente = int.Parse(Console.ReadLine());
                        numeroFactura = listaFacturas.Count + 1;
                        factura.numeroFactura = numeroFactura;

                        //Agregamos productos a la factura


                        while (resp)
                        {
                            Producto producto = new Producto();

                            Console.WriteLine("Ingrese el nombre del producto ");
                            producto.NombreProducto = Console.ReadLine();

                            Console.WriteLine("Ingrese la cantidad ");
                            producto.Cantidad = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el valor unitario ");
                            producto.ValorUnitario = double.Parse(Console.ReadLine());

                            factura.totalFactura = factura.totalFactura + producto.ValorTotal();

                            factura.productos.Add(producto);

                            Console.WriteLine("¿Desea seguir ingresando productos?");

                            if (Console.ReadLine().Equals("no"))
                            {
                                resp = false;
                            }
                        }

                        //Guardar la factura en la lista
                        listaFacturas.Add(factura);

                    }
                    else if (respuesta == 2)
                    {
                        foreach (Factura factura in listaFacturas)
                        {
                            Console.WriteLine("Numero de factura: " + factura.numeroFactura + " Estado: " + factura.estadoCliente
                                + " Fecha: " + factura.fecha + " Cliente: " + factura.nombreCliente
                                + " Total factura: " + factura.totalFactura);
                        }

                    }
                    else if (respuesta == 3)
                    {
                        Console.WriteLine("* (1) Buscar por numero de factura " +
                            "(2) Por cliente");
                        respuesta = int.Parse(Console.ReadLine());

                        if (respuesta == 1)
                        {
                            Console.WriteLine("Ingrese el numero de la factura");
                            numeroFactura = int.Parse(Console.ReadLine());

                            foreach (var factura in listaFacturas)
                            {
                                if (factura.numeroFactura == numeroFactura)
                                {
                                    Console.WriteLine("----------Encabezado Factura----------");
                                    Console.WriteLine("Numero de factura : " + factura.numeroFactura
                                        + " Fecha: " + factura.fecha + " Cliente: " + factura.nombreCliente
                                        + " Total factura: " + factura.totalFactura);

                                    Console.WriteLine("----------Detalle Factura----------");

                                    foreach (Producto producto in factura.productos)
                                    {
                                        Console.WriteLine("NombreProducto: " + producto.NombreProducto
                                            + " Cantidad: " + producto.Cantidad + " Valor Unitario: $"
                                            + producto.ValorUnitario + " Valor Total: $" + producto.ValorTotal()
                                        );
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese el nombre del cliente");
                            string nombreCliente = Console.ReadLine();

                            foreach (var factura in listaFacturas)
                            {
                                if (factura.nombreCliente.Equals(nombreCliente))
                                {
                                    Console.WriteLine("Numero de factura : " + factura.numeroFactura
                                    + " Fecha: " + factura.fecha + " Cliente: " + factura.nombreCliente
                                    + " Total factura: " + factura.totalFactura);
                                }
                            }

                        }
                    }
                    else if (respuesta == 4)
                    {
                        Console.WriteLine("Desea cambiar de estado al cliente o al producto?");
                        string cambiarQue = Console.ReadLine();
                        if (cambiarQue == "cliente")
                        {
                            foreach (var factura in listaFacturas)
                            {
                                factura.estadoCliente = "inhabilitado";
                            }
                        }
                        else
                        {
                            Producto producto = new Producto();
                            producto.EstadoProducto = "Inhabilitado";
                        }
                    }
                    Console.ReadKey();
                }
            }
        }
    } }

