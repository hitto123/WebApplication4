using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication4.Models.EFModels
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=AppDbContext")
        {
        }

        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Register> Registers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .Property(e => e.Cellphone)
                .IsUnicode(false);
        }
    }
}
