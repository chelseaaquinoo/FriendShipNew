using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheFriendShip.Models;

namespace FriendShip.Data
{
    public class FriendShipDbContext : IdentityDbContext<User>
    {
        public FriendShipDbContext(DbContextOptions<FriendShipDbContext> options) : base(options)
        {
        }
        //public DbSet<FriendShip.Models.Product> Product { get; set; }
        public DbSet<User> Review { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}