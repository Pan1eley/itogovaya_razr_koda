using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Itogovaya_rabota_provider
{
    public partial class BaseModel : DbContext
    {
        private static BaseModel _context;
        public BaseModel()
            : base("name=BaseModel")
        {
        }
        public static BaseModel GetContext()
        {
            if (_context == null)
                _context = new BaseModel();
            return _context;
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
