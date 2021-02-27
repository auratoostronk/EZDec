
namespace MapEditor
{
    partial class CreateWeaponForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateWeaponForm));
            this.LabelAmmoType = new System.Windows.Forms.Label();
            this.InputAmmoType = new System.Windows.Forms.ComboBox();
            this.InputAmmoGive = new System.Windows.Forms.NumericUpDown();
            this.LabelAmmoGive = new System.Windows.Forms.Label();
            this.LabelAmmoUse = new System.Windows.Forms.Label();
            this.InputAmmoUse = new System.Windows.Forms.NumericUpDown();
            this.LabelSlotNumber = new System.Windows.Forms.Label();
            this.InputSlotNumber = new System.Windows.Forms.ComboBox();
            this.GroupWeaponProperties = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InputReadySpriteFrame = new System.Windows.Forms.TextBox();
            this.InputPickupSpriteFrame = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.InputPickupSprite = new System.Windows.Forms.TextBox();
            this.InputAttackSound = new System.Windows.Forms.TextBox();
            this.LabelAttackSound = new System.Windows.Forms.Label();
            this.TextWeaponName = new System.Windows.Forms.TextBox();
            this.TagWeaponName = new System.Windows.Forms.Label();
            this.ButtonCreateWeapon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.InputReadySprite = new System.Windows.Forms.TextBox();
            this.StatesAdded = new System.Windows.Forms.ListBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.decorateFunctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorFrameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddStateButton = new System.Windows.Forms.Button();
            this.RemoveStateButton = new System.Windows.Forms.Button();
            this.GroupWeaponAttackStates = new System.Windows.Forms.GroupBox();
            this.LabelStateSprite = new System.Windows.Forms.Label();
            this.InputStateSprite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputStateFrame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputStateDuration = new System.Windows.Forms.NumericUpDown();
            this.GroupActionArgs = new System.Windows.Forms.GroupBox();
            this.InputBulletsArg1 = new System.Windows.Forms.NumericUpDown();
            this.LabelBulletsArg1 = new System.Windows.Forms.Label();
            this.LabelBulletsArg2 = new System.Windows.Forms.Label();
            this.InputBulletsArg2 = new System.Windows.Forms.NumericUpDown();
            this.LabelBulletsArg3 = new System.Windows.Forms.Label();
            this.InputBulletsArg3 = new System.Windows.Forms.NumericUpDown();
            this.InputBulletsArg4 = new System.Windows.Forms.NumericUpDown();
            this.LabelBulletsArg4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputStateFunction = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputAmmoGive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputAmmoUse)).BeginInit();
            this.GroupWeaponProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decorateFunctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorFrameBindingSource)).BeginInit();
            this.GroupWeaponAttackStates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputStateDuration)).BeginInit();
            this.GroupActionArgs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputBulletsArg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputBulletsArg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputBulletsArg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputBulletsArg4)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAmmoType
            // 
            this.LabelAmmoType.AutoSize = true;
            this.LabelAmmoType.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAmmoType.Location = new System.Drawing.Point(7, 69);
            this.LabelAmmoType.Name = "LabelAmmoType";
            this.LabelAmmoType.Size = new System.Drawing.Size(76, 18);
            this.LabelAmmoType.TabIndex = 3;
            this.LabelAmmoType.Text = "Ammo Type";
            // 
            // InputAmmoType
            // 
            this.InputAmmoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputAmmoType.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAmmoType.FormattingEnabled = true;
            this.InputAmmoType.Items.AddRange(new object[] {
            "Clip",
            "Shell",
            "RocketAmmo",
            "Cell"});
            this.InputAmmoType.Location = new System.Drawing.Point(10, 92);
            this.InputAmmoType.MaxLength = 32;
            this.InputAmmoType.Name = "InputAmmoType";
            this.InputAmmoType.Size = new System.Drawing.Size(122, 26);
            this.InputAmmoType.TabIndex = 4;
            // 
            // InputAmmoGive
            // 
            this.InputAmmoGive.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAmmoGive.Location = new System.Drawing.Point(138, 93);
            this.InputAmmoGive.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.InputAmmoGive.Name = "InputAmmoGive";
            this.InputAmmoGive.Size = new System.Drawing.Size(41, 23);
            this.InputAmmoGive.TabIndex = 5;
            this.InputAmmoGive.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // LabelAmmoGive
            // 
            this.LabelAmmoGive.AutoSize = true;
            this.LabelAmmoGive.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAmmoGive.Location = new System.Drawing.Point(135, 71);
            this.LabelAmmoGive.Name = "LabelAmmoGive";
            this.LabelAmmoGive.Size = new System.Drawing.Size(76, 18);
            this.LabelAmmoGive.TabIndex = 6;
            this.LabelAmmoGive.Text = "Ammo Give";
            // 
            // LabelAmmoUse
            // 
            this.LabelAmmoUse.AutoSize = true;
            this.LabelAmmoUse.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAmmoUse.Location = new System.Drawing.Point(217, 71);
            this.LabelAmmoUse.Name = "LabelAmmoUse";
            this.LabelAmmoUse.Size = new System.Drawing.Size(70, 18);
            this.LabelAmmoUse.TabIndex = 8;
            this.LabelAmmoUse.Text = "Ammo Use";
            // 
            // InputAmmoUse
            // 
            this.InputAmmoUse.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAmmoUse.Location = new System.Drawing.Point(219, 92);
            this.InputAmmoUse.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.InputAmmoUse.Name = "InputAmmoUse";
            this.InputAmmoUse.Size = new System.Drawing.Size(43, 23);
            this.InputAmmoUse.TabIndex = 7;
            this.InputAmmoUse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelSlotNumber
            // 
            this.LabelSlotNumber.AutoSize = true;
            this.LabelSlotNumber.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSlotNumber.Location = new System.Drawing.Point(293, 71);
            this.LabelSlotNumber.Name = "LabelSlotNumber";
            this.LabelSlotNumber.Size = new System.Drawing.Size(79, 18);
            this.LabelSlotNumber.TabIndex = 9;
            this.LabelSlotNumber.Text = "Slot Number";
            // 
            // InputSlotNumber
            // 
            this.InputSlotNumber.DisplayMember = "Int";
            this.InputSlotNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputSlotNumber.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSlotNumber.FormattingEnabled = true;
            this.InputSlotNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.InputSlotNumber.Location = new System.Drawing.Point(296, 93);
            this.InputSlotNumber.Name = "InputSlotNumber";
            this.InputSlotNumber.Size = new System.Drawing.Size(76, 26);
            this.InputSlotNumber.TabIndex = 10;
            this.InputSlotNumber.Tag = "0";
            // 
            // GroupWeaponProperties
            // 
            this.GroupWeaponProperties.Controls.Add(this.label7);
            this.GroupWeaponProperties.Controls.Add(this.InputReadySpriteFrame);
            this.GroupWeaponProperties.Controls.Add(this.InputPickupSpriteFrame);
            this.GroupWeaponProperties.Controls.Add(this.label5);
            this.GroupWeaponProperties.Controls.Add(this.label8);
            this.GroupWeaponProperties.Controls.Add(this.InputPickupSprite);
            this.GroupWeaponProperties.Controls.Add(this.InputAttackSound);
            this.GroupWeaponProperties.Controls.Add(this.LabelAttackSound);
            this.GroupWeaponProperties.Controls.Add(this.TextWeaponName);
            this.GroupWeaponProperties.Controls.Add(this.TagWeaponName);
            this.GroupWeaponProperties.Controls.Add(this.LabelSlotNumber);
            this.GroupWeaponProperties.Controls.Add(this.InputSlotNumber);
            this.GroupWeaponProperties.Controls.Add(this.LabelAmmoType);
            this.GroupWeaponProperties.Controls.Add(this.InputAmmoType);
            this.GroupWeaponProperties.Controls.Add(this.LabelAmmoUse);
            this.GroupWeaponProperties.Controls.Add(this.InputAmmoGive);
            this.GroupWeaponProperties.Controls.Add(this.InputAmmoUse);
            this.GroupWeaponProperties.Controls.Add(this.LabelAmmoGive);
            this.GroupWeaponProperties.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupWeaponProperties.Location = new System.Drawing.Point(19, 13);
            this.GroupWeaponProperties.Name = "GroupWeaponProperties";
            this.GroupWeaponProperties.Size = new System.Drawing.Size(592, 131);
            this.GroupWeaponProperties.TabIndex = 12;
            this.GroupWeaponProperties.TabStop = false;
            this.GroupWeaponProperties.Text = "Weapon Properties";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pickup Sprite";
            // 
            // InputReadySpriteFrame
            // 
            this.InputReadySpriteFrame.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputReadySpriteFrame.Location = new System.Drawing.Point(491, 43);
            this.InputReadySpriteFrame.MaxLength = 1;
            this.InputReadySpriteFrame.Name = "InputReadySpriteFrame";
            this.InputReadySpriteFrame.Size = new System.Drawing.Size(42, 23);
            this.InputReadySpriteFrame.TabIndex = 17;
            this.InputReadySpriteFrame.Tag = "";
            this.InputReadySpriteFrame.Text = "A";
            // 
            // InputPickupSpriteFrame
            // 
            this.InputPickupSpriteFrame.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPickupSpriteFrame.Location = new System.Drawing.Point(491, 93);
            this.InputPickupSpriteFrame.MaxLength = 1;
            this.InputPickupSpriteFrame.Name = "InputPickupSpriteFrame";
            this.InputPickupSpriteFrame.Size = new System.Drawing.Size(42, 23);
            this.InputPickupSpriteFrame.TabIndex = 21;
            this.InputPickupSpriteFrame.Tag = "";
            this.InputPickupSpriteFrame.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Frame";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(488, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Frame";
            // 
            // InputPickupSprite
            // 
            this.InputPickupSprite.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPickupSprite.Location = new System.Drawing.Point(400, 92);
            this.InputPickupSprite.MaxLength = 4;
            this.InputPickupSprite.Name = "InputPickupSprite";
            this.InputPickupSprite.Size = new System.Drawing.Size(57, 23);
            this.InputPickupSprite.TabIndex = 19;
            this.InputPickupSprite.Tag = "";
            this.InputPickupSprite.Text = "PIST";
            // 
            // InputAttackSound
            // 
            this.InputAttackSound.AcceptsReturn = true;
            this.InputAttackSound.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAttackSound.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InputAttackSound.Location = new System.Drawing.Point(170, 43);
            this.InputAttackSound.Name = "InputAttackSound";
            this.InputAttackSound.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputAttackSound.Size = new System.Drawing.Size(202, 23);
            this.InputAttackSound.TabIndex = 4;
            this.InputAttackSound.Text = "weapons/pistol";
            // 
            // LabelAttackSound
            // 
            this.LabelAttackSound.AutoSize = true;
            this.LabelAttackSound.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAttackSound.Location = new System.Drawing.Point(167, 22);
            this.LabelAttackSound.Name = "LabelAttackSound";
            this.LabelAttackSound.Size = new System.Drawing.Size(85, 18);
            this.LabelAttackSound.TabIndex = 13;
            this.LabelAttackSound.Text = "Attack Sound";
            // 
            // TextWeaponName
            // 
            this.TextWeaponName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextWeaponName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextWeaponName.Location = new System.Drawing.Point(9, 43);
            this.TextWeaponName.Name = "TextWeaponName";
            this.TextWeaponName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextWeaponName.Size = new System.Drawing.Size(153, 23);
            this.TextWeaponName.TabIndex = 12;
            this.TextWeaponName.Text = "MyPistol";
            // 
            // TagWeaponName
            // 
            this.TagWeaponName.AutoSize = true;
            this.TagWeaponName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagWeaponName.Location = new System.Drawing.Point(6, 22);
            this.TagWeaponName.Name = "TagWeaponName";
            this.TagWeaponName.Size = new System.Drawing.Size(88, 18);
            this.TagWeaponName.TabIndex = 11;
            this.TagWeaponName.Text = "Weapon Class";
            // 
            // ButtonCreateWeapon
            // 
            this.ButtonCreateWeapon.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreateWeapon.Location = new System.Drawing.Point(523, 324);
            this.ButtonCreateWeapon.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCreateWeapon.Name = "ButtonCreateWeapon";
            this.ButtonCreateWeapon.Size = new System.Drawing.Size(88, 24);
            this.ButtonCreateWeapon.TabIndex = 13;
            this.ButtonCreateWeapon.Text = "Create";
            this.ButtonCreateWeapon.UseVisualStyleBackColor = true;
            this.ButtonCreateWeapon.Click += new System.EventHandler(this.WriteWeaponToFile);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Idle Sprite";
            // 
            // InputReadySprite
            // 
            this.InputReadySprite.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputReadySprite.Location = new System.Drawing.Point(420, 56);
            this.InputReadySprite.MaxLength = 4;
            this.InputReadySprite.Name = "InputReadySprite";
            this.InputReadySprite.Size = new System.Drawing.Size(57, 23);
            this.InputReadySprite.TabIndex = 15;
            this.InputReadySprite.Tag = "";
            this.InputReadySprite.Text = "PISG";
            // 
            // StatesAdded
            // 
            this.StatesAdded.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatesAdded.FormattingEnabled = true;
            this.StatesAdded.ItemHeight = 18;
            this.StatesAdded.Location = new System.Drawing.Point(421, 173);
            this.StatesAdded.Name = "StatesAdded";
            this.StatesAdded.Size = new System.Drawing.Size(190, 130);
            this.StatesAdded.TabIndex = 17;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(426, 324);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(89, 24);
            this.ButtonCancel.TabIndex = 18;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // decorateFunctionBindingSource
            // 
            this.decorateFunctionBindingSource.DataSource = typeof(DecorateFunction.DecorateFunction);
            // 
            // actorFrameBindingSource
            // 
            this.actorFrameBindingSource.DataSource = typeof(ActorFrame.ActorFrame);
            // 
            // AddStateButton
            // 
            this.AddStateButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStateButton.Location = new System.Drawing.Point(296, 153);
            this.AddStateButton.Name = "AddStateButton";
            this.AddStateButton.Size = new System.Drawing.Size(75, 23);
            this.AddStateButton.TabIndex = 0;
            this.AddStateButton.Text = "Add";
            this.AddStateButton.UseVisualStyleBackColor = true;
            this.AddStateButton.Click += new System.EventHandler(this.AddActorFrame);
            // 
            // RemoveStateButton
            // 
            this.RemoveStateButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveStateButton.Location = new System.Drawing.Point(212, 153);
            this.RemoveStateButton.Name = "RemoveStateButton";
            this.RemoveStateButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveStateButton.TabIndex = 15;
            this.RemoveStateButton.Text = "Remove";
            this.RemoveStateButton.UseVisualStyleBackColor = true;
            this.RemoveStateButton.Click += new System.EventHandler(this.RemoveActorFrame);
            // 
            // GroupWeaponAttackStates
            // 
            this.GroupWeaponAttackStates.Controls.Add(this.RemoveStateButton);
            this.GroupWeaponAttackStates.Controls.Add(this.GroupActionArgs);
            this.GroupWeaponAttackStates.Controls.Add(this.label3);
            this.GroupWeaponAttackStates.Controls.Add(this.InputStateFunction);
            this.GroupWeaponAttackStates.Controls.Add(this.label2);
            this.GroupWeaponAttackStates.Controls.Add(this.InputStateDuration);
            this.GroupWeaponAttackStates.Controls.Add(this.label1);
            this.GroupWeaponAttackStates.Controls.Add(this.InputStateFrame);
            this.GroupWeaponAttackStates.Controls.Add(this.LabelStateSprite);
            this.GroupWeaponAttackStates.Controls.Add(this.InputStateSprite);
            this.GroupWeaponAttackStates.Controls.Add(this.AddStateButton);
            this.GroupWeaponAttackStates.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupWeaponAttackStates.Location = new System.Drawing.Point(19, 166);
            this.GroupWeaponAttackStates.Name = "GroupWeaponAttackStates";
            this.GroupWeaponAttackStates.Size = new System.Drawing.Size(393, 182);
            this.GroupWeaponAttackStates.TabIndex = 14;
            this.GroupWeaponAttackStates.TabStop = false;
            this.GroupWeaponAttackStates.Text = "Weapon Attack States";
            // 
            // LabelStateSprite
            // 
            this.LabelStateSprite.AutoSize = true;
            this.LabelStateSprite.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStateSprite.Location = new System.Drawing.Point(9, 28);
            this.LabelStateSprite.Name = "LabelStateSprite";
            this.LabelStateSprite.Size = new System.Drawing.Size(43, 18);
            this.LabelStateSprite.TabIndex = 2;
            this.LabelStateSprite.Text = "Sprite";
            // 
            // InputStateSprite
            // 
            this.InputStateSprite.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputStateSprite.Location = new System.Drawing.Point(9, 49);
            this.InputStateSprite.MaxLength = 4;
            this.InputStateSprite.Name = "InputStateSprite";
            this.InputStateSprite.Size = new System.Drawing.Size(57, 23);
            this.InputStateSprite.TabIndex = 1;
            this.InputStateSprite.Tag = "";
            this.InputStateSprite.Text = "PISG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Frame";
            // 
            // InputStateFrame
            // 
            this.InputStateFrame.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputStateFrame.Location = new System.Drawing.Point(76, 49);
            this.InputStateFrame.MaxLength = 1;
            this.InputStateFrame.Name = "InputStateFrame";
            this.InputStateFrame.Size = new System.Drawing.Size(42, 23);
            this.InputStateFrame.TabIndex = 3;
            this.InputStateFrame.Tag = "";
            this.InputStateFrame.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Duration";
            // 
            // InputStateDuration
            // 
            this.InputStateDuration.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputStateDuration.Location = new System.Drawing.Point(126, 49);
            this.InputStateDuration.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.InputStateDuration.Name = "InputStateDuration";
            this.InputStateDuration.Size = new System.Drawing.Size(43, 23);
            this.InputStateDuration.TabIndex = 9;
            this.InputStateDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GroupActionArgs
            // 
            this.GroupActionArgs.Controls.Add(this.InputBulletsArg4);
            this.GroupActionArgs.Controls.Add(this.LabelBulletsArg4);
            this.GroupActionArgs.Controls.Add(this.InputBulletsArg3);
            this.GroupActionArgs.Controls.Add(this.LabelBulletsArg3);
            this.GroupActionArgs.Controls.Add(this.InputBulletsArg2);
            this.GroupActionArgs.Controls.Add(this.LabelBulletsArg2);
            this.GroupActionArgs.Controls.Add(this.LabelBulletsArg1);
            this.GroupActionArgs.Controls.Add(this.InputBulletsArg1);
            this.GroupActionArgs.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupActionArgs.Location = new System.Drawing.Point(7, 78);
            this.GroupActionArgs.Name = "GroupActionArgs";
            this.GroupActionArgs.Size = new System.Drawing.Size(365, 69);
            this.GroupActionArgs.TabIndex = 14;
            this.GroupActionArgs.TabStop = false;
            this.GroupActionArgs.Text = "Arguments";
            // 
            // InputBulletsArg1
            // 
            this.InputBulletsArg1.DecimalPlaces = 1;
            this.InputBulletsArg1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.InputBulletsArg1.Location = new System.Drawing.Point(2, 40);
            this.InputBulletsArg1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.InputBulletsArg1.Name = "InputBulletsArg1";
            this.InputBulletsArg1.Size = new System.Drawing.Size(74, 23);
            this.InputBulletsArg1.TabIndex = 0;
            this.InputBulletsArg1.Value = new decimal(new int[] {
            56,
            0,
            0,
            65536});
            this.InputBulletsArg1.Visible = false;
            // 
            // LabelBulletsArg1
            // 
            this.LabelBulletsArg1.AutoSize = true;
            this.LabelBulletsArg1.Location = new System.Drawing.Point(2, 19);
            this.LabelBulletsArg1.Name = "LabelBulletsArg1";
            this.LabelBulletsArg1.Size = new System.Drawing.Size(59, 18);
            this.LabelBulletsArg1.TabIndex = 1;
            this.LabelBulletsArg1.Text = "X Spread";
            this.LabelBulletsArg1.Visible = false;
            // 
            // LabelBulletsArg2
            // 
            this.LabelBulletsArg2.AutoSize = true;
            this.LabelBulletsArg2.Location = new System.Drawing.Point(80, 19);
            this.LabelBulletsArg2.Name = "LabelBulletsArg2";
            this.LabelBulletsArg2.Size = new System.Drawing.Size(59, 18);
            this.LabelBulletsArg2.TabIndex = 3;
            this.LabelBulletsArg2.Text = "Y Spread";
            this.LabelBulletsArg2.Visible = false;
            // 
            // InputBulletsArg2
            // 
            this.InputBulletsArg2.DecimalPlaces = 1;
            this.InputBulletsArg2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.InputBulletsArg2.Location = new System.Drawing.Point(83, 40);
            this.InputBulletsArg2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.InputBulletsArg2.Name = "InputBulletsArg2";
            this.InputBulletsArg2.Size = new System.Drawing.Size(79, 23);
            this.InputBulletsArg2.TabIndex = 4;
            this.InputBulletsArg2.Visible = false;
            // 
            // LabelBulletsArg3
            // 
            this.LabelBulletsArg3.AutoSize = true;
            this.LabelBulletsArg3.Location = new System.Drawing.Point(175, 19);
            this.LabelBulletsArg3.Name = "LabelBulletsArg3";
            this.LabelBulletsArg3.Size = new System.Drawing.Size(80, 18);
            this.LabelBulletsArg3.TabIndex = 5;
            this.LabelBulletsArg3.Text = "Bullets Fired";
            this.LabelBulletsArg3.Visible = false;
            // 
            // InputBulletsArg3
            // 
            this.InputBulletsArg3.Location = new System.Drawing.Point(178, 40);
            this.InputBulletsArg3.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.InputBulletsArg3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputBulletsArg3.Name = "InputBulletsArg3";
            this.InputBulletsArg3.Size = new System.Drawing.Size(77, 23);
            this.InputBulletsArg3.TabIndex = 6;
            this.InputBulletsArg3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputBulletsArg3.Visible = false;
            // 
            // InputBulletsArg4
            // 
            this.InputBulletsArg4.Location = new System.Drawing.Point(271, 40);
            this.InputBulletsArg4.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.InputBulletsArg4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputBulletsArg4.Name = "InputBulletsArg4";
            this.InputBulletsArg4.Size = new System.Drawing.Size(88, 23);
            this.InputBulletsArg4.TabIndex = 8;
            this.InputBulletsArg4.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.InputBulletsArg4.Visible = false;
            // 
            // LabelBulletsArg4
            // 
            this.LabelBulletsArg4.AutoSize = true;
            this.LabelBulletsArg4.Location = new System.Drawing.Point(273, 19);
            this.LabelBulletsArg4.Name = "LabelBulletsArg4";
            this.LabelBulletsArg4.Size = new System.Drawing.Size(91, 18);
            this.LabelBulletsArg4.TabIndex = 7;
            this.LabelBulletsArg4.Text = "Damage x 1d3";
            this.LabelBulletsArg4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelBulletsArg4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Action Function";
            // 
            // InputStateFunction
            // 
            this.InputStateFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputStateFunction.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputStateFunction.FormattingEnabled = true;
            this.InputStateFunction.Items.AddRange(new object[] {
            "None",
            "Fire Hitscan",
            "Fire Projectile",
            "Fire Railgun"});
            this.InputStateFunction.Location = new System.Drawing.Point(188, 46);
            this.InputStateFunction.Name = "InputStateFunction";
            this.InputStateFunction.Size = new System.Drawing.Size(184, 26);
            this.InputStateFunction.TabIndex = 11;
            this.InputStateFunction.Tag = "";
            this.InputStateFunction.DropDownClosed += new System.EventHandler(this.OnActionFunctionSelected);
            // 
            // CreateWeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.StatesAdded);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InputReadySprite);
            this.Controls.Add(this.GroupWeaponAttackStates);
            this.Controls.Add(this.ButtonCreateWeapon);
            this.Controls.Add(this.GroupWeaponProperties);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateWeaponForm";
            this.Text = "Create a New Weapon";
            ((System.ComponentModel.ISupportInitialize)(this.InputAmmoGive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputAmmoUse)).EndInit();
            this.GroupWeaponProperties.ResumeLayout(false);
            this.GroupWeaponProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decorateFunctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorFrameBindingSource)).EndInit();
            this.GroupWeaponAttackStates.ResumeLayout(false);
            this.GroupWeaponAttackStates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputStateDuration)).EndInit();
            this.GroupActionArgs.ResumeLayout(false);
            this.GroupActionArgs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputBulletsArg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputBulletsArg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputBulletsArg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputBulletsArg4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelAmmoType;
        private System.Windows.Forms.ComboBox InputAmmoType;
        private System.Windows.Forms.NumericUpDown InputAmmoGive;
        private System.Windows.Forms.Label LabelAmmoGive;
        private System.Windows.Forms.Label LabelAmmoUse;
        private System.Windows.Forms.NumericUpDown InputAmmoUse;
        private System.Windows.Forms.Label LabelSlotNumber;
        private System.Windows.Forms.ComboBox InputSlotNumber;
        private System.Windows.Forms.GroupBox GroupWeaponProperties;
        private System.Windows.Forms.Button ButtonCreateWeapon;
        private System.Windows.Forms.TextBox TextWeaponName;
        private System.Windows.Forms.Label TagWeaponName;
        private System.Windows.Forms.TextBox InputAttackSound;
        private System.Windows.Forms.Label LabelAttackSound;
        private System.Windows.Forms.BindingSource decorateFunctionBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InputReadySpriteFrame;
        private System.Windows.Forms.TextBox InputPickupSpriteFrame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox InputPickupSprite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputReadySprite;
        private System.Windows.Forms.ListBox StatesAdded;
        private System.Windows.Forms.BindingSource actorFrameBindingSource;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button AddStateButton;
        private System.Windows.Forms.Button RemoveStateButton;
        private System.Windows.Forms.GroupBox GroupWeaponAttackStates;
        private System.Windows.Forms.GroupBox GroupActionArgs;
        private System.Windows.Forms.NumericUpDown InputBulletsArg4;
        private System.Windows.Forms.Label LabelBulletsArg4;
        private System.Windows.Forms.NumericUpDown InputBulletsArg3;
        private System.Windows.Forms.Label LabelBulletsArg3;
        private System.Windows.Forms.NumericUpDown InputBulletsArg2;
        private System.Windows.Forms.Label LabelBulletsArg2;
        private System.Windows.Forms.Label LabelBulletsArg1;
        private System.Windows.Forms.NumericUpDown InputBulletsArg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox InputStateFunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown InputStateDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputStateFrame;
        private System.Windows.Forms.Label LabelStateSprite;
        private System.Windows.Forms.TextBox InputStateSprite;
    }
}

