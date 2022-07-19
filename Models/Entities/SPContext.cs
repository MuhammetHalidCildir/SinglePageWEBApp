using System;
using System.Data.Entity;
using System.Linq;

namespace SinglePageWebApp.Models.Entities
{
    public class SPContext : DbContext
    {
        private static readonly string conn_str = @"Server=.\sqlexpress;Database=spdb;User Id=sa;Password=1;";
        public SPContext() : base(conn_str)
        {
        }
        public virtual DbSet<Icon> Icons { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
    }
}