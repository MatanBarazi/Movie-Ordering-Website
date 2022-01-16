using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_project.Models;

namespace MVC_project.Dal
{
    public class MovieDal:DbContext
    {
       /* public DbSet<Movie> movies { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>().ToTable("MOVIES");
        }*/
    }
}