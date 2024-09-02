using EmpApp.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace EmpApp.Context
{
    public class EmpDBContext : DbContext
    {
        // Your context has been configured to use a 'EmpDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EmpApp.Context.EmpDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EmpDBContext' 
        // connection string in the application configuration file.
        public EmpDBContext()
            : base("name=EmpDBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Employee> Employee { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}