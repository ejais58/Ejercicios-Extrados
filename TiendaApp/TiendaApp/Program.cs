using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.models;
using TiendaApp.services;

namespace TiendaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductoService productoService = new ProductoService();
            ClienteService clienteService = new ClienteService();   
            VentaService ventaService = new VentaService();
            var productoList = productoService.InicializarListaProductos();
            var clienteList = clienteService.inicializarListaCliente();
            int option;
            int codigo;

            //datos iniciales
            Console.WriteLine("::Bienvenido a La tienda::");
            Console.Write("ingrese el margen de ganancia (%): ");
            double margen = double.Parse(Console.ReadLine());
            Console.Write("ingrese el IVA (%): ");
            double iva = double.Parse(Console.ReadLine());
            Console.Write("ingrese deuda maxima: ");
            int deudaMax = int.Parse(Console.ReadLine());
            Tienda tienda = new Tienda(margen, iva, deudaMax);
            
            //menu de opciones
            do
            {
                Console.WriteLine("::: Menu de opciones :::");
                Console.WriteLine("--------------------------");
                Console.WriteLine("-----Productos------");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Mostrar lista de productos (fines administrativos)");
                Console.WriteLine("2. Mostrar lista de productos (precio de venta recalculado)");
                Console.WriteLine("3. Mostrar un producto");
                Console.WriteLine("4. Agregar producto nuevo");
                Console.WriteLine("--------------------------");
                Console.WriteLine("-----Cliente------");
                Console.WriteLine("--------------------------");
                Console.WriteLine("5. Agregar cliente nuevo");
                Console.WriteLine("6. Realizar compra");
                Console.WriteLine("   Presione cualquier tecla para salir");
                Console.Write("Seleccion:");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        productoService.CalcularPrecioVenta(productoList, tienda.MargenDeGanancia);
                        productoService.mostrarLista(productoList);
                        break;
                    case 2:
                        productoService.CalcularPrecioVentaConIva(productoList, tienda.MargenDeGanancia, tienda.IVA);
                        productoService.mostrarLista(productoList);
                        break;
                    case 3:
                        Console.Write("ingrese el codigo del producto: ");
                        codigo = int.Parse(Console.ReadLine());
                        productoService.mostrarProductoPorCodigo(productoList, codigo);
                        break;
                    case 4:
                        Console.WriteLine("------------------------------");
                        Console.Write("codigo de producto: ");
                        codigo = int.Parse(Console.ReadLine());
                        Console.Write("nombre de producto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("descripcion de producto: ");
                        string descripcion = Console.ReadLine();
                        Console.Write("precio contado de producto: ");
                        double precioContado = double.Parse(Console.ReadLine());
                        productoService.agregarPoducto(productoList, codigo, nombre, descripcion, precioContado);
                        break;
                    case 5:
                        Console.WriteLine("------------------------------");
                        Console.Write("ingrese Cuil/Cuit de cliente: ");
                        string cuilCuit = Console.ReadLine();
                        Console.Write("nombre completo del cliente: ");
                        string nombreCliente = Console.ReadLine();
                        clienteService.agregarCliente(clienteList, cuilCuit, nombreCliente);
                        clienteService.listaCliente(clienteList);
                        break;
                    case 6:
                        ventaService.pedido(productoList, clienteList);
                        break;
                }
            } while (option != 0);
            
            
            
            
            

        }
    }
}
