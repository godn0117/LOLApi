﻿namespace LOLAPI
{
    partial class FrmSummoner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSummoner));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.Label();
            this.txtWinLose = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.Label();
            this.txtLeguePoints = new System.Windows.Forms.Label();
            this.txtLeagueName = new System.Windows.Forms.Label();
            this.txtTeamLeagueName = new System.Windows.Forms.Label();
            this.txtTeamLeaguePoints = new System.Windows.Forms.Label();
            this.txtTeamWinLose = new System.Windows.Forms.Label();
            this.txtTeamGrade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1080, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(612, 160);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(546, 497);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(422, 120);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtLeagueName);
            this.groupBox1.Controls.Add(this.txtLevel);
            this.groupBox1.Controls.Add(this.txtLeguePoints);
            this.groupBox1.Controls.Add(this.txtWinLose);
            this.groupBox1.Controls.Add(this.txtGrade);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(182, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 171);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "솔로 랭크";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.txtTeamLeagueName);
            this.groupBox2.Controls.Add(this.txtTeamGrade);
            this.groupBox2.Controls.Add(this.txtTeamWinLose);
            this.groupBox2.Controls.Add(this.txtTeamLeaguePoints);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(589, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 171);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "자유 랭크";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("한컴 쿨재즈 L", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(438, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 49);
            this.label1.TabIndex = 16;
            this.label1.Text = "소환사명";
            // 
            // txtLevel
            // 
            this.txtLevel.AutoSize = true;
            this.txtLevel.BackColor = System.Drawing.Color.Transparent;
            this.txtLevel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLevel.ForeColor = System.Drawing.Color.Snow;
            this.txtLevel.Location = new System.Drawing.Point(6, 36);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(55, 16);
            this.txtLevel.TabIndex = 17;
            this.txtLevel.Text = "label2";
            // 
            // txtWinLose
            // 
            this.txtWinLose.AutoSize = true;
            this.txtWinLose.BackColor = System.Drawing.Color.Transparent;
            this.txtWinLose.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWinLose.ForeColor = System.Drawing.Color.Snow;
            this.txtWinLose.Location = new System.Drawing.Point(177, 36);
            this.txtWinLose.Name = "txtWinLose";
            this.txtWinLose.Size = new System.Drawing.Size(55, 16);
            this.txtWinLose.TabIndex = 18;
            this.txtWinLose.Text = "label3";
            // 
            // txtGrade
            // 
            this.txtGrade.AutoSize = true;
            this.txtGrade.BackColor = System.Drawing.Color.Transparent;
            this.txtGrade.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGrade.ForeColor = System.Drawing.Color.Snow;
            this.txtGrade.Location = new System.Drawing.Point(6, 79);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(56, 16);
            this.txtGrade.TabIndex = 19;
            this.txtGrade.Text = "label4";
            // 
            // txtLeguePoints
            // 
            this.txtLeguePoints.AutoSize = true;
            this.txtLeguePoints.BackColor = System.Drawing.Color.Transparent;
            this.txtLeguePoints.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLeguePoints.ForeColor = System.Drawing.Color.Snow;
            this.txtLeguePoints.Location = new System.Drawing.Point(177, 79);
            this.txtLeguePoints.Name = "txtLeguePoints";
            this.txtLeguePoints.Size = new System.Drawing.Size(55, 16);
            this.txtLeguePoints.TabIndex = 20;
            this.txtLeguePoints.Text = "label5";
            // 
            // txtLeagueName
            // 
            this.txtLeagueName.AutoSize = true;
            this.txtLeagueName.BackColor = System.Drawing.Color.Transparent;
            this.txtLeagueName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLeagueName.ForeColor = System.Drawing.Color.Snow;
            this.txtLeagueName.Location = new System.Drawing.Point(6, 122);
            this.txtLeagueName.Name = "txtLeagueName";
            this.txtLeagueName.Size = new System.Drawing.Size(55, 16);
            this.txtLeagueName.TabIndex = 21;
            this.txtLeagueName.Text = "label6";
            // 
            // txtTeamLeagueName
            // 
            this.txtTeamLeagueName.AutoSize = true;
            this.txtTeamLeagueName.BackColor = System.Drawing.Color.Transparent;
            this.txtTeamLeagueName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTeamLeagueName.ForeColor = System.Drawing.Color.White;
            this.txtTeamLeagueName.Location = new System.Drawing.Point(30, 126);
            this.txtTeamLeagueName.Name = "txtTeamLeagueName";
            this.txtTeamLeagueName.Size = new System.Drawing.Size(55, 16);
            this.txtTeamLeagueName.TabIndex = 26;
            this.txtTeamLeagueName.Text = "label6";
            // 
            // txtTeamLeaguePoints
            // 
            this.txtTeamLeaguePoints.AutoSize = true;
            this.txtTeamLeaguePoints.BackColor = System.Drawing.Color.Transparent;
            this.txtTeamLeaguePoints.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTeamLeaguePoints.ForeColor = System.Drawing.Color.White;
            this.txtTeamLeaguePoints.Location = new System.Drawing.Point(201, 83);
            this.txtTeamLeaguePoints.Name = "txtTeamLeaguePoints";
            this.txtTeamLeaguePoints.Size = new System.Drawing.Size(55, 16);
            this.txtTeamLeaguePoints.TabIndex = 25;
            this.txtTeamLeaguePoints.Text = "label5";
            // 
            // txtTeamWinLose
            // 
            this.txtTeamWinLose.AutoSize = true;
            this.txtTeamWinLose.BackColor = System.Drawing.Color.Transparent;
            this.txtTeamWinLose.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTeamWinLose.ForeColor = System.Drawing.Color.White;
            this.txtTeamWinLose.Location = new System.Drawing.Point(30, 36);
            this.txtTeamWinLose.Name = "txtTeamWinLose";
            this.txtTeamWinLose.Size = new System.Drawing.Size(55, 16);
            this.txtTeamWinLose.TabIndex = 23;
            this.txtTeamWinLose.Text = "label3";
            // 
            // txtTeamGrade
            // 
            this.txtTeamGrade.AutoSize = true;
            this.txtTeamGrade.BackColor = System.Drawing.Color.Transparent;
            this.txtTeamGrade.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTeamGrade.ForeColor = System.Drawing.Color.White;
            this.txtTeamGrade.Location = new System.Drawing.Point(30, 83);
            this.txtTeamGrade.Name = "txtTeamGrade";
            this.txtTeamGrade.Size = new System.Drawing.Size(56, 16);
            this.txtTeamGrade.TabIndex = 24;
            this.txtTeamGrade.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 497);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 120);
            this.textBox1.TabIndex = 17;
            // 
            // FrmSummoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 656);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSummoner";
            this.Text = "FrmSummoner";
            this.Load += new System.EventHandler(this.FrmSummoner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtLeagueName;
        private System.Windows.Forms.Label txtLevel;
        private System.Windows.Forms.Label txtLeguePoints;
        private System.Windows.Forms.Label txtWinLose;
        private System.Windows.Forms.Label txtGrade;
        private System.Windows.Forms.Label txtTeamLeagueName;
        private System.Windows.Forms.Label txtTeamGrade;
        private System.Windows.Forms.Label txtTeamWinLose;
        private System.Windows.Forms.Label txtTeamLeaguePoints;
        private System.Windows.Forms.TextBox textBox1;
    }
}