namespace BookStore
{
    partial class frmEmployeeAccessIDEntry
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
            this.lblAccessID = new System.Windows.Forms.Label();
            this.txtBookStore = new System.Windows.Forms.TextBox();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.btnAccessIDOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccessID
            // 
            this.lblAccessID.AutoSize = true;
            this.lblAccessID.BackColor = System.Drawing.SystemColors.Control;
            this.lblAccessID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessID.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccessID.Location = new System.Drawing.Point(194, 154);
            this.lblAccessID.Margin = new System.Windows.Forms.Padding(3);
            this.lblAccessID.Name = "lblAccessID";
            this.lblAccessID.Size = new System.Drawing.Size(384, 24);
            this.lblAccessID.TabIndex = 2;
            this.lblAccessID.Text = "Please enter your 5-digit AccessID below\r\n";
            // 
            // txtBookStore
            // 
            this.txtBookStore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBookStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookStore.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookStore.ForeColor = System.Drawing.Color.Maroon;
            this.txtBookStore.Location = new System.Drawing.Point(40, 31);
            this.txtBookStore.Name = "txtBookStore";
            this.txtBookStore.Size = new System.Drawing.Size(734, 59);
            this.txtBookStore.TabIndex = 1;
            this.txtBookStore.Text = "Welcome to Brendan\'s Bookstore";
            this.txtBookStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAccessID
            // 
            this.txtAccessID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccessID.Location = new System.Drawing.Point(324, 203);
            this.txtAccessID.MaxLength = 5;
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.Size = new System.Drawing.Size(138, 32);
            this.txtAccessID.TabIndex = 0;
            // 
            // btnAccessIDOK
            // 
            this.btnAccessIDOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessIDOK.Location = new System.Drawing.Point(344, 269);
            this.btnAccessIDOK.Name = "btnAccessIDOK";
            this.btnAccessIDOK.Size = new System.Drawing.Size(104, 55);
            this.btnAccessIDOK.TabIndex = 4;
            this.btnAccessIDOK.Text = "OK";
            this.btnAccessIDOK.UseVisualStyleBackColor = true;
            this.btnAccessIDOK.Click += new System.EventHandler(this.btnAccessIDOK_Click);
            // 
            // frmEmployeeAccessIDEntry
            // 
            this.AcceptButton = this.btnAccessIDOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 364);
            this.Controls.Add(this.btnAccessIDOK);
            this.Controls.Add(this.txtAccessID);
            this.Controls.Add(this.lblAccessID);
            this.Controls.Add(this.txtBookStore);
            this.Name = "frmEmployeeAccessIDEntry";
            this.Text = "frmAccessID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBookStore;
        private System.Windows.Forms.TextBox txtAccessID;
        private System.Windows.Forms.Button btnAccessIDOK;
        private System.Windows.Forms.Label lblAccessID;
    }
}



