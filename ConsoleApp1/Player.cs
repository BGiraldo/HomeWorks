using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrollGame
{
   public class Player
    {

        public int currentHitPoints { get; set;  }

        public Player(int hitPoints)
        {
            currentHitPoints = hitPoints;
        }

        public void receiveDamage(int hitPointsOfDamage)
        {
            currentHitPoints = currentHitPoints - hitPointsOfDamage;
        }


    }
}
