﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

//           Se definen los objetos de cada capa acceso datos para acceder al método propio de esas clases.

//           Se agrega una clase por cada entidad, lo cual tendrá acceso a datos de capa datos
//           Dentro de la clase logicanegocioclientes se define un objeto de la clase
//           accesodatosclientes para acceder a métodos propios de esta clase.

//           Luego se crearán un método por cada uno ubicado en accesodatosclientes.

namespace capaNegocio
{
    public class logicaNegocioClientes
    {
        accesoDatosClientes ac = new accesoDatosClientes();
        public int insertarClientes(Clientes c)
        {
            return ac.insertarClientes(c);
        }

        public List<Clientes> listarClientes()
        {
            return ac.listarClientes();
        }

        public int eliminarClientes(int idclient)
        {
            return ac.eliminarClientes(idclient);
        }

        public int editarClientes(Clientes c)
        {
            return ac.editarClientes(c);
        }

        public List<Clientes> buscarClientes(string dato)
        {
            return ac.buscarClientes(dato);
        }
    }
}
