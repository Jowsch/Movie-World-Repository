using System;

namespace MovieWorldClasses
{
    public class clsOrder
    {
        private int OrderNo;
        private int CustomerId;
        private DateTime DateOfOrder;
        private string TotalCost;
        private string StaffId;
        private bool AvailableSeats;

        public int Order_id { get; set; }
        public DateTime create_date { get; set; }
        public int Customer_Id { get; set; }
    }
      
    }


