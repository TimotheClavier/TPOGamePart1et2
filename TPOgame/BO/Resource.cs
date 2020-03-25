using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TPOgame.BO
{
    public class Resource : IdbEntity
    {
        public long Id { get; set; }

        [StringLength(20, MinimumLength = 5)]
        [RegularExpression("énergie|oxygène|acier|uranium", ErrorMessage = "La ressources doit être de type énergie, oxygène, acier ou uranium.")]
        public String name { get; set; }

        public int lastQuantity { get; set; }

        public DateTime lastUpdate { get; set; }
    }
}