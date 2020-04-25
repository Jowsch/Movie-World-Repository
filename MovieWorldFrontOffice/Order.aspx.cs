using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : System.Web.UI.Page
{
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            if (OrderNo != 1)
            {
                DisplayOrder();
            }
        }
    }
    private void DisplayOrder()
    {
        clsOrderCollection OrderList = new clsOrderCollection();
        OrderList.ThisOrder.Find(OrderNo);

        txtOrderNo.Text = OrderList.ThisOrder.OrderNo.ToString();
        txtCustomerId.Text = OrderList.ThisOrder.Customer_Id;
        txtTotalCost.Text = OrderList.ThisOrder.TotalCost;
        txtStaffId.Text = OrderList.ThisOrder.Staff_Id;
        txtDateOfOrder.Text = OrderList.ThisOrder.DateOfOrder.ToString();
    }


    protected void ButtonOk_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        string DateOfOrder = txtDateOfOrder.Text;
        string TotalCost = txtTotalCost.Text;
        string Customer_Id = txtCustomerId.Text;
        string Staff_Id = txtStaffId.Text;

        string Error = "";
        Error = AnOrder.Valid(Customer_Id, Staff_Id, TotalCost, DateOfOrder);
        if (Error == "")
        {

            AnOrder.OrderNo = OrderNo;
            AnOrder.Customer_Id = Customer_Id;
            AnOrder.Staff_Id = Staff_Id;
            AnOrder.TotalCost = TotalCost;
            AnOrder.DateOfOrder = Convert.ToDateTime(DateOfOrder);

            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderNo == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderNo);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }

            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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
}

