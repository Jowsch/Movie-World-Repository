using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderNo);
        Response.Write(AnOrder.DateOfOrder + "<br>");
        Response.Write(AnOrder.Customer_Id + "<br>");
        Response.Write(AnOrder.Staff_Id + "<br>");
        Response.Write(AnOrder.TotalCost + "<br>");
        Response.Write(AnOrder.AvailableSeats+ "<br>");
    }
}