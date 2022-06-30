using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class ByContactNumber : IWithAccount, IWithoutaccount
    {
        public string Id { get; set; }
        public string ContactNumber { get; set; }
        public string Password { get; set; }

        public void AddFavorites()
        {
        }
        public string Changepassword (string ByContactNumberPassword, string newPassword) 
        {
            ByContactNumber NewPassword = new ByContactNumber();
            NewPassword.Password = newPassword;
            return newPassword;
        }
        public string FilterBoxId { get; set; }
        public FilterBox FilterBox { get; set; }

        public string Filter(string FilterBoxId)
        {
            FilterBox a = new FilterBox();
            a.Id = FilterBoxId;
            return a.Id;
        }
    }
}
