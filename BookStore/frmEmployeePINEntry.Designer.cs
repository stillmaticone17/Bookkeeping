namespace BookStore
{
    partial class frmEmployeePINEntry
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
            this.lblGreetingPINEntry = new System.Windows.Forms.Label();
            this.lblEmpNumPIN = new System.Windows.Forms.Label();
            this.lblEnterPIN = new System.Windows.Forms.Label();
            this.txtEmpNumPIN = new System.Windows.Forms.TextBox();
            this.txtEnterPIN = new System.Windows.Forms.TextBox();
            this.btnPINLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGreetingPINEntry
            // 
            this.lblGreetingPINEntry.AutoSize = true;
            this.lblGreetingPINEntry.BackColor = System.Drawing.SystemColors.Control;
            this.lblGreetingPINEntry.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetingPINEntry.ForeColor = System.Drawing.Color.Maroon;
            this.lblGreetingPINEntry.Location = new System.Drawing.Point(67, 32);
            this.lblGreetingPINEntry.Name = "lblGreetingPINEntry";
            this.lblGreetingPINEntry.Size = new System.Drawing.Size(448, 57);
            this.lblGreetingPINEntry.TabIndex = 1;
            this.lblGreetingPINEntry.Text = "Brendan\'s Bookstore";
            // 
            // lblEmpNumPIN
            // 
            this.lblEmpNumPIN.AutoSize = true;
            this.lblEmpNumPIN.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpNumPIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpNumPIN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNumPIN.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmpNumPIN.Location = new System.Drawing.Point(12, 156);
            this.lblEmpNumPIN.Name = "lblEmpNumPIN";
            this.lblEmpNumPIN.Size = new System.Drawing.Size(258, 28);
            this.lblEmpNumPIN.TabIndex = 2;
            this.lblEmpNumPIN.Text = "Hello Employee Number:";
            // 
            // lblEnterPIN
            // 
            this.lblEnterPIN.AutoSize = true;
            this.lblEnterPIN.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnterPIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnterPIN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPIN.ForeColor = System.Drawing.Color.Maroon;
            this.lblEnterPIN.Location = new System.Drawing.Point(38, 222);
            this.lblEnterPIN.Name = "lblEnterPIN";
            this.lblEnterPIN.Size = new System.Drawing.Size(232, 28);
            this.lblEnterPIN.TabIndex = 3;
            this.lblEnterPIN.Text = "Please Enter Your PIN:";
            // 
            // txtEmpNumPIN
            // 
            this.txtEmpNumPIN.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmpNumPIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpNumPIN.CausesValidation = false;
            this.txtEmpNumPIN.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEmpNumPIN.Enabled = false;
            this.txtEmpNumPIN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNumPIN.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEmpNumPIN.Location = new System.Drawing.Point(308, 153);
            this.txtEmpNumPIN.MaxLength = 5;
            this.txtEmpNumPIN.Name = "txtEmpNumPIN";
            this.txtEmpNumPIN.ReadOnly = true;
            this.txtEmpNumPIN.Size = new System.Drawing.Size(100, 27);
            this.txtEmpNumPIN.TabIndex = 4;
            this.txtEmpNumPIN.TabStop = false;
            // 
            // txtEnterPIN
            // 
            this.txtEnterPIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEnterPIN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterPIN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEnterPIN.Location = new System.Drawing.Point(308, 219);
            this.txtEnterPIN.MaxLength = 4;
            this.txtEnterPIN.Name = "txtEnterPIN";
            this.txtEnterPIN.Size = new System.Drawing.Size(100, 34);
            this.txtEnterPIN.TabIndex = 5;
            // 
            // btnPINLogin
            // 
            this.btnPINLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPINLogin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPINLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPINLogin.Location = new System.Drawing.Point(453, 215);
            this.btnPINLogin.Name = "btnPINLogin";
            this.btnPINLogin.Size = new System.Drawing.Size(81, 41);
            this.btnPINLogin.TabIndex = 6;
            this.btnPINLogin.Text = "Login";
            this.btnPINLogin.UseVisualStyleBackColor = false;
            this.btnPINLogin.Click += new System.EventHandler(this.btnPINOK_Click);
            // 
            // frmEmployeePINEntry
            // 
            this.AcceptButton = this.btnPINLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 417);
            this.Controls.Add(this.btnPINLogin);
            this.Controls.Add(this.txtEnterPIN);
            this.Controls.Add(this.txtEmpNumPIN);
            this.Controls.Add(this.lblEnterPIN);
            this.Controls.Add(this.lblEmpNumPIN);
            this.Controls.Add(this.lblGreetingPINEntry);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "frmEmployeePINEntry";
            this.Text = "frmEmployeePINEntry";
            this.Load += new System.EventHandler(this.frmEmployeePINEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGreetingPINEntry;
        private System.Windows.Forms.Label lblEmpNumPIN;
        private System.Windows.Forms.Label lblEnterPIN;
        private System.Windows.Forms.TextBox txtEmpNumPIN;
        private System.Windows.Forms.TextBox txtEnterPIN;
        private System.Windows.Forms.Button btnPINLogin;
    }
}