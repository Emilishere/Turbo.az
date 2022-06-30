using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Individual : Seller
    {
        public string NewAdYeniElanId { get; set; }
        public NewAdYeniElan NewAdYeniElan { get; set; }
        public string Addnewad(string NewAdYeniElanId)
        {
            NewAdYeniElan Ad = new NewAdYeniElan();
            Ad.Id = NewAdYeniElanId;
            return Ad.Id;
        }
        public string Email { private get; set; }
        public string PhoneNumber { get; set; }
    }
}
