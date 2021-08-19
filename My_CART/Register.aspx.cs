using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My_CART 
{ 
    public partial class Register : System.Web.UI.Page 
    {
        Customer_Controller Customer;
        
        protected void Page_Load(object sender, EventArgs e){}

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer = new Customer_Controller();
            Customer.user = TextBox1.Text;
            Customer.name = TextBox2.Text;
            Customer.email = TextBox3.Text;
            Customer.contact = TextBox4.Text;
            Customer.gender = RadioButtonList1.SelectedItem.Text;
            Customer.pass = TextBox5.Text;
            Customer.Create_Customer();
        }
    }
}