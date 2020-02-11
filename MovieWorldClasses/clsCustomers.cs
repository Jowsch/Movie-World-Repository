using System;

namespace MovieWorld_Testing
{
    internal class clsCustomers
    {
        public int customer_id { get; internal set; }
        public DateTime create_date { get; internal set; }
        public string first_name { get; internal set; }
        public string last_name { get; internal set; }
        public string email { get; internal set; }
        public bool active { get; internal set; }
    }
}