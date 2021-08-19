using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace My_CART
{
    public partial class Home : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection  con = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=CartDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.ViewCustomer");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            cmd.Connection = con;
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
        
         }
    }
}