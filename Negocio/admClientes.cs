using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class admClientes
    {
        public static List<ClienteIndividuo> ListarClienteIndividuo()
        {
            //TODO
            List<ClienteIndividuo> clientesIndividuos = new List<ClienteIndividuo>();
            clientesIndividuos.Add(new ClienteIndividuo());
            return clientesIndividuos;
        }

        public static List<ClienteIndividuo> ListarClienteIndividuo(string CUIT)
        {
            //TODO SELECT WHERE CUIT
            List<ClienteIndividuo> clientesIndividuos = new List<ClienteIndividuo>();
            clientesIndividuos.Add(new ClienteIndividuo());
            return clientesIndividuos;
        }

        public static List<Empresa> ListarClienteEmpresa()
        {
            //TODO
            List<Empresa> clientesEmpresa = new List<Empresa>();
            clientesEmpresa.Add(new Empresa());
            return clientesEmpresa;
        }

        public static List<Empresa> ListarClienteEmpresa(string CUIT)
        {
            //TODO SELECT WHERE CUIT
            List<Empresa> clientesEmpresa = new List<Empresa>();
            clientesEmpresa.Add(new Empresa());
            return clientesEmpresa;
        }
    }
}
