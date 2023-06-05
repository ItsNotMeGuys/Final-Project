using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Player : Entity
    {

        public Player(string name) : base(name, GameSettings.PLAYER_BASE_HEALTH, GameSettings.PLAYER_BASE_STRENGTH, Images.player)
        {

        }
        public new List<string> getActions()
        {
            List<string> actions = base.getActions();
            actions.Add("Run Away");
            actions.Add("Open Inventory");
            actions.Add("Check Status");
            actions.Add("Check Monster Status");
            return actions;
        }
    }
}
