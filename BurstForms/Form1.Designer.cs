namespace BurstForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkUseLgsProfile = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pboxColor2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numAoE = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numFadeSpd = new System.Windows.Forms.NumericUpDown();
            this.chkRandomColor = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pboxColor1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numGradSpd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numAnimDelay = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numRippleInterval = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numWaitTime = new System.Windows.Forms.NumericUpDown();
            this.chkUseKeySaver = new System.Windows.Forms.CheckBox();
            this.lstProfiles = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chkBreathing = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAoE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFadeSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGradSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimDelay)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRippleInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkUseLgsProfile
            // 
            this.chkUseLgsProfile.AutoSize = true;
            this.chkUseLgsProfile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseLgsProfile.Location = new System.Drawing.Point(12, 12);
            this.chkUseLgsProfile.Name = "chkUseLgsProfile";
            this.chkUseLgsProfile.Size = new System.Drawing.Size(184, 17);
            this.chkUseLgsProfile.TabIndex = 0;
            this.chkUseLgsProfile.Text = "Use LGS profile as background";
            this.chkUseLgsProfile.UseVisualStyleBackColor = true;
            this.chkUseLgsProfile.CheckedChanged += new System.EventHandler(this.chkUseLgsProfile_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pboxColor2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numAoE);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numFadeSpd);
            this.groupBox1.Controls.Add(this.chkRandomColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pboxColor1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numGradSpd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numAnimDelay);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ripple Settings (for RGB per-key keyboards)";
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(330, 12);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(169, 23);
            this.btnSaveProfile.TabIndex = 14;
            this.btnSaveProfile.Text = "Save profile";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Color 2";
            // 
            // pboxColor2
            // 
            this.pboxColor2.Location = new System.Drawing.Point(243, 34);
            this.pboxColor2.Name = "pboxColor2";
            this.pboxColor2.Size = new System.Drawing.Size(41, 37);
            this.pboxColor2.TabIndex = 12;
            this.pboxColor2.TabStop = false;
            this.pboxColor2.Click += new System.EventHandler(this.pboxColor2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Area of Effect:";
            // 
            // numAoE
            // 
            this.numAoE.DecimalPlaces = 1;
            this.numAoE.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAoE.Location = new System.Drawing.Point(104, 105);
            this.numAoE.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAoE.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAoE.Name = "numAoE";
            this.numAoE.Size = new System.Drawing.Size(62, 22);
            this.numAoE.TabIndex = 10;
            this.numAoE.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fade Speed:";
            // 
            // numFadeSpd
            // 
            this.numFadeSpd.Location = new System.Drawing.Point(104, 77);
            this.numFadeSpd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFadeSpd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFadeSpd.Name = "numFadeSpd";
            this.numFadeSpd.Size = new System.Drawing.Size(62, 22);
            this.numFadeSpd.TabIndex = 8;
            this.numFadeSpd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkRandomColor
            // 
            this.chkRandomColor.AutoSize = true;
            this.chkRandomColor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRandomColor.Location = new System.Drawing.Point(186, 77);
            this.chkRandomColor.Name = "chkRandomColor";
            this.chkRandomColor.Size = new System.Drawing.Size(98, 17);
            this.chkRandomColor.TabIndex = 5;
            this.chkRandomColor.Text = "Random color";
            this.chkRandomColor.UseVisualStyleBackColor = true;
            this.chkRandomColor.CheckedChanged += new System.EventHandler(this.chkRandomColor_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color 1";
            // 
            // pboxColor1
            // 
            this.pboxColor1.Location = new System.Drawing.Point(186, 34);
            this.pboxColor1.Name = "pboxColor1";
            this.pboxColor1.Size = new System.Drawing.Size(41, 37);
            this.pboxColor1.TabIndex = 4;
            this.pboxColor1.TabStop = false;
            this.pboxColor1.Click += new System.EventHandler(this.pboxColor1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gradient Speed:";
            // 
            // numGradSpd
            // 
            this.numGradSpd.Location = new System.Drawing.Point(104, 49);
            this.numGradSpd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGradSpd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGradSpd.Name = "numGradSpd";
            this.numGradSpd.Size = new System.Drawing.Size(62, 22);
            this.numGradSpd.TabIndex = 2;
            this.numGradSpd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animation Delay:";
            // 
            // numAnimDelay
            // 
            this.numAnimDelay.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numAnimDelay.Location = new System.Drawing.Point(104, 21);
            this.numAnimDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAnimDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAnimDelay.Name = "numAnimDelay";
            this.numAnimDelay.Size = new System.Drawing.Size(62, 22);
            this.numAnimDelay.TabIndex = 0;
            this.numAnimDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBreathing);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.numRippleInterval);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numWaitTime);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 87);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KeySaver Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "milliseconds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ripple interval:";
            // 
            // numRippleInterval
            // 
            this.numRippleInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRippleInterval.Location = new System.Drawing.Point(154, 39);
            this.numRippleInterval.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numRippleInterval.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numRippleInterval.Name = "numRippleInterval";
            this.numRippleInterval.Size = new System.Drawing.Size(62, 22);
            this.numRippleInterval.TabIndex = 17;
            this.numRippleInterval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numRippleInterval.ValueChanged += new System.EventHandler(this.numRippleInterval_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "seconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Wait time:";
            // 
            // numWaitTime
            // 
            this.numWaitTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numWaitTime.Location = new System.Drawing.Point(9, 39);
            this.numWaitTime.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numWaitTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWaitTime.Name = "numWaitTime";
            this.numWaitTime.Size = new System.Drawing.Size(62, 22);
            this.numWaitTime.TabIndex = 14;
            this.numWaitTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWaitTime.ValueChanged += new System.EventHandler(this.numWaitTime_ValueChanged);
            // 
            // chkUseKeySaver
            // 
            this.chkUseKeySaver.AutoSize = true;
            this.chkUseKeySaver.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseKeySaver.Location = new System.Drawing.Point(12, 178);
            this.chkUseKeySaver.Name = "chkUseKeySaver";
            this.chkUseKeySaver.Size = new System.Drawing.Size(312, 17);
            this.chkUseKeySaver.TabIndex = 5;
            this.chkUseKeySaver.Text = "Use KeySaver (like a screen saver, but for your keyboard)";
            this.chkUseKeySaver.UseVisualStyleBackColor = true;
            this.chkUseKeySaver.CheckedChanged += new System.EventHandler(this.chkUseKeySaver_CheckedChanged);
            // 
            // lstProfiles
            // 
            this.lstProfiles.BackColor = System.Drawing.SystemColors.Menu;
            this.lstProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProfiles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProfiles.FormattingEnabled = true;
            this.lstProfiles.Location = new System.Drawing.Point(6, 21);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(157, 221);
            this.lstProfiles.TabIndex = 2;
            this.lstProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstProfiles_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstProfiles);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(330, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 247);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profiles List";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Burst for Logitech";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // chkBreathing
            // 
            this.chkBreathing.AutoSize = true;
            this.chkBreathing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBreathing.Location = new System.Drawing.Point(9, 67);
            this.chkBreathing.Name = "chkBreathing";
            this.chkBreathing.Size = new System.Drawing.Size(109, 17);
            this.chkBreathing.TabIndex = 6;
            this.chkBreathing.Text = "Breathing effect";
            this.chkBreathing.UseVisualStyleBackColor = true;
            this.chkBreathing.CheckedChanged += new System.EventHandler(this.chkBreathing_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 300);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.chkUseKeySaver);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkUseLgsProfile);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Burst for Logitech";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAoE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFadeSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGradSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimDelay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRippleInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUseLgsProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAoE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numFadeSpd;
        private System.Windows.Forms.CheckBox chkRandomColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboxColor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numGradSpd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAnimDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pboxColor2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numRippleInterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numWaitTime;
        private System.Windows.Forms.CheckBox chkUseKeySaver;
        private System.Windows.Forms.ListBox lstProfiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.CheckBox chkBreathing;
    }
}

