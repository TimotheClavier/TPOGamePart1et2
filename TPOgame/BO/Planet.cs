using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TPOgame.BO
{
    public class Planet : IdbEntity
    {
        public long Id { get; set; }

        public String name { get; set; }

        public int caseNb { get; set; }

        [MaxLength(4)]
        public List<Resource> resources { get; set; }
        public List<Building> buildings { get; set; }

    }
}