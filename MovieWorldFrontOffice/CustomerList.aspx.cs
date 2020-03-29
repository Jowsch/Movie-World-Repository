using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        MovieWorldClasses.clsCustomerCollection Customers = new MovieWorldClasses.clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "customer_id";
        lstCustomerList.DataTextField = "email";
        lstCustomerList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //add
        Session["customer_num"] = -1;

        Response.Redirect("ACustomer.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //del
        Int32 customer_id;

        if (lstCustomerList.SelectedIndex != -1)
        {
            customer_id = Convert.ToInt32(lstCustomerList.SelectedValue);

            Session["customer_id"] = customer_id;
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }

    }
}