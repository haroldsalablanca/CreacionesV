﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Atributos que son agregados con respecto a la tabla de origen de la base de datos, estos
//hacen función en las demás capas, a través de los métodos get y set, a si mismo funcionan en las demás entidades.

namespace capaEntidades
{
    public class RedSocial
    {
        public int idRedSocial { get; set; }
        public string NombreR { get; set; }
        public int idCliente { get; set; }
    }
}
