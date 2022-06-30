using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class ByBusiness : IWithAccount, IWithoutaccount
    {
        public string Id { get; set; }
        public string Email { get; set; }

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
