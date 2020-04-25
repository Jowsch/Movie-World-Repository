using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 OrderNo;
        {
            OrderNo = Convert.ToInt32(Session["OrderNo"]);
        }
    }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            clsOrderCollection OrderBook = new clsOrderCollection();

            OrderBook.ThisOrder.Find(OrderNo);

            OrderBook.Delete();

            Response.Redirect("OrderList.aspx");
        }
    }
