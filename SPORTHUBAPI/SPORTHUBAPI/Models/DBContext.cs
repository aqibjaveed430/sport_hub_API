using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SPORTHUBAPI.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("MyApiString")
        {
        }

        public DbSet<PlayerInfo> Player { get; set; }
        public DbSet<UserLogin> Login { get; set; }
        public DbSet<TeamRegister> Team { get; set; }
      //  public DbSet<UserDetail> Usersdetail { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}