using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderFinder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNo;
        Boolean found = false;
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        found = AnOrder.Find(OrderNo);

        if (found == true)
        {
            txtDateOfOrder.Text = AnOrder.DateOfOrder.ToString();
            txtCustomerId.Text = AnOrder.Customer_Id;
            txtStaffId.Text = AnOrder.Staff_Id;
            txtTotalCost.Text = AnOrder.TotalCost;
            txtAvailableSeats.Text = AnOrder.AvailableSeats.ToString();
         
        }
    }
    
    protected void ButtonOk_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.DateOfOrder = Convert.ToDateTime(txtDateOfOrder.Text);
        AnOrder.Customer_Id = txtCustomerId.Text;
        AnOrder.TotalCost = txtTotalCost.Text;
        AnOrder.Staff_Id = txtStaffId.Text;

        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }
}
