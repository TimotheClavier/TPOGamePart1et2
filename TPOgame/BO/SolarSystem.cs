using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TPOgame.BO
{
    public class SolarSystem : IdbEntity
    {
        public long Id { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public String name { get; set; }
    }
}