using System;
using System.Collections.Generic;

namespace ModernERAServices.Database
{
    public partial class UserDetails
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal? ContactNo { get; set; }
    }
}
