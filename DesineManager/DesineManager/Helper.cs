using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesineManager
{
    class Helper
    {

        private SqlConnection con;
        public SqlConnection Con {
            get {
                string sql =@"Data Source=.;Initial Catalog=BoardroomManager;Integrated Security=True ";
                if(con==null){
                    con = new SqlConnection(sql);
                }
                return con;
            }
        }
        public void Open() {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else if (con.State == ConnectionState.Broken) {
                con.Close();
                con.Open();
            }
        }

        public void Close() {
            if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken) {
                con.Close();
            }
        }
    }
}
