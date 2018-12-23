using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LabWork2.Models
{
    public class NodeContext : DbContext
    {
        public DbSet<Node> Nodes { get; set; }
    }
}