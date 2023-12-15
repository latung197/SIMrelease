using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Simrelease.Models.Models;
namespace Simrelease.Data
{
    //[DbConfigurationType(typeof(Configuration))]
    public class SimDbcontext:DbContext
    {
        public SimDbcontext():base(nameOrConnectionString: "Conn")
        {
           
        }
        public DbSet<Error> errors { get; set; }
        public DbSet<Dmkh> dmkh { get; set; }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(p => p.Version)
                    .HasColumnName("xmin")
                    .HasColumnType("text")
                    .IsConcurrencyToken()
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            base.OnModelCreating(modelBuilder);
        }
    }
}




//internal class Configuration : DbConfiguration
//{
//    public Configuration()
//    {
//        SetMigrationSqlGenerator("Npgsql", () => new SqlGenerator());
        
//    }
//}

//public class SqlGenerator : NpgsqlMigrationSqlGenerator
//{
//    private readonly string[] systemColumnNames = { "oid", "tableoid", "xmin", "cmin", "xmax", "cmax", "ctid" };

//    protected override void Convert(CreateTableOperation createTableOperation)
//    {
//        var systemColumns = createTableOperation.Columns.Where(x => systemColumnNames.Contains(x.Name)).ToArray();
//        foreach (var systemColumn in systemColumns)
//            createTableOperation.Columns.Remove(systemColumn);
//        base.Convert(createTableOperation);
//    }
//}
