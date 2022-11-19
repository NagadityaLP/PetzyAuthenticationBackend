using AuthenticationProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuthenticationProject.Models.Data
{
    public class InformationDbContext: DbContext
    {

        public InformationDbContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<LogInTable> Informations { get; set; }
    }
}