using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Functionality.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext():base("name=connection")
        {

        }
       
        
        public DbSet<Customer> Customers { get; set;}
        public DbSet<User> Users { get; set;}
        public DbSet<Role> Roles { get; set;}
        public DbSet<RoleMap> RoleMaps { get; set;}
    }
}