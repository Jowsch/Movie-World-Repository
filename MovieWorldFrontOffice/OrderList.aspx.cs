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
        
    }
        
