using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieWorldClasses;

public partial class ACustomer : System.Web.UI.Page
{
    Int32 customer_id;
    protected void Page_Load(object sender, EventArgs e)
    {
        customer_id = Convert.ToInt32(Session["customer_id"]);
        if (IsPostBack == false)
        {
            if (customer_id != 1)
            {
                DisplayCustomer();
            }
        }
    }

    private void DisplayCustomer()
    {
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        CustomerList.ThisCustomer.Find(customer_id);

        txtCustomer_ID.Text = CustomerList.ThisCustomer.customer_id.ToString();
        txtFirstName.Text = CustomerList.ThisCustomer.first_name;
        txtLastName.Text = CustomerList.ThisCustomer.last_name;
        txtEmail.Text = CustomerList.ThisCustomer.email;
        chkActive.Checked = CustomerList.ThisCustomer.active;
        txtCreateDate.Text = CustomerList.ThisCustomer.create_date.ToString();
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
            ACustomer.customer_id = customer_id;
            ACustomer.first_name = first_name;
            ACustomer.last_name = last_name;
            ACustomer.email = email;
            ACustomer.active = chkActive.Checked;
            ACustomer.create_date = Convert.ToDateTime(create_date);

            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if(customer_id == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(customer_id);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
                     
            Response.Redirect("CustomerList.aspx");
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