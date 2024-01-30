using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joshy_api.Models
{
    public class User
    {
        public Guid Id{get; set;}
        public required string FullName {get; set;}
        public required string Age {get; set;}
        public required string PhoneNumber{get; set;}
        public required string Address{get; set;}
        public IEnumerable<Order>? Order
        {
            get;
            set;
        }
    }
}