using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Filesistem.Data.Models;
namespace Filesistem.Data
{
    public class DataContext:DbContext 
    {
        public DataContext(){}
       public DataContext (DbContextOptions<DataContext> options) : base(options){ }

       public virtual DbSet<Admin>? admin {get;set;}= null;
    }
}