using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;

namespace My_CART
{

    public class Customer_Controller : ApiController
    {
        public string user;
        public string name;
        public string email;
        public string contact;
        public string gender;
        public string pass;
        public SqlConnection con = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=CartDB;Integrated Security=True");
        public SqlDataAdapter da;
        public SqlCommand cmd;
        public DataSet ds;
        public DataTable table;
     
        //CONSTRUCTOR
        public void __Construct(){
            con.Open();
        }
        
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<controller>
        public void Create_Customer()
        {
            __Construct();
            cmd = new SqlCommand("dbo.insert_customer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", this.user);
            cmd.Parameters.AddWithValue("@name", this.name);
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@contact", this.contact);
            cmd.Parameters.AddWithValue("@gender", this.gender);
            cmd.Parameters.AddWithValue("@password", this.pass.GetHashCode());
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            __Destruct();
        }
        //DISPLAY DATA
        // GET api/<controller>/5
        public void Retrieve_Customer()
        {
            table = new DataTable();
             __Construct();
            cmd = new SqlCommand("dbo.View_Customer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            table.Columns.Add("username");
            table.Rows.Add("@username",this.user);
            __Destruct();
        }
        // PUT api/<controller>/5
        public void Update_Customer()
        {
        }

        // DELETE api/<controller>/5
        public void Delete_Customer(int id)
        {
            __Construct();
            cmd = new SqlCommand("dbo.delete_customer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            __Destruct();
        }

        //DESTRUCTOR
        public void __Destruct()
        { 
            con.Close();
        }

    }
}