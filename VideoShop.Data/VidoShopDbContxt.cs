using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VideoShop.Domain;

namespace VideoShop.Data
{
    //This class created fot communication with database by EF Core.
    public class VidoShopDbContxt : IdentityDbContext<AppUser, AppRole, int>
    {
        public VidoShopDbContxt(DbContextOptions<VidoShopDbContxt> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
