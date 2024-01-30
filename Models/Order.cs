using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joshy_api.Models
{
    public class Order
    {
        public Guid Id{get; set;}
        public DateTime OrderPlaced{get; set;}
        public DateTime OrderFulfilled{get; set;}
        public Guid UserId{get; set;}
        public User? User { get; set; }
        public IEnumerable<OrderDetails>? OrderDetails {get; set;}
    }
}