using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joshy_api.Models
{
    public class OrderDetails
    {
        public Guid Id{get; set;}
        public Guid ProductId{get; set;}
        public Guid OrderId{get; set;}
        public Products? Product{get; set;}
        public Order? Order{get; set;}
    }
} 