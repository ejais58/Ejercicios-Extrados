using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.models;

namespace TiendaApp.services
{
    internal class ProductoService
    {
        public List<Producto> InicializarListaProductos()
        {
            List<Producto> productoList = new List<Producto>
            {
                new Producto()
                {
                    CodigoBarra = 6465,
                    Nombre = "chocolate",
                    Descripcion = "blanco",
                    PrecioContado = 45.0,
                    PrecioVenta = 45.0
                },
                new Producto()
                {
                    CodigoBarra = 6468,
                    Nombre = "chocolate",
                    Descripcion = "negro",
                    PrecioContado = 45.0,
                    PrecioVenta = 45.0
                },new Producto()
                {
                    CodigoBarra = 6401,
                    Nombre = "cafe",
                    Descripcion = "clasico suave",
                    PrecioContado = 350.0,
                    PrecioVenta = 350.0
                },new Producto()
                {
                    CodigoBarra = 6463,
                    Nombre = "dulce de leche",
                    Descripcion = "sancor",
                    PrecioContado = 152.0,
                    PrecioVenta = 152.0
                },
                new Producto()
                {
                    CodigoBarra = 6479,
                    Nombre = "coca cola",
                    Descripcion = "2lts",
                    PrecioContado = 150.0,
                    PrecioVenta = 150.0
                }

            };
            return productoList;
        }

        public void CalcularPrecioVenta(List<Producto> productoList, double margen)
        {
            foreach (var item in productoList)
            {
                item.PrecioVenta = item.PrecioContado + (item.PrecioContado * (margen / 100));
            }
            
        }

        public void CalcularPrecioVentaConIva(List<Producto> productoList, double margen, double iva)
        {
            foreach (var item in productoList)
            {
                item.PrecioVenta = item.PrecioContado + (item.PrecioContado * (margen / 100));
                item.PrecioVenta = item.PrecioVenta + (item.PrecioVenta * (iva / 100));
            }

        }

        public void mostrarLista(List<Producto> productoList)
        {
            foreach (var item in productoList)
            {
                Console.WriteLine($"{item.CodigoBarra}, {item.Nombre} - {item.Descripcion}, {item.PrecioContado}, {item.PrecioVenta}");
            }
        }

        public void mostrarProductoPorCodigo(List<Producto> productoList, int codigo)
        {
            //usar metodo de list
            var busqueda = productoList.Find(x => x.CodigoBarra == codigo);
            Console.WriteLine($"{busqueda.CodigoBarra}, {busqueda.Nombre} - {busqueda.Descripcion}, precio venta: {busqueda.PrecioVenta}");
        }

        public void agregarPoducto(List<Producto> productoList, int codigo, string nombre, string descripcion, double precioContado)
        {
            productoList.Add(new Producto()
            {
                CodigoBarra = codigo,
                Nombre = nombre,
                Descripcion = descripcion,
                PrecioContado = precioContado,
                //PrecioVenta = precioContado * (margen / 100)
            });
        }


    }
}
