using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieWorldClasses;

public partial class DeleteCustomer : System.Web.UI.Page
{
    Int32 customer_id;

    protected void Page_Load(object sender, EventArgs e)
    {
        customer_id = Convert.ToInt32(Session["customer_id"]);
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();

        CustomerBook.ThisCustomer.Find(customer_id);

        CustomerBook.Delete();

        Response.Redirect("CustomerList.aspx");
    }
}