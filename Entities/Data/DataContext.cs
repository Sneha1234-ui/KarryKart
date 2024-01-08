using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Data
{
 
        public class DataContext : DbContext
        {

            public DataContext()
            {
            }

            public DataContext(DbContextOptions<DataContext> options)
                : base(options)
            {
            }

            public virtual DbSet<Parent_Category> ParentCategory { get; set; }
            public virtual DbSet<Category> category { get; set; }
            public virtual DbSet<Manufacturer> manufacturers { get; set; }
            public virtual DbSet<Product> Product { get; set; }
            public virtual DbSet<Discounts> Discount { get; set; }
            public virtual DbSet<Tax> Tax { get; set; }
            public virtual DbSet<Vendors> Vendors { get; set; }
            public virtual DbSet<Shipping> Shipping { get; set; }
            public virtual DbSet<Inventory> Inventory { get; set; }
            public virtual DbSet<Rental> Rental { get; set; }
            public virtual DbSet<GiftCard> GiftCards { get; set; }
            public virtual DbSet<DownloadableProduct> DownloadProduct { get; set; }
            public virtual DbSet<Recurring_Product> RecurringProduct { get; set; }
            public virtual DbSet<SEO> SEO { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                => optionsBuilder.UseSqlServer("Data Source=DESKTOP-M0TV58H;Initial Catalog=KarryKart;Integrated Security=True;TrustServerCertificate=True;");

        }
    
}

