using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BasicCRUD.Models
{
    [Table("Department")]
    public class Department
    {
        public int  ID {get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }

    }
}