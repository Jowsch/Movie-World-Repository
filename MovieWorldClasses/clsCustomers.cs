using System;

namespace MovieWorldClasses
{
    public class clsCustomers
    {
        public int customer_id { get; set; }
        public DateTime create_date { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public bool active { get; set; }

        public bool Find(int customerNum)
        {
            customer_id = 21;
            return true;
        }
    }
}