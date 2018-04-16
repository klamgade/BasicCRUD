using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BasicCRUD.Models
{
    public class UserContext: DbContext
    {
        public DbSet<Users> Users { get; set; }
    }
}