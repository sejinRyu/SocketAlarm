namespace SocketAlarm
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.AutoSize = true;
            this.ConnectButton.BackColor = System.Drawing.Color.White;
            this.ConnectButton.BackgroundImage = global::SocketAlarm.Properties.Resources.i16573634681;
            this.ConnectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ConnectButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConnectButton.ForeColor = System.Drawing.Color.Silver;
            this.ConnectButton.Location = new System.Drawing.Point(456, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(71, 71);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MessageLabel.Location = new System.Drawing.Point(13, 43);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(56, 40);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.Text = "...";
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.BackColor = System.Drawing.Color.White;
            this.StartButton.BackgroundImage = global::SocketAlarm.Properties.Resources.i16573634681;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartButton.ForeColor = System.Drawing.Color.Silver;
            this.StartButton.Location = new System.Drawing.Point(369, 397);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(71, 71);
            this.StartButton.TabIndex = 4;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.AutoSize = true;
            this.StopButton.BackColor = System.Drawing.Color.White;
            this.StopButton.BackgroundImage = global::SocketAlarm.Properties.Resources.i16573634681;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StopButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopButton.ForeColor = System.Drawing.Color.Silver;
            this.StopButton.Location = new System.Drawing.Point(446, 397);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(71, 71);
            this.StopButton.TabIndex = 5;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop";
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = true;
            this.RefreshButton.BackColor = System.Drawing.Color.White;
            this.RefreshButton.BackgroundImage = global::SocketAlarm.Properties.Resources.i16573634681;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RefreshButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RefreshButton.ForeColor = System.Drawing.Color.Silver;
            this.RefreshButton.Location = new System.Drawing.Point(369, 13);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(71, 71);
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Visible = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Refresh";
            this.label5.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 480);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.77D;
            this.Text = "SocketAlarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label5;
    }
}

