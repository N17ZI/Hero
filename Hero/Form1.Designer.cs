namespace Hero
{
    partial class lblLVL
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbHeroes = new System.Windows.Forms.ComboBox();
            this.trbS = new System.Windows.Forms.TrackBar();
            this.trbD = new System.Windows.Forms.TrackBar();
            this.trbi = new System.Windows.Forms.TrackBar();
            this.trbC = new System.Windows.Forms.TrackBar();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lbli = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtInfoUser = new System.Windows.Forms.TextBox();
            this.cmbGun = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtLvl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.lblExp = new System.Windows.Forms.Label();
            this.cNames = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHeroes
            // 
            this.cmbHeroes.FormattingEnabled = true;
            this.cmbHeroes.Items.AddRange(new object[] {
            "Warrior",
            "Wizard",
            "Rogue"});
            this.cmbHeroes.Location = new System.Drawing.Point(12, 12);
            this.cmbHeroes.Name = "cmbHeroes";
            this.cmbHeroes.Size = new System.Drawing.Size(121, 23);
            this.cmbHeroes.TabIndex = 0;
            this.cmbHeroes.SelectedIndexChanged += new System.EventHandler(this.cmbHeroes_SelectedIndexChanged);
            // 
            // trbS
            // 
            this.trbS.Location = new System.Drawing.Point(17, 169);
            this.trbS.Maximum = 0;
            this.trbS.Name = "trbS";
            this.trbS.Size = new System.Drawing.Size(147, 45);
            this.trbS.TabIndex = 1;
            this.trbS.Scroll += new System.EventHandler(this.trbS_Scroll);
            // 
            // trbD
            // 
            this.trbD.Location = new System.Drawing.Point(216, 169);
            this.trbD.Maximum = 0;
            this.trbD.Name = "trbD";
            this.trbD.Size = new System.Drawing.Size(170, 45);
            this.trbD.TabIndex = 2;
            this.trbD.Scroll += new System.EventHandler(this.trbD_Scroll);
            // 
            // trbi
            // 
            this.trbi.Location = new System.Drawing.Point(17, 265);
            this.trbi.Maximum = 50;
            this.trbi.Minimum = 10;
            this.trbi.Name = "trbi";
            this.trbi.Size = new System.Drawing.Size(147, 45);
            this.trbi.TabIndex = 3;
            this.trbi.Value = 10;
            this.trbi.Scroll += new System.EventHandler(this.trbi_Scroll);
            // 
            // trbC
            // 
            this.trbC.Location = new System.Drawing.Point(216, 265);
            this.trbC.Maximum = 100;
            this.trbC.Minimum = 20;
            this.trbC.Name = "trbC";
            this.trbC.Size = new System.Drawing.Size(170, 45);
            this.trbC.TabIndex = 4;
            this.trbC.Value = 20;
            this.trbC.Scroll += new System.EventHandler(this.trbC_Scroll);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(216, 136);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(54, 15);
            this.lblD.TabIndex = 5;
            this.lblD.Text = "Dexterity";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(228, 240);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(73, 15);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "Constitution";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(17, 136);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(52, 15);
            this.lblS.TabIndex = 7;
            this.lblS.Text = "Strendth";
            // 
            // lbli
            // 
            this.lbli.AutoSize = true;
            this.lbli.Location = new System.Drawing.Point(17, 240);
            this.lbli.Name = "lbli";
            this.lbli.Size = new System.Drawing.Size(67, 15);
            this.lbli.TabIndex = 8;
            this.lbli.Text = "Intelligense";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(17, 344);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 40);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtInfoUser
            // 
            this.txtInfoUser.Location = new System.Drawing.Point(883, 88);
            this.txtInfoUser.Multiline = true;
            this.txtInfoUser.Name = "txtInfoUser";
            this.txtInfoUser.Size = new System.Drawing.Size(305, 323);
            this.txtInfoUser.TabIndex = 10;
            // 
            // cmbGun
            // 
            this.cmbGun.FormattingEnabled = true;
            this.cmbGun.Items.AddRange(new object[] {
            "Knife",
            "Spear",
            "Granade",
            "Platemail",
            "blade mail"});
            this.cmbGun.Location = new System.Drawing.Point(12, 64);
            this.cmbGun.Name = "cmbGun";
            this.cmbGun.Size = new System.Drawing.Size(121, 23);
            this.cmbGun.TabIndex = 11;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(201, 64);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Your Name";
            this.txtUser.Size = new System.Drawing.Size(126, 23);
            this.txtUser.TabIndex = 12;
            // 
            // txtLvl
            // 
            this.txtLvl.Enabled = false;
            this.txtLvl.Location = new System.Drawing.Point(674, 196);
            this.txtLvl.Name = "txtLvl";
            this.txtLvl.Size = new System.Drawing.Size(46, 23);
            this.txtLvl.TabIndex = 13;
            this.txtLvl.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "lvl";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(649, 153);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(75, 23);
            this.btnUpgrade.TabIndex = 15;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(649, 115);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(100, 23);
            this.txtExp.TabIndex = 16;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(649, 91);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(29, 15);
            this.lblExp.TabIndex = 17;
            this.lblExp.Text = "Exp:";
            // 
            // cNames
            // 
            this.cNames.FormattingEnabled = true;
            this.cNames.Location = new System.Drawing.Point(201, 12);
            this.cNames.Name = "cNames";
            this.cNames.Size = new System.Drawing.Size(121, 23);
            this.cNames.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(177, 344);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblLVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 587);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cNames);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLvl);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cmbGun);
            this.Controls.Add(this.txtInfoUser);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbli);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.trbC);
            this.Controls.Add(this.trbi);
            this.Controls.Add(this.trbD);
            this.Controls.Add(this.trbS);
            this.Controls.Add(this.cmbHeroes);
            this.Name = "lblLVL";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbHeroes;
        private TrackBar trbS;
        private TrackBar trbD;
        private TrackBar trbi;
        private TrackBar trbC;
        private Label lblD;
        private Label lblC;
        private Label lblS;
        private Label lbli;
        private Button btnCreate;
        private TextBox txtInfoUser;
        private ComboBox cmbGun;
        private TextBox txtUser;
        private TextBox txtLvl;
        private Label label1;
        private Button btnUpgrade;
        private TextBox txtExp;
        private Label lblExp;
        private ComboBox cNames;
        private Button btnUpdate;
    }
}