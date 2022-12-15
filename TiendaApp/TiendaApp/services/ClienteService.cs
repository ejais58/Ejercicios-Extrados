using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.models;

namespace TiendaApp.services
{
    internal class ClienteService
    {
        public List<Cliente> inicializarListaCliente()
        {
            List<Cliente> clienteList = new List<Cliente>()
            {
                new Cliente()
                {
                    Cuil_Cuit = "20376421113",
                    NombreCompleto = "Luis Hernandez",
                    Deuda = 0
                },
                new Cliente()
                {
                    Cuil_Cuit = "20326241583",
                    NombreCompleto = "Roberto Carrizo",
                    Deuda = 0
                },
                new Cliente()
                {
                    Cuil_Cuit = "20356211213",
                    NombreCompleto = "Franco Julian Perez",
                    Deuda = 0
                },
                new Cliente()
                {
                    Cuil_Cuit = "20376421113",
                    NombreCompleto = "Lucas Reales",
                    Deuda = 0
                }
            };

            return clienteList;
        }

        public void agregarCliente(List<Cliente> clienteList, string cuilCuit, string nombreCompleto)
        {
            clienteList.Add(new Cliente()
            {
                Cuil_Cuit = cuilCuit,
                NombreCompleto = nombreCompleto,
                Deuda = 0
            });
        }

        public void listaCliente(List<Cliente> clienteList)
        {
            foreach (var item in clienteList)
            {
                Console.WriteLine($"Cuil/Cuit: {item.Cuil_Cuit}, Nombre completo: {item.NombreCompleto}, Deuda: {item.Deuda}");
            }
        }
    }
}
