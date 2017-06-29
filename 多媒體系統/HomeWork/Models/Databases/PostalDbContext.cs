using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RV.Databases
{
    public class PostalDbContext : System.Data.Entity.DbContext
    {
        static PostalDbContext()
        {
            System.Data.Entity.Database.SetInitializer(new PostalDbInit());
        }
        public PostalDbContext() : base("EFConnection")
        {

        }

        public System.Data.Entity.IDbSet<RV.Postal> PostalTable { get; set; }
        public System.Data.Entity.IDbSet<RV.PostalLocation> PostalLocationTable { get; set; }
    }
}
