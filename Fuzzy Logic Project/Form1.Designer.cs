namespace Fuzzy_Logic_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.healthPercentage = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AmmoPercentage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumEnemies = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.DistanceToEnemy = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NumAllies = new System.Windows.Forms.NumericUpDown();
            this.DistanceToAlly = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EnemyFire = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GunAction = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.healthPercentage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmmoPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnemies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceToEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAllies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceToAlly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Percentage";
            // 
            // healthPercentage
            // 
            this.healthPercentage.Location = new System.Drawing.Point(243, 26);
            this.healthPercentage.Name = "healthPercentage";
            this.healthPercentage.Size = new System.Drawing.Size(59, 22);
            this.healthPercentage.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.EnemyFire);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DistanceToAlly);
            this.groupBox1.Controls.Add(this.NumAllies);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DistanceToEnemy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NumEnemies);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AmmoPercentage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.healthPercentage);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 467);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Stats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ammo Percentage";
            // 
            // AmmoPercentage
            // 
            this.AmmoPercentage.Location = new System.Drawing.Point(243, 52);
            this.AmmoPercentage.Name = "AmmoPercentage";
            this.AmmoPercentage.Size = new System.Drawing.Size(59, 22);
            this.AmmoPercentage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Nearby Enemies";
            // 
            // NumEnemies
            // 
            this.NumEnemies.Location = new System.Drawing.Point(243, 80);
            this.NumEnemies.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumEnemies.Name = "NumEnemies";
            this.NumEnemies.Size = new System.Drawing.Size(59, 22);
            this.NumEnemies.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Distance to Nearest Enemy in Feet";
            // 
            // DistanceToEnemy
            // 
            this.DistanceToEnemy.Location = new System.Drawing.Point(243, 109);
            this.DistanceToEnemy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DistanceToEnemy.Name = "DistanceToEnemy";
            this.DistanceToEnemy.Size = new System.Drawing.Size(59, 22);
            this.DistanceToEnemy.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of Nearby Allies";
            // 
            // NumAllies
            // 
            this.NumAllies.Location = new System.Drawing.Point(243, 138);
            this.NumAllies.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumAllies.Name = "NumAllies";
            this.NumAllies.Size = new System.Drawing.Size(59, 22);
            this.NumAllies.TabIndex = 9;
            // 
            // DistanceToAlly
            // 
            this.DistanceToAlly.Location = new System.Drawing.Point(243, 167);
            this.DistanceToAlly.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DistanceToAlly.Name = "DistanceToAlly";
            this.DistanceToAlly.Size = new System.Drawing.Size(59, 22);
            this.DistanceToAlly.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Distance to Nearest Ally in Feet";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(243, 196);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Distance to Nearest Cover in Feet";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.GunAction);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(368, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 467);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recommended Actions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Movement Recommendation:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(203, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Run Towards Enemy";
            // 
            // EnemyFire
            // 
            this.EnemyFire.AutoSize = true;
            this.EnemyFire.Location = new System.Drawing.Point(9, 228);
            this.EnemyFire.Name = "EnemyFire";
            this.EnemyFire.Size = new System.Drawing.Size(144, 21);
            this.EnemyFire.TabIndex = 15;
            this.EnemyFire.Text = "Under Enemy Fire";
            this.EnemyFire.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Gun Action Recommendation:";
            // 
            // GunAction
            // 
            this.GunAction.AutoSize = true;
            this.GunAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunAction.Location = new System.Drawing.Point(208, 54);
            this.GunAction.Name = "GunAction";
            this.GunAction.Size = new System.Drawing.Size(122, 17);
            this.GunAction.TabIndex = 3;
            this.GunAction.Text = "Shoot at Enemy";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(55, 416);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(227, 45);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Update Recommendations";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.healthPercentage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmmoPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnemies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceToEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAllies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceToAlly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown healthPercentage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox EnemyFire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown DistanceToAlly;
        private System.Windows.Forms.NumericUpDown NumAllies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DistanceToEnemy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumEnemies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AmmoPercentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label GunAction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button UpdateButton;
    }
}

