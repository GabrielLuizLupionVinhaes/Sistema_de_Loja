﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LojaCL
{
    class clConexao
    {
        private static string str = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\projetos(senai)\\LojaChingLing-master\\DbLoja.mdf;Integrated Security = True; MultipleActiveResultSets=true;Connect Timeout = 30";
        private static SqlConnection con = null;
        public static SqlConnection ObterConexao()
        {
            con = new SqlConnection(str);
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
            }
            catch(SqlException sqle)
            {
                con = null;
            }
            return con;
        }
        public static void fecharConexao()
        {
            if (con != null)
            {
                con.Close();
            }
        }


    }
}