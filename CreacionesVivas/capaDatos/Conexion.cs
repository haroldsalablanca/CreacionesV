﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capaDatos
{
    class Conexion
    {
        public SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=HAROLD-SALABLAN;Initial Catalog=BD_CREACIONESVIVAS;Integrated Security=True";
            return cn;
        }
    }
}
