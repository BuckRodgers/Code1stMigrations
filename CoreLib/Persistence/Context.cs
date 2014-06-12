using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreLib.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace CoreLib.Persistence
{
    //in package console: install-package EntityFramework -ProjectName Core
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }

       // protected override void OnModelCreating(DbModelBuilder modelBuilder)
       // {
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    ConfigureModel(modelBuilder);

       //     Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());

        //    base.OnModelCreating(modelBuilder);
       // }

        /*
        private void ConfigureModel(DbModelBuilder modelBuilder)
        {
            var entityMethod = typeof(DbModelBuilder).GetMethod("Entity");

            var entityTypes = Assembly.GetAssembly(typeof(Entity)).GetTypes()
            .Where(x => x.IsSubclassOf(typeof(Entity)) && !x.IsAbstract);
            foreach (var type in entityTypes)
            {
                entityMethod.MakeGenericMethod(type).Invoke(modelBuilder, new object[] { });
            }
        }
         * */


    }

   

}