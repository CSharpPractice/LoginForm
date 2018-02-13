namespace LoginForm
{
    partial class MainFrmLogin
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
            this.txtBxUserID = new System.Windows.Forms.TextBox();
            this.txtBxPW = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserPW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxUserID
            // 
            this.txtBxUserID.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUserID.Location = new System.Drawing.Point(180, 35);
            this.txtBxUserID.Multiline = true;
            this.txtBxUserID.Name = "txtBxUserID";
            this.txtBxUserID.Size = new System.Drawing.Size(417, 59);
            this.txtBxUserID.TabIndex = 0;
            // 
            // txtBxPW
            // 
            this.txtBxPW.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPW.Location = new System.Drawing.Point(180, 127);
            this.txtBxPW.Name = "txtBxPW";
            this.txtBxPW.PasswordChar = '*';
            this.txtBxPW.Size = new System.Drawing.Size(417, 40);
            this.txtBxPW.TabIndex = 1;
            this.txtBxPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxPW_KeyDown);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Green;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogout.Location = new System.Drawing.Point(180, 206);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(168, 42);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log-out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(429, 206);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log-In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblUserID.Location = new System.Drawing.Point(36, 48);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(125, 34);
            this.lblUserID.TabIndex = 4;
            this.lblUserID.Text = "User ID";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserPW
            // 
            this.lblUserPW.AutoSize = true;
            this.lblUserPW.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPW.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblUserPW.Location = new System.Drawing.Point(27, 133);
            this.lblUserPW.Name = "lblUserPW";
            this.lblUserPW.Size = new System.Drawing.Size(147, 34);
            this.lblUserPW.TabIndex = 5;
            this.lblUserPW.Text = "Password";
            this.lblUserPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(728, 306);
            this.Controls.Add(this.lblUserPW);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtBxPW);
            this.Controls.Add(this.txtBxUserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainFrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxUserID;
        private System.Windows.Forms.TextBox txtBxPW;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserPW;
    }
}

