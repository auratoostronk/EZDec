using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DecorateWriter;

namespace MapEditor
{
    public partial class CreateWeaponForm : Form
    {

        private readonly List<ActorFrame.ActorFrame> frames;

        public CreateWeaponForm()
        {
            frames = new List<ActorFrame.ActorFrame>();
            InitializeComponent();
            this.InputAmmoType.Text = "Clip";
            this.InputSlotNumber.Text = "1";
            this.InputStateFunction.Text = "None";
        }

        private void WriteWeaponToFile(object sender, EventArgs e)
        {
            DecorateWriter.DecorateWriter.clear();
            DecorateWriter.DecorateWriter.writeLine("//*** Created with EZDec ***//");
            DecorateWriter.DecorateWriter.writeLine("//***     aurasite.net   ***//");
            DecorateWriter.DecorateWriter.writeLine("ACTOR " + this.TextWeaponName.Text + " : Weapon");
            DecorateWriter.DecorateWriter.writeLine("{");
            DecorateWriter.DecorateWriter.writeTabbedLine("Weapon.AmmoType \"" + this.InputAmmoType.Text + "\"", 1);
            DecorateWriter.DecorateWriter.writeTabbedLine("Weapon.AmmoGive " + this.InputAmmoGive.Value, 1);
            DecorateWriter.DecorateWriter.writeTabbedLine("Weapon.AmmoUse " + this.InputAmmoUse.Value, 1);
            DecorateWriter.DecorateWriter.writeTabbedLine("Weapon.SlotNumber " + this.InputSlotNumber.SelectedItem, 1);
            DecorateWriter.DecorateWriter.writeTabbedLine("AttackSound \"" + this.InputAttackSound.Text + "\"", 1);
            DecorateWriter.DecorateWriter.writeTabbedLine("States", 1);
            DecorateWriter.DecorateWriter.writeTabbedLine("{", 1);
            DecorateWriter.DecorateWriter.writeTabbedLine("Ready:", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine(this.InputReadySprite.Text + " " + this.InputReadySpriteFrame.Text + " 1 A_WeaponReady", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Loop", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Select:", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine(this.InputReadySprite.Text + " " + this.InputReadySpriteFrame.Text + " 1 A_Raise", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Loop", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Deselect:", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine(this.InputReadySprite.Text + " " + this.InputReadySpriteFrame.Text + " 1 A_Lower", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Loop", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Spawn:", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine(this.InputPickupSprite.Text + " " + this.InputPickupSpriteFrame.Text + " 1", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Loop", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Fire:", 2);
            foreach (ActorFrame.ActorFrame f in frames)
            {
                DecorateWriter.DecorateWriter.writeTabbedLine(f.ToString(), 2);
            }
            DecorateWriter.DecorateWriter.writeTabbedLine("Goto Ready", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("}", 1);
            DecorateWriter.DecorateWriter.writeLine("}");
            DecorateWriter.DecorateWriter.compress();
            DecorateWriter.DecorateWriter.clear();
            this.Close();
        }

        private void AddActorFrame(object sender, EventArgs e)
        {
            if(this.InputStateFunction.Text.Equals("Fire Hitscan"))
            {
                DecorateFunction.DecorateFunction dfunc = new DecorateFunction.DecorateFunction("A_FireBullets", 
                    new string[] { this.InputBulletsArg1.Value.ToString(), this.InputBulletsArg2.Value.ToString(), this.InputBulletsArg3.Value.ToString(), this.InputBulletsArg4.Value.ToString() });
                frames.Add(new ActorFrame.ActorFrame(this.InputStateSprite.Text, this.InputStateFrame.Text.ToCharArray()[0], (int)this.InputStateDuration.Value, dfunc));
                this.StatesAdded.Items.Add(frames.ElementAt(frames.Count - 1));
            }
            else if (this.InputStateFunction.Text.Equals("Fire Projectile"))
            {
                DecorateFunction.DecorateFunction dfunc = new DecorateFunction.DecorateFunction("A_FireMissile", null);
                frames.Add(new ActorFrame.ActorFrame(this.InputStateSprite.Text, this.InputStateFrame.Text.ToCharArray()[0], (int)this.InputStateDuration.Value, dfunc));
                this.StatesAdded.Items.Add(frames.ElementAt(frames.Count - 1));
            }
            else if (this.InputStateFunction.Text.Equals("Fire Railgun"))
            {
                DecorateFunction.DecorateFunction dfunc = new DecorateFunction.DecorateFunction("A_FireRailgun", null);
                frames.Add(new ActorFrame.ActorFrame(this.InputStateSprite.Text, this.InputStateFrame.Text.ToCharArray()[0], (int)this.InputStateDuration.Value, dfunc));
                this.StatesAdded.Items.Add(frames.ElementAt(frames.Count - 1));
            }
            else
            {
                frames.Add(new ActorFrame.ActorFrame(this.InputStateSprite.Text, this.InputStateFrame.Text.ToCharArray()[0], (int)this.InputStateDuration.Value, null));
                this.StatesAdded.Items.Add(frames.ElementAt(frames.Count - 1));
            }

        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnActionFunctionSelected(object sender, EventArgs e)
        {
            if (this.InputStateFunction.SelectedItem.ToString().Equals("Fire Hitscan"))
            {
                this.SetBulletArgsVisibility(true);
            }
            else
            {
                this.SetBulletArgsVisibility(false);
            }
        }
        private void SetBulletArgsVisibility(bool vis)
        {
            LabelBulletsArg1.Visible = vis;
            InputBulletsArg1.Visible = vis;
            LabelBulletsArg2.Visible = vis;
            InputBulletsArg2.Visible = vis;
            LabelBulletsArg3.Visible = vis;
            InputBulletsArg3.Visible = vis;
            LabelBulletsArg4.Visible = vis;
            InputBulletsArg4.Visible = vis;

        }

        private void RemoveActorFrame(object sender, EventArgs e)
        {
            if(this.frames.Count <= 0)
            {

            }
            else if (this.frames.Count == 1)
            {
                this.frames.Clear();
                this.StatesAdded.Items.Clear();
            }
            else
            {
                this.frames.RemoveAt(frames.Count - 1);
                this.StatesAdded.Items.RemoveAt(frames.Count - 1);
            }
        }
    }
}
