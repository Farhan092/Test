using System;
using System.Data.Entity;
using System.Linq;
using System.Xml;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class AppDBGame : DbContext
    {
        // Your context has been configured to use a 'AppDBGame' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebApplication1.Context.AppDBGame' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AppDBGame' 
        // connection string in the application configuration file.
        public AppDBGame()
            : base("name=AppDBGame")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Game> Game { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}