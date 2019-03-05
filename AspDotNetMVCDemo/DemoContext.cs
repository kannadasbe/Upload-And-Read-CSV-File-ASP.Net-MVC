using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AspDotNetMVCDemo.Models;

namespace AspDotNetMVCDemo
{
    public class DemoContext : DbContext
    {
        public DemoContext() : base("ConString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}