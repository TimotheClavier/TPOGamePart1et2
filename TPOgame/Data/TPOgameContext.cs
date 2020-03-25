using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TPOgame.Data
{
    public class TPOgameContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TPOgameContext() : base("name=TPOgameContext")
        {
        }

        public System.Data.Entity.DbSet<TPOgame.BO.SolarSystem> SolarSystems { get; set; }

        public System.Data.Entity.DbSet<TPOgame.BO.Resource> Resources { get; set; }

        public System.Data.Entity.DbSet<TPOgame.BO.FunctionBuilding> FunctionBuildings { get; set; }

        public System.Data.Entity.DbSet<TPOgame.BO.ResourceGenerator> ResourceGenerators { get; set; }

        public System.Data.Entity.DbSet<TPOgame.BO.Building> Buildings { get; set; }

        public System.Data.Entity.DbSet<TPOgame.BO.Planet> Planets { get; set; }
    }
}
