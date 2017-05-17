using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using PMSystem.Entities;
using PMSystem.Models;

namespace PMSystem.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(): base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<ApplicationLog> ApplicationLogs { get; set; } 

       // public IDbSet<DefaultValue> DefaultValues { get; set; }
        
         
    }
}