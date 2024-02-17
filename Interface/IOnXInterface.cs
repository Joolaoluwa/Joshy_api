using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joshy_api.Models;

namespace Joshy_api.Interface
{
    public interface IOnXInterface
    {
        ICollection<User> GetUsers();
        
    }
}