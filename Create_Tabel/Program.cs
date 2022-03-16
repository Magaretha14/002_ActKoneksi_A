using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Tabel
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-N3UNMQ7P;database=ProdiTI;Integrated Security = TRUE");
                con.Open();

                
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
