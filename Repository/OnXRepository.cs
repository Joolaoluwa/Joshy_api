using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joshy_api.Data;
using Joshy_api.Interface;
using Joshy_api.Models;

namespace Joshy_api.Repository
{

    public class OnXRepository : IOnXInterface
    {
        private  JoshyDbContext _context;
       public OnXRepository(JoshyDbContext context)
       {
            _context = context;
       }
        public ICollection<User> GetUsers() => [.. _context.User.OrderBy(x => x.Id)]; 
    }
}