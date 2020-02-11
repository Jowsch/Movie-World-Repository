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
        clsCustomers ACustomer = new clsCustomers();

        ACustomer = (clsCustomers)Session["ACustomer"];

        Response.Write(ACustomer.customer_id);
    }
}