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
            this.txtBlueTeam = new System.Windows.Forms.TextBox();
            this.txtRedTeam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlueTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRedTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBlueTeam
            // 
            this.dgvBlueTeam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvBlueTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlueTeam.Location = new System.Drawing.Point(4, 47);
            this.dgvBlueTeam.Name = "dgvBlueTeam";
            this.dgvBlueTeam.RowTemplate.Height = 23;
            this.dgvBlueTeam.Size = new System.Drawing.Size(649, 189);
            this.dgvBlueTeam.TabIndex = 0;
            // 
            // dgvRedTeam
            // 
            this.dgvRedTeam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvRedTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRedTeam.Location = new System.Drawing.Point(4, 296);
            this.dgvRedTeam.Name = "dgvRedTeam";
            this.dgvRedTeam.RowTemplate.Height = 23;
            this.dgvRedTeam.Size = new System.Drawing.Size(649, 192);
            this.dgvRedTeam.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(610, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtBlueTeam
            // 
            this.txtBlueTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBlueTeam.Location = new System.Drawing.Point(4, 242);
            this.txtBlueTeam.Name = "txtBlueTeam";
            this.txtBlueTeam.Size = new System.Drawing.Size(649, 21);
            this.txtBlueTeam.TabIndex = 4;
            // 
            // txtRedTeam
            // 
            this.txtRedTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtRedTeam.Location = new System.Drawing.Point(4, 269);
            this.txtRedTeam.Name = "txtRedTeam";
            this.txtRedTeam.Size = new System.Drawing.Size(649, 21);
            this.txtRedTeam.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(188, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "< 매치 상세 정보 >";
            // 
            // controlMatchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRedTeam);
            this.Controls.Add(this.txtBlueTeam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRedTeam);
            this.Controls.Add(this.dgvBlueTeam);
            this.DoubleBuffered = true;
            this.Name = "controlMatchInfo";
            this.Size = new System.Drawing.Size(658, 496);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlueTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRedTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBlueTeam;
        private System.Windows.Forms.DataGridView dgvRedTeam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBlueTeam;
        private System.Windows.Forms.TextBox txtRedTeam;
        private System.Windows.Forms.Label label1;
    }
}
