using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Player : Entity
    {

        public Player(string name) : base(name, GameSettings.PLAYER_BASE_HEALTH, GameSettings.PLAYER_BASE_ACCURACY, GameSettings.PLAYER_BASE_STRENGTH)
        {

        }
    }
}
