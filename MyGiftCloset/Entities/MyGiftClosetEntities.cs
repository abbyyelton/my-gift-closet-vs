namespace MyGiftCloset.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class MyGiftClosetEntities : DbContext
    {
        // Your context has been configured to use a 'MyGiftClosetEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MyGiftCloset.Models.MyGiftClosetEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyGiftClosetEntities' 
        // connection string in the application configuration file.
        public MyGiftClosetEntities()
        {
            Database.SetInitializer(new DatabaseInitializer());
          //  Database.SetInitializer(new DropCreateDatabaseAlways<MyGiftClosetEntities>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Recipient> Recipients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            //modelBuilder.Conventions.Add(new DecimalPropertyConvention(7, 2));

            modelBuilder.Entity<Gift>()
                .Property(g => g.Price)
                .HasPrecision(7, 2);
        }

        

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}