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

namespace EZDec
{
    public partial class CreateWeaponForm : Form
    {

        private List<ActorFrame.ActorFrame> frames;

        public CreateWeaponForm()
        {
            frames = new List<ActorFrame.ActorFrame>();
            InitializeComponent();
            this.InputAmmoType.Text = "Clip";
            this.InputSlotNumber.Text = "1";
            this.InputStateFunction.Text = "None";
            this.InputMissileArg1.Text = "Rocket";
            this.InputPickupSprite.Text = "Pistol";
            this.InputIdleSprite.Text = "Pistol";
            this.InputAttackSprite.Text = "Pistol 1 (Idle)";
        }
        private void WriteWeaponToFile()
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
            DecorateWriter.DecorateWriter.writeTabbedLine(this.GetIdleSprite() + " A_WeaponReady", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Loop", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Select:", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine(this.GetIdleSprite() + " A_Raise", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Loop", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Deselect:", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine(this.GetIdleSprite() + " A_Lower", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Loop", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine("Spawn:", 2);
            DecorateWriter.DecorateWriter.writeTabbedLine(GetPickupSprite() + " 1", 2);
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
                frames.Add(new ActorFrame.ActorFrame(this.GetActorFrameSprite(), this.GetActorFrameIndex(), (int)this.InputStateDuration.Value, dfunc));
                this.StatesAdded.Items.Add(frames.ElementAt(frames.Count - 1));
            }
            else if (this.InputStateFunction.Text.Equals("Fire Projectile"))
            {
                DecorateFunction.DecorateFunction dfunc = new DecorateFunction.DecorateFunction("A_FireCustomMissile",
                    new string[] { "\"" + this.InputMissileArg1.SelectedItem.ToString() + "\"", this.InputMissileArg2.Value.ToString(), "true", "0.0", "-2.0", "0", this.InputMissileArg3.Value.ToString() });
          
                frames.Add(new ActorFrame.ActorFrame(this.GetActorFrameSprite(), this.GetActorFrameIndex(), (int)this.InputStateDuration.Value, dfunc));
                this.StatesAdded.Items.Add(frames.ElementAt(frames.Count - 1));
            }
            else if (this.InputStateFunction.Text.Equals("Fire Railgun"))
            {
                DecorateFunction.DecorateFunction dfunc = new DecorateFunction.DecorateFunction("A_FireRailgun", null);
                frames.Add(new ActorFrame.ActorFrame(this.GetActorFrameSprite(), this.GetActorFrameIndex(), (int)this.InputStateDuration.Value, dfunc));
                this.StatesAdded.Items.Add(frames.ElementAt(frames.Count - 1));
            }
            else
            {
                frames.Add(new ActorFrame.ActorFrame(this.GetActorFrameSprite(), this.GetActorFrameIndex(), (int)this.InputStateDuration.Value, null));
                this.StatesAdded.Items.Add(frames.ElementAt(frames.Count - 1));
            }

        }

        private string GetPickupSprite()
        {
            switch(InputPickupSprite.Text)
            {
                case ("Chainsaw"):
                    return "CSAW A ";
                case ("Pistol"):
                    return "PIST A ";
                case ("Shotgun"):
                    return "SHOT A ";
                case ("Super Shotgun"):
                    return "SGN2 A ";
                case ("Chaingun"):
                    return "MGUN A ";
                case ("Rocket Launcher"):
                    return "LAUN A ";
                case ("Plasma Rifle"):
                    return "PLAS A ";
                case ("BFG9000"):
                    return "BFUG A ";
            }
            Console.WriteLine("Error in InputPickupSprite: Value \"" + InputPickupSprite.Text + "\" does not match a valid value!");
            return "TNT1 A ";
        }
        private string GetIdleSprite()
        {
            switch (InputIdleSprite.Text)
            {
                case ("Chainsaw"):
                    return "SAWG CD 4 ";
                case ("Fist"):
                    return "PUNG A  1";
                case ("Pistol"):
                    return "PISG A 1";
                case ("Shotgun"):
                    return "SHTG A 1";
                case ("Super Shotgun"):
                    return "SHT2 A 1";
                case ("Chaingun"):
                    return "CHGG A 1";
                case ("Rocket Launcher"):
                    return "MISG A 1";
                case ("Plasma Rifle"):
                    return "PLSG A 1";
                case ("BFG9000"):
                    return "BFGG A 1";
            }
            Console.WriteLine("Error in InputIdleSprite: Value \"" + InputIdleSprite.Text + "\" does not match a valid value!");
            return "TNT1 A ";
        }

        private string GetActorFrameSprite()
        {
            if (InputAttackSprite.Text.Contains("Fist"))
                return "PUNG";
            if (InputAttackSprite.Text.Contains("Chainsaw"))
                return "SAWG";
            if (InputAttackSprite.Text.Contains("Pistol"))
                return "PISG";
            //This must come first or it will be replaced with the regular shotgun sprites.
            if (InputAttackSprite.Text.Contains("Super Shotgun"))
                return "SHT2";
            if (InputAttackSprite.Text.Contains("Shotgun"))
                return "SHTG";
            if (InputAttackSprite.Text.Contains("Chaingun"))
                return "CHGG";
            if (InputAttackSprite.Text.Contains("Rocket Launcher"))
                return "MISG";
            if (InputAttackSprite.Text.Contains("Plasma Rifle"))
                return "PLSG";
            if (InputAttackSprite.Text.Contains("BFG9000"))
                return "BFGG";
            if (InputAttackSprite.Text.Contains("No Sprite"))
                return "TNT1";
            Console.WriteLine("Error in InputAttackSprite: Value \"" + InputAttackSprite.Text + "\" does not match a valid value!");
            return "TNT1";
        }

        private char GetActorFrameIndex()
        {
            if (InputAttackSprite.Text.Contains("1"))
                return 'A';
            if (InputAttackSprite.Text.Contains("2"))
                return 'B';
            if (InputAttackSprite.Text.Contains("3"))
                return 'C';
            if (InputAttackSprite.Text.Contains("4"))
                return 'D';
            if (InputAttackSprite.Text.Contains("5"))
                return 'E';
            if (InputAttackSprite.Text.Contains("6"))
                return 'F';
            if (InputAttackSprite.Text.Contains("7"))
                return 'G';
            if (InputAttackSprite.Text.Contains("8"))
                return 'H';
            if (InputAttackSprite.Text.Contains("9"))
                return 'I';
            Console.WriteLine("Error in InputAttackSprite: Value \"" + InputAttackSprite.Text + "\" does not match a valid value!");
            return 'A';

        }

        private void CreateButtonClick(object sender, EventArgs e)
        {
            if(frames.Count == 0)
            {
                ErrorForm.ErrorForm errorForm = new ErrorForm.ErrorForm("Your weapon has no attack frames! Add at least \none attack frame in your fire state \nbefore continuing.");
                errorForm.Show();
            }
            else if(this.TextWeaponName.Text.Contains(" "))
            {
                ErrorForm.ErrorForm errorForm = new ErrorForm.ErrorForm("Your weapon Class Name cannot have spaces!\nRemove any spaces before continuing.");
                errorForm.Show();
            }
            else
            {
                WriteWeaponToFile();
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
                this.SetMissileArgsVisibility(false);
            }
            else if(this.InputStateFunction.SelectedItem.ToString().Equals("Fire Projectile"))
            {

                this.SetBulletArgsVisibility(false);
                this.SetMissileArgsVisibility(true);
            }
            else
            {
                this.SetBulletArgsVisibility(false);
                this.SetMissileArgsVisibility(false);
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
        private void SetMissileArgsVisibility(bool vis)
        {
            LabelMissileArg1.Visible = vis;
            LabelMissileArg2.Visible = vis;
            LabelMissileArg3.Visible = vis;
            InputMissileArg1.Visible = vis;
            InputMissileArg2.Visible = vis;
            InputMissileArg3.Visible = vis;
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
                this.StatesAdded.Items.RemoveAt(StatesAdded.Items.Count - 1);
            }
        }

        private void InputMissileArgs1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
