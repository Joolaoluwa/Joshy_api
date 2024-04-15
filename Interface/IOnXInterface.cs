using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joshy_api.Models;

namespace Joshy_api.Interface
{
    public interface IOnXInterface
    {
        public ICollection<User> GetUsers();
        public User ?GetUser(Guid id);
        public User ?GetUser(string name);
       public  decimal ?Price(Guid userId);
        public bool UserExists(Guid userId);
        
    }
}