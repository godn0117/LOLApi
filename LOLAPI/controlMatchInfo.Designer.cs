namespace LOLAPI
{
    partial class controlMatchInfo
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlMatchInfo));
            this.dgvBlueTeam = new System.Windows.Forms.DataGridView();
            this.dgvRedTeam = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtObjectBlue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObjectRed = new System.Windows.Forms.TextBox();
            this.lblWin = new System.Windows.Forms.Label();
            this.txtGameTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlueTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRedTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBlueTeam
            // 
            this.dgvBlueTeam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvBlueTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlueTeam.Location = new System.Drawing.Point(4, 47);
            this.dgvBlueTeam.Name = "dgvBlueTeam";
            this.dgvBlueTeam.RowTemplate.Height = 23;
            this.dgvBlueTeam.Size = new System.Drawing.Size(805, 189);
            this.dgvBlueTeam.TabIndex = 0;
            // 
            // dgvRedTeam
            // 
            this.dgvRedTeam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvRedTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRedTeam.Location = new System.Drawing.Point(4, 296);
            this.dgvRedTeam.Name = "dgvRedTeam";
            this.dgvRedTeam.RowTemplate.Height = 23;
            this.dgvRedTeam.Size = new System.Drawing.Size(805, 192);
            this.dgvRedTeam.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(751, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 41);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtObjectBlue
            // 
            this.txtObjectBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtObjectBlue.Location = new System.Drawing.Point(4, 242);
            this.txtObjectBlue.Multiline = true;
            this.txtObjectBlue.Name = "txtObjectBlue";
            this.txtObjectBlue.Size = new System.Drawing.Size(314, 48);
            this.txtObjectBlue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "< 매치 상세 정보 >";
            // 
            // txtObjectRed
            // 
            this.txtObjectRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtObjectRed.Location = new System.Drawing.Point(495, 242);
            this.txtObjectRed.Multiline = true;
            this.txtObjectRed.Name = "txtObjectRed";
            this.txtObjectRed.Size = new System.Drawing.Size(314, 48);
            this.txtObjectRed.TabIndex = 7;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWin.ForeColor = System.Drawing.Color.White;
            this.lblWin.Location = new System.Drawing.Point(12, 9);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(0, 27);
            this.lblWin.TabIndex = 9;
            // 
            // txtGameTime
            // 
            this.txtGameTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGameTime.Location = new System.Drawing.Point(324, 242);
            this.txtGameTime.Multiline = true;
            this.txtGameTime.Name = "txtGameTime";
            this.txtGameTime.Size = new System.Drawing.Size(165, 48);
            this.txtGameTime.TabIndex = 10;
            // 
            // controlMatchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtGameTime);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.txtObjectRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObjectBlue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRedTeam);
            this.Controls.Add(this.dgvBlueTeam);
            this.DoubleBuffered = true;
            this.Name = "controlMatchInfo";
            this.Size = new System.Drawing.Size(812, 506);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlueTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRedTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvBlueTeam;
        public System.Windows.Forms.DataGridView dgvRedTeam;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtObjectBlue;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtObjectRed;
        public System.Windows.Forms.Label lblWin;
        public System.Windows.Forms.TextBox txtGameTime;
    }
}
