using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Functionality.Models
{
    public class RoleMap
    {
        public int Id { get; set; }

        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public ICollection<Role> Roles { get; set; }
        public int UserId { get; set; }
        public ICollection<User> Users { get; set; }
    }
}