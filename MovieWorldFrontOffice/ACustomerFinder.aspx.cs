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
        ACustomer.first_name = txtFirstName.Text;
        ACustomer.last_name = txtLastName.Text;
        ACustomer.email = txtEmail.Text;
        ACustomer.active = activeCheck.Checked;
        ACustomer.create_date = Convert.ToDateTime(txtCreateDate.Text);

        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
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
            activeCheck.Checked = ACustomer.active;
            txtCreateDate.Text = ACustomer.create_date.ToString();
        }
    }
}