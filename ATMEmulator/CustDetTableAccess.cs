using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATMEmulator
{
    class CustDetTableAccess
    {
        private SqlConnection con;
        public void Sqlcon()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=HSA-PC\\SQLEXPRESS; Database=ATM; Integrated Security=true";


        }

        public string QueryExe(Customer cs)
        {
            string sqlstatement = "select Customer_Name from Customer_Details where PIC=@pic";

            SqlCommand cmd=new SqlCommand(sqlstatement,con);
            cmd.Parameters.AddWithValue("@pic", cs.Pic);

            
            string dataret=string.Empty;
            
            try
            {
                con.Open();
                SqlDataReader mydatareader= cmd.ExecuteReader();

                while (mydatareader.Read())
                {
                    dataret=mydatareader["Customer_Name"].ToString();
                    
                   
                    
                }
            }
            catch (SqlException se)
            {

                MessageBox.Show(se.Message);
            }

            catch(NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }

            return dataret;


        }



    }
}
