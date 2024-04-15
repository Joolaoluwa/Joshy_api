using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joshy_api.Dto
{
    public class JoshyDto
    {
        public Guid Id{get; set;}
        public required string FullName {get; set;}
        public required string Age {get; set;}
        public required string PhoneNumber{get; set;}
        public required string Address{get; set;}
        public required string Email{get; set;}
    }
}