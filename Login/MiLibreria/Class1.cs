﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            string connect = string.Format(@"Data Source=WHITECLAW-PC\MONOGRAFICO30;Initial Catalog=ITLA;User ID=sa;Password=weaponx22");
            SqlConnection Con = new SqlConnection(connect);
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();

            return DS;
        }
    }
}
