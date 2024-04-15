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
        public User? GetUser(Guid id)
         {
            return _context.User.Where(x => x.Id == id).FirstOrDefault();
         }
         public User? GetUser(string name)
         {
            return _context.User.Where(x => x.FullName == name).FirstOrDefault();
         }

         public decimal? Price(Guid userId)
         {
            // var checkId = _context.Products.Where(x => x.Id == userId);
            // return _context.Products.Select(x => x.Price);

            var productPrice = _context.Products.Where(x => x.Id == userId)
            .Select(x => x.Price).FirstOrDefault();
            return productPrice;
         }

         public bool UserExists(Guid userId)
         {
            // var userExists = _context.User.Select(x => x.Id);
            // foreach(var usersId in userExists)
            // {
            //    if(usersId != userId)
            //       return false;
            // }
            // return true;

            var userExists = _context.User.Any(x => x.Id == userId);
            return userExists;
         }
    }
}