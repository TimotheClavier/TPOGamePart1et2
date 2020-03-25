using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPOgame.BO
{
    public  class FunctionBuilding : Building
    {

        public List<Action> Actions()
        {
            return null;
        }
        public override int? CellNb()
        {
            throw new NotImplementedException();
        }

    }

}