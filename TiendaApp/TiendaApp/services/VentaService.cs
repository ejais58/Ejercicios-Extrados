using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.models;

namespace TiendaApp.services
{
    internal class VentaService
    {
        public void pedido(List<Producto> productList, List<Cliente> clientList)
        {
            
            int numero;
            string nombreCliente;
            string tipoFactura;
            List<Producto> carrito = new List<Producto>();
            List<Factura> factura = new List<Factura>();
            object cliente;

            //seleccion de tipo de factura
            Console.Write("Seleccione el tipo de factura: ");
            tipoFactura = Console.ReadLine();

            //Seleccion de cliente
            do
            {
                Console.WriteLine("Seleccione el cliente");
                Console.Write("nombre de cliente: ");
                nombreCliente = Console.ReadLine();
                cliente = clientList.Find(x => x.NombreCompleto.Contains(nombreCliente));
                if (cliente == null)
                {
                    Console.WriteLine("no se encontro cliente...");
                }
                else
                {
                    Console.WriteLine("Cliente seleccionado: ");
                    Console.WriteLine(cliente.ToString());
                }
                
                
            } while (nombreCliente == "");


            //Carrito de compras
            do
            {
                Console.WriteLine("Seleccione los productos que desea comprar");
                Console.Write("Codigo: ");
                int.TryParse(Console.ReadLine(), out numero);
                var producto = productList.Find(x => x.CodigoBarra == numero);
                
                if (producto != null)
                {
                    Console.WriteLine($"codigo: {producto.CodigoBarra}, nombre: {producto.Nombre}, precio: {producto.PrecioVenta}");
                    Console.Write("confirmar (si o no):");
                    string confirmar = Console.ReadLine();
                    if (confirmar == "si")
                    {
                        carrito.Add(producto);
                        double total = 0;
                        foreach (var item in carrito)
                        {
                            Console.WriteLine($"codigo: {item.CodigoBarra}, nombre: {item.Nombre}, precio: {item.PrecioVenta}");
                            total += item.PrecioVenta;
                        }
                        Console.WriteLine(" -------------");
                        Console.WriteLine($"|  Total: {total} |");
                        Console.WriteLine(" -------------");
                    }
                
                }

            } while (numero != 0);
            
            //armar pedido

            
        }

        
    }
}
