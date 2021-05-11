using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WTF_is_My_Password
{
    class Global
    {
        public SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
        public SqlCommand cmd = new SqlCommand();
        //public SqlDataAdapter adp = new SqlDataAdapter();
       // public DataSet ds = new DataSet();

        public void Connecter()
        {
            if (cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
                cnx.Open();

        }

        public void Deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
                cnx.Close();
        }
    }
}
