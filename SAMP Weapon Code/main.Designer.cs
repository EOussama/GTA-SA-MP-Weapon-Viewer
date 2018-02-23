namespace SAMP_Weapon_Code
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.lWeaponName = new System.Windows.Forms.Label();
            this.bNext = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lWeaponSlotPH = new System.Windows.Forms.Label();
            this.lWeaponModelPH = new System.Windows.Forms.Label();
            this.lWeaponIDPH = new System.Windows.Forms.Label();
            this.lWeaponSlot = new System.Windows.Forms.Label();
            this.lWeaponModel = new System.Windows.Forms.Label();
            this.lWeaponID = new System.Windows.Forms.Label();
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.bPrevious = new System.Windows.Forms.Button();
            this.pWeaponName = new System.Windows.Forms.Panel();
            this.bFirst = new System.Windows.Forms.Button();
            this.bLast = new System.Windows.Forms.Button();
            this.nupEntity = new System.Windows.Forms.NumericUpDown();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbWeaponPicture = new System.Windows.Forms.PictureBox();
            this.lVersion = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            this.pWeaponName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEntity)).BeginInit();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeaponPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lWeaponName
            // 
            this.lWeaponName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lWeaponName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWeaponName.Location = new System.Drawing.Point(0, 0);
            this.lWeaponName.Name = "lWeaponName";
            this.lWeaponName.Size = new System.Drawing.Size(277, 17);
            this.lWeaponName.TabIndex = 1;
            this.lWeaponName.Text = "Weapon Name";
            // 
            // bNext
            // 
            this.bNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNext.Location = new System.Drawing.Point(123, 203);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(48, 34);
            this.bNext.TabIndex = 3;
            this.bNext.Text = ">";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lWeaponSlotPH);
            this.gbInfo.Controls.Add(this.lWeaponModelPH);
            this.gbInfo.Controls.Add(this.lWeaponIDPH);
            this.gbInfo.Controls.Add(this.lWeaponSlot);
            this.gbInfo.Controls.Add(this.lWeaponModel);
            this.gbInfo.Controls.Add(this.lWeaponID);
            this.gbInfo.Location = new System.Drawing.Point(150, 40);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(139, 93);
            this.gbInfo.TabIndex = 4;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Weapon info";
            // 
            // lWeaponSlotPH
            // 
            this.lWeaponSlotPH.AutoSize = true;
            this.lWeaponSlotPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWeaponSlotPH.Location = new System.Drawing.Point(108, 74);
            this.lWeaponSlotPH.Name = "lWeaponSlotPH";
            this.lWeaponSlotPH.Size = new System.Drawing.Size(0, 13);
            this.lWeaponSlotPH.TabIndex = 6;
            // 
            // lWeaponModelPH
            // 
            this.lWeaponModelPH.AutoSize = true;
            this.lWeaponModelPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWeaponModelPH.Location = new System.Drawing.Point(108, 49);
            this.lWeaponModelPH.Name = "lWeaponModelPH";
            this.lWeaponModelPH.Size = new System.Drawing.Size(0, 13);
            this.lWeaponModelPH.TabIndex = 5;
            // 
            // lWeaponIDPH
            // 
            this.lWeaponIDPH.AutoSize = true;
            this.lWeaponIDPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWeaponIDPH.Location = new System.Drawing.Point(108, 23);
            this.lWeaponIDPH.Name = "lWeaponIDPH";
            this.lWeaponIDPH.Size = new System.Drawing.Size(0, 13);
            this.lWeaponIDPH.TabIndex = 4;
            // 
            // lWeaponSlot
            // 
            this.lWeaponSlot.AutoSize = true;
            this.lWeaponSlot.Location = new System.Drawing.Point(6, 74);
            this.lWeaponSlot.Name = "lWeaponSlot";
            this.lWeaponSlot.Size = new System.Drawing.Size(25, 13);
            this.lWeaponSlot.TabIndex = 2;
            this.lWeaponSlot.Text = "Slot";
            // 
            // lWeaponModel
            // 
            this.lWeaponModel.AutoSize = true;
            this.lWeaponModel.Location = new System.Drawing.Point(6, 49);
            this.lWeaponModel.Name = "lWeaponModel";
            this.lWeaponModel.Size = new System.Drawing.Size(36, 13);
            this.lWeaponModel.TabIndex = 1;
            this.lWeaponModel.Text = "Model";
            // 
            // lWeaponID
            // 
            this.lWeaponID.AutoSize = true;
            this.lWeaponID.Location = new System.Drawing.Point(6, 23);
            this.lWeaponID.Name = "lWeaponID";
            this.lWeaponID.Size = new System.Drawing.Size(18, 13);
            this.lWeaponID.TabIndex = 0;
            this.lWeaponID.Text = "ID";
            // 
            // ssInfo
            // 
            this.ssInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ssInfo.Location = new System.Drawing.Point(0, 245);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(301, 22);
            this.ssInfo.TabIndex = 5;
            this.ssInfo.Text = "SA-MP Loaded";
            // 
            // bPrevious
            // 
            this.bPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrevious.Location = new System.Drawing.Point(69, 203);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(48, 34);
            this.bPrevious.TabIndex = 2;
            this.bPrevious.Text = "<";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.button1_Click);
            // 
            // pWeaponName
            // 
            this.pWeaponName.Controls.Add(this.lWeaponName);
            this.pWeaponName.Location = new System.Drawing.Point(26, 139);
            this.pWeaponName.Name = "pWeaponName";
            this.pWeaponName.Size = new System.Drawing.Size(252, 17);
            this.pWeaponName.TabIndex = 7;
            // 
            // bFirst
            // 
            this.bFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFirst.Location = new System.Drawing.Point(15, 203);
            this.bFirst.Name = "bFirst";
            this.bFirst.Size = new System.Drawing.Size(48, 34);
            this.bFirst.TabIndex = 8;
            this.bFirst.Text = "<<";
            this.bFirst.UseVisualStyleBackColor = true;
            this.bFirst.Click += new System.EventHandler(this.bFirst_Click);
            // 
            // bLast
            // 
            this.bLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLast.Location = new System.Drawing.Point(177, 203);
            this.bLast.Name = "bLast";
            this.bLast.Size = new System.Drawing.Size(48, 34);
            this.bLast.TabIndex = 9;
            this.bLast.Text = ">>";
            this.bLast.UseVisualStyleBackColor = true;
            this.bLast.Click += new System.EventHandler(this.bLast_Click);
            // 
            // nupEntity
            // 
            this.nupEntity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nupEntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupEntity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nupEntity.Location = new System.Drawing.Point(231, 203);
            this.nupEntity.Maximum = new decimal(new int[] {
            43,
            0,
            0,
            0});
            this.nupEntity.Name = "nupEntity";
            this.nupEntity.Size = new System.Drawing.Size(58, 35);
            this.nupEntity.TabIndex = 10;
            this.nupEntity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupEntity.ValueChanged += new System.EventHandler(this.nupEntity_ValueChanged);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(301, 24);
            this.msMenu.TabIndex = 11;
            this.msMenu.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pbWeaponPicture
            // 
            this.pbWeaponPicture.Image = global::SAMP_Weapon_Code.Properties.Resources.tec9icon;
            this.pbWeaponPicture.Location = new System.Drawing.Point(12, 38);
            this.pbWeaponPicture.Name = "pbWeaponPicture";
            this.pbWeaponPicture.Size = new System.Drawing.Size(118, 95);
            this.pbWeaponPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeaponPicture.TabIndex = 0;
            this.pbWeaponPicture.TabStop = false;
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.BackColor = System.Drawing.Color.White;
            this.lVersion.Location = new System.Drawing.Point(270, 5);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(28, 13);
            this.lVersion.TabIndex = 12;
            this.lVersion.Text = "v0.2";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 267);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.nupEntity);
            this.Controls.Add(this.bLast);
            this.Controls.Add(this.bFirst);
            this.Controls.Add(this.pWeaponName);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.pbWeaponPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTA SA-MP Weapon Viewer";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.pWeaponName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupEntity)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeaponPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWeaponPicture;
        private System.Windows.Forms.Label lWeaponName;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lWeaponSlotPH;
        private System.Windows.Forms.Label lWeaponModelPH;
        private System.Windows.Forms.Label lWeaponIDPH;
        private System.Windows.Forms.Label lWeaponSlot;
        private System.Windows.Forms.Label lWeaponModel;
        private System.Windows.Forms.Label lWeaponID;
        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.Panel pWeaponName;
        private System.Windows.Forms.Button bFirst;
        private System.Windows.Forms.Button bLast;
        private System.Windows.Forms.NumericUpDown nupEntity;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lVersion;
    }
}

