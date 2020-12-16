namespace AdventureGameProject
{
    partial class CharacterCreation
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
            this.cbCaffeine = new System.Windows.Forms.ComboBox();
            this.cbTypingSpeed = new System.Windows.Forms.ComboBox();
            this.cbPowerPointSkills = new System.Windows.Forms.ComboBox();
            this.cbAdaptibility = new System.Windows.Forms.ComboBox();
            this.lblCaffeine = new System.Windows.Forms.Label();
            this.lblAdaptibility = new System.Windows.Forms.Label();
            this.lblPowerPointSkills = new System.Windows.Forms.Label();
            this.lblTypingSpeed = new System.Windows.Forms.Label();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.cbCharacterPicture = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCaffeine
            // 
            this.cbCaffeine.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbCaffeine.FormattingEnabled = true;
            this.cbCaffeine.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCaffeine.Location = new System.Drawing.Point(257, 478);
            this.cbCaffeine.Name = "cbCaffeine";
            this.cbCaffeine.Size = new System.Drawing.Size(121, 21);
            this.cbCaffeine.TabIndex = 0;
            this.cbCaffeine.SelectedIndexChanged += new System.EventHandler(this.cbCaffeine_SelectedIndexChanged);
            // 
            // cbTypingSpeed
            // 
            this.cbTypingSpeed.FormattingEnabled = true;
            this.cbTypingSpeed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbTypingSpeed.Location = new System.Drawing.Point(52, 478);
            this.cbTypingSpeed.Name = "cbTypingSpeed";
            this.cbTypingSpeed.Size = new System.Drawing.Size(121, 21);
            this.cbTypingSpeed.TabIndex = 1;
            this.cbTypingSpeed.SelectedIndexChanged += new System.EventHandler(this.cbTypingSpeed_SelectedIndexChanged);
            // 
            // cbPowerPointSkills
            // 
            this.cbPowerPointSkills.FormattingEnabled = true;
            this.cbPowerPointSkills.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbPowerPointSkills.Location = new System.Drawing.Point(671, 478);
            this.cbPowerPointSkills.Name = "cbPowerPointSkills";
            this.cbPowerPointSkills.Size = new System.Drawing.Size(121, 21);
            this.cbPowerPointSkills.TabIndex = 2;
            this.cbPowerPointSkills.SelectedIndexChanged += new System.EventHandler(this.cbPowerPointSkills_SelectedIndexChanged_1);
            // 
            // cbAdaptibility
            // 
            this.cbAdaptibility.FormattingEnabled = true;
            this.cbAdaptibility.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbAdaptibility.Location = new System.Drawing.Point(461, 478);
            this.cbAdaptibility.Name = "cbAdaptibility";
            this.cbAdaptibility.Size = new System.Drawing.Size(121, 21);
            this.cbAdaptibility.TabIndex = 3;
            this.cbAdaptibility.SelectedIndexChanged += new System.EventHandler(this.cbAdaptibility_SelectedIndexChanged);
            // 
            // lblCaffeine
            // 
            this.lblCaffeine.AutoSize = true;
            this.lblCaffeine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaffeine.Location = new System.Drawing.Point(290, 441);
            this.lblCaffeine.Name = "lblCaffeine";
            this.lblCaffeine.Size = new System.Drawing.Size(77, 20);
            this.lblCaffeine.TabIndex = 4;
            this.lblCaffeine.Text = "Caffeine";
            // 
            // lblAdaptibility
            // 
            this.lblAdaptibility.AutoSize = true;
            this.lblAdaptibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaptibility.Location = new System.Drawing.Point(488, 441);
            this.lblAdaptibility.Name = "lblAdaptibility";
            this.lblAdaptibility.Size = new System.Drawing.Size(93, 20);
            this.lblAdaptibility.TabIndex = 5;
            this.lblAdaptibility.Text = "Adaptiblity";
            // 
            // lblPowerPointSkills
            // 
            this.lblPowerPointSkills.AutoSize = true;
            this.lblPowerPointSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerPointSkills.Location = new System.Drawing.Point(668, 441);
            this.lblPowerPointSkills.Name = "lblPowerPointSkills";
            this.lblPowerPointSkills.Size = new System.Drawing.Size(146, 20);
            this.lblPowerPointSkills.TabIndex = 6;
            this.lblPowerPointSkills.Text = "PowerPoint Skills";
            // 
            // lblTypingSpeed
            // 
            this.lblTypingSpeed.AutoSize = true;
            this.lblTypingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypingSpeed.Location = new System.Drawing.Point(67, 441);
            this.lblTypingSpeed.Name = "lblTypingSpeed";
            this.lblTypingSpeed.Size = new System.Drawing.Size(118, 20);
            this.lblTypingSpeed.TabIndex = 7;
            this.lblTypingSpeed.Text = "Typing Speed";
            // 
            // pbCharacter
            // 
            this.pbCharacter.Location = new System.Drawing.Point(341, 70);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(314, 307);
            this.pbCharacter.TabIndex = 8;
            this.pbCharacter.TabStop = false;
            // 
            // cbCharacterPicture
            // 
            this.cbCharacterPicture.FormattingEnabled = true;
            this.cbCharacterPicture.Items.AddRange(new object[] {
            "Laptop Larry",
            "Tuxedo Tom",
            "Casual Cameron",
            "Notebook Nancy"});
            this.cbCharacterPicture.Location = new System.Drawing.Point(433, 43);
            this.cbCharacterPicture.Name = "cbCharacterPicture";
            this.cbCharacterPicture.Size = new System.Drawing.Size(121, 21);
            this.cbCharacterPicture.TabIndex = 9;
            this.cbCharacterPicture.SelectedIndexChanged += new System.EventHandler(this.cbCharacterPicture_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(849, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCharacterPicture);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.lblTypingSpeed);
            this.Controls.Add(this.lblPowerPointSkills);
            this.Controls.Add(this.lblAdaptibility);
            this.Controls.Add(this.lblCaffeine);
            this.Controls.Add(this.cbAdaptibility);
            this.Controls.Add(this.cbPowerPointSkills);
            this.Controls.Add(this.cbTypingSpeed);
            this.Controls.Add(this.cbCaffeine);
            this.Name = "CharacterCreation";
            this.Text = "CharacterCreation";
            this.Load += new System.EventHandler(this.CharacterCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCaffeine;
        private System.Windows.Forms.ComboBox cbTypingSpeed;
        private System.Windows.Forms.ComboBox cbPowerPointSkills;
        private System.Windows.Forms.ComboBox cbAdaptibility;
        private System.Windows.Forms.Label lblCaffeine;
        private System.Windows.Forms.Label lblAdaptibility;
        private System.Windows.Forms.Label lblPowerPointSkills;
        private System.Windows.Forms.Label lblTypingSpeed;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.ComboBox cbCharacterPicture;
        private System.Windows.Forms.Button button1;
    }
}