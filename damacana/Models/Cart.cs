using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace damacana.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public virtual ICollection<User> User { get; set; }

        public virtual ICollection<List<Product>> ListofProducts  { get; set; }
    }
}