using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RV.Databases
{

    public class PostalDbInit : System.Data.Entity.DropCreateDatabaseAlways<PostalDbContext>
    {
        protected override void Seed(PostalDbContext context)
        {
            var postals = RV.API.PostalData.GetPostal();

            postals.ForEach(station =>
            {
                context.PostalTable.Add(station);
            });
            context.SaveChanges();

        }

    }
}
