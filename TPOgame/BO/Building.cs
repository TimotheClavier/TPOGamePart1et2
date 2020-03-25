using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPOgame.BO
{
    public abstract class Building : IdbEntity
    {
        public long Id { get; set; }

        public String name { get; set; }

        public int? level { get; set; }



        public abstract int? CellNb();
        public List<Resource> TotalCost()
        {
            return null;
        }

        public List<Resource> NextCost()
        {
            List<Resource> ListResource = new List<Resource>();

            return ListResource;
        }
    }
}