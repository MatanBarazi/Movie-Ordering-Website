using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_project.Models;
using System.Data.Entity;

namespace MVC_project.Dal
{
    public class GenresDal:DbContext
    {
      /*  public DbSet<Genre> genres { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>().ToTable("GENRES");
        }*/
    }
}