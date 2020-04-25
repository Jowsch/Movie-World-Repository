using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
using MovieWorldClasses;



public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrder();
        }
    }
        void DisplayOrder()

        {

        clsOrderCollection Order = new clsOrderCollection();
        lstOrderList.DataSource = Order.OrderList; 
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "Customer_Id";
        lstOrderList.DataBind();
            
            
        }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        //add
        Session["Order_num"] = -1;

        Response.Redirect("AnOrder.aspx");
    }

    protected void ButtonDelete_Click1(object sender, EventArgs e)
    {
        //del
        Int32 OrderNo;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);

            Session["OrderNo"] = OrderNo;
            Response.Redirect("DeleteOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void ButtonUpdate_Click2(object sender, EventArgs e)
    {
        Int32 OrderNo;

        if (lstOrderList.SelectedIndex != 1)
        {
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNo"] = OrderNo;

            Response.Redirect("Order.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to update from the list";
        }
    }

    protected void Button1_Click3(object sender, EventArgs e)
    {
        clsOrderCollection Customers = new clsOrderCollection();
        Customers.ReportByCustomerId(CustomerIdInput.Text);
        lstOrderList.DataSource = Customers.OrderList;

        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "CustomerId";
        lstOrderList.DataBind();
    }

    protected void Clear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Customers = new clsOrderCollection();
        Customers.ReportByCustomerId("");

        CustomerIdInput.Text = "";
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "CustomerId";
        lstOrderList.DataBind();
    }
}


        
