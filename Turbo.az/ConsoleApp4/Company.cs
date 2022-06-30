using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Company : Seller
    {
        public string NewAdYeniElanId { get; set; }
        public NewAdYeniElan NewAdYeniElan { get; set; }
        public string Addnewad(string NewAdYeniElanId)
        {
            NewAdYeniElan Ad = new NewAdYeniElan();
            Ad.Id = NewAdYeniElanId;
            return Ad.Id;
        }
        public string ContactInfo { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
    }
}
