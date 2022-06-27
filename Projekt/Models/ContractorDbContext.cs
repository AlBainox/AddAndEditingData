using System;
using System.Data.Entity;
using System.Linq;

namespace Projekt.Models
{
   public class ContractorDbContext : DbContext
    {
        // Your context has been configured to use a 'DbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Projekt.Models.DbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbContext' 
        // connection string in the application configuration file.
        public ContractorDbContext()
            : base("name=ContractorDbContext")
        {
        }
       static ContractorDbContext()
        { 
            Database.SetInitializer<ContractorDbContext>(new Initializer());  
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<ContractorModel> Contractors { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}