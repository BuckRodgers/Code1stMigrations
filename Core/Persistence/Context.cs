using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Models;
using System.Data.Entity;

namespace Core.Persistence
{
    //in package console: install-package EntityFramework -ProjectName Core
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}