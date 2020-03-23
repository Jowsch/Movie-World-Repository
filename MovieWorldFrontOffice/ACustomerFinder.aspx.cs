using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieWorldClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCustomers ACustomer = new clsCustomers();
        string first_name = txtFirstName.Text;
        string last_name = txtLastName.Text;
        string email = txtEmail.Text;
        string create_date = txtCreateDate.Text;

        string Error = "";
        Error = ACustomer.Valid(first_name, last_name, email, create_date);
        if(Error == "")
        {
            ACustomer.first_name = first_name;
            ACustomer.last_name = last_name;
            ACustomer.email = email;
            ACustomer.create_date = Convert.ToDateTime(create_date);

            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

        
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        clsCustomers ACustomer = new clsCustomers();

        Int32 customer_id;
        Boolean found = false;
        customer_id = Convert.ToInt32(txtCustomer_ID.Text);
        found = ACustomer.Find(customer_id);

        if (found == true)
        {
            txtFirstName.Text = ACustomer.first_name;
            txtLastName.Text = ACustomer.last_name;
            txtEmail.Text = ACustomer.email;
            txtCreateDate.Text = ACustomer.create_date.ToString();
        }
    }
}