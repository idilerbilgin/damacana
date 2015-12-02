using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace damacana.Models
{
    public class Purchase
    {
       public int Id { get; set; } 

        public virtual ICollection<User> User { get; set; }

        public DateTime CreatedOn { get; set; }
        public virtual ICollection<List<Product>> ListofProducts { get; set; }

        public int TotalPrice { get; set; } 

    }

}