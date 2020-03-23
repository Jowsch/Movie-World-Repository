using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void ButtonOk_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.OrderNo = txtOrderNo.Text;
        AnOrder.DateOfOrder = Convert.ToDateTime(txtDateOfOrder.Text);
        AnOrder.Customer_Id = txtCustomerId.Text;
        AnOrder.TotalCost = txtTotalCost.Text;
        AnOrder.Staff_Id = txtStaffId.Text;
        
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }
}