using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmMonsterFight : Form
    {
        public frmMonsterFight(Monster monster)
        {
            InitializeComponent();
            this.monster = monster;
        }
        Monster monster;
        public static Monster FightMonster()
        {
            frmMonsterFight monsterFight = new frmMonsterFight(Monster.Generate());
            monsterFight.ShowDialog();

            return monsterFight.monster;
        }
        private void getActions()
        {
            lbActions.Items.Clear();
            if (monster == null)
            {
                lbActions.Items.Add("Exit");
                return;
            }
            lbActions.Items.AddRange(Globals.player.getActions().ToArray());
        }
        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (lbActions.SelectedIndex == -1)
                goto Ending;

            string pAction = (string) lbActions.SelectedItem;

            if (pAction == "Exit")
            {
                this.DialogResult = DialogResult.OK;
            }
            if (monster == null)
                goto Ending;

            string mAction = monster.GetAction();
            if (pAction == "Run Away")
            {
                frmEnding.ShowEnding(Ending.RUN);
                return;
            }

            if (pAction == "Swing")
            {
                lbEvents.Items.Add(Entity.GetAttack(
                    Globals.player,
                    Globals.player.quickSlots[frmSlotPopup.GetEquipmentSlot(Globals.player.quickSlots, true)] as BasicWeapon,
                    monster,
                    monster.quickSlots[0] as BasicWeapon,
                    mAction == "Block"
                ));
            } else if (pAction == "Open Inventory")
            {
                frmInventory.ViewInventory(Globals.player, true);
            } else if (pAction == "Check Status")
            {
                frmStatusForm.ShowStatus(Globals.player);
            } else if (pAction == "Check Monster Status")
            {
                frmStatusForm.ShowStatus(monster);
            }
            if (mAction == "Swing")
            {
                lbEvents.Items.Add(Entity.GetAttack(
                    monster,
                    monster.quickSlots[0] as BasicWeapon,
                    Globals.player,
                    Globals.player.quickSlots[frmSlotPopup.GetEquipmentSlot(Globals.player.quickSlots, true)] as BasicWeapon,
                    pAction == "Block"
                ));
            }
            else if (mAction == "Spit")
            {
                lbEvents.Items.Add($"{monster.name} spat at {Globals.player.name}");
                Globals.player.health -= 5;
                if (Globals.player.health < 0) Globals.player.health = 0;
            }
            else if (mAction == "Block" && pAction != "Swing")
                lbEvents.Items.Add($"{monster.name} blocked!");

            if (Globals.player.health == 0)
            {
                frmEnding.ShowEnding(Ending.FAIL);
                Application.Exit();
                return;
            }
            if (monster.health == 0)
            {
                lbEvents.Items.Add($"{monster.name} died.");
                pbMonster.Image = Images.dead_monster;
                monster = null;
            }

        Ending:
            getActions();
        }

        private void frmMonsterFight_Load(object sender, EventArgs e)
        {
            pbMonster.Image = monster.image;
            lblMonsterDisplay.Text = monster.name;
            getActions();
        }
    }
}
