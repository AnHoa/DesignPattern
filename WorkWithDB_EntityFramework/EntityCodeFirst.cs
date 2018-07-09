namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class EntityCodeFirst : DbContext
    {
        // Your context has been configured to use a 'EntityCodeFirst' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WorkWithDB_EntityFramework.EntityCodeFirst' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EntityCodeFirst' 
        // connection string in the application configuration file.
        public EntityCodeFirst()
            : base("name=EntityCodeFirst")
        {
        }


        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class Emp
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Article> Articles { get; set; }
    }

    public class Article
    {
        [Key]
        public int Number { get; set; }
        public string Title { get; set; }

        [ForeignKey("Emp")]
        public int IdEmp { get; set; }

        public virtual Emp Emp { get; set; }
    }
}