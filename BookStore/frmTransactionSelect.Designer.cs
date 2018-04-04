namespace BookStore
{
    partial class frmTransactionSelect
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
            this.lblEnterISBN = new System.Windows.Forms.Label();
            this.txtRightISBN = new System.Windows.Forms.TextBox();
            this.txtLeftISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkISBN = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.lblEnterBookData = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblReadISBN = new System.Windows.Forms.Label();
            this.txtReadRightISBN = new System.Windows.Forms.TextBox();
            this.txtReadLeftISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblLastDateAccessed = new System.Windows.Forms.Label();
            this.txtLastDateAccessed = new System.Windows.Forms.TextBox();
            this.btnAddDone = new System.Windows.Forms.Button();
            this.btnUpdateDone = new System.Windows.Forms.Button();
            this.btnDeleteDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterISBN
            // 
            this.lblEnterISBN.AutoSize = true;
            this.lblEnterISBN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterISBN.Location = new System.Drawing.Point(93, 39);
            this.lblEnterISBN.Name = "lblEnterISBN";
            this.lblEnterISBN.Size = new System.Drawing.Size(122, 26);
            this.lblEnterISBN.TabIndex = 0;
            this.lblEnterISBN.Text = "Enter ISBN:";
            // 
            // txtRightISBN
            // 
            this.txtRightISBN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightISBN.Location = new System.Drawing.Point(354, 36);
            this.txtRightISBN.MaxLength = 3;
            this.txtRightISBN.Name = "txtRightISBN";
            this.txtRightISBN.Size = new System.Drawing.Size(100, 34);
            this.txtRightISBN.TabIndex = 2;
            this.txtRightISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLeftISBN
            // 
            this.txtLeftISBN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftISBN.Location = new System.Drawing.Point(221, 36);
            this.txtLeftISBN.MaxLength = 3;
            this.txtLeftISBN.Name = "txtLeftISBN";
            this.txtLeftISBN.Size = new System.Drawing.Size(100, 34);
            this.txtLeftISBN.TabIndex = 1;
            this.txtLeftISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // btnOkISBN
            // 
            this.btnOkISBN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkISBN.Location = new System.Drawing.Point(495, 33);
            this.btnOkISBN.Name = "btnOkISBN";
            this.btnOkISBN.Size = new System.Drawing.Size(75, 39);
            this.btnOkISBN.TabIndex = 3;
            this.btnOkISBN.Text = "OK";
            this.btnOkISBN.UseVisualStyleBackColor = true;
            this.btnOkISBN.Click += new System.EventHandler(this.btnOkISBN_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(193, 96);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(289, 36);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add new book to inventory";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Location = new System.Drawing.Point(193, 179);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(289, 37);
            this.btnDeleteBook.TabIndex = 6;
            this.btnDeleteBook.Text = "Delete a book from inventory";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.Location = new System.Drawing.Point(193, 138);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(289, 35);
            this.btnUpdateBook.TabIndex = 7;
            this.btnUpdateBook.Text = "Update a book in inventory";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // lblEnterBookData
            // 
            this.lblEnterBookData.AutoSize = true;
            this.lblEnterBookData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnterBookData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterBookData.Location = new System.Drawing.Point(40, 256);
            this.lblEnterBookData.Name = "lblEnterBookData";
            this.lblEnterBookData.Size = new System.Drawing.Size(167, 26);
            this.lblEnterBookData.TabIndex = 8;
            this.lblEnterBookData.Text = "Enter Book Data:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(438, 361);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(107, 28);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(476, 314);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 28);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(31, 410);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 27);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(9, 362);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(83, 27);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "Author:";
            // 
            // lblReadISBN
            // 
            this.lblReadISBN.AutoSize = true;
            this.lblReadISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReadISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadISBN.Location = new System.Drawing.Point(24, 312);
            this.lblReadISBN.Name = "lblReadISBN";
            this.lblReadISBN.Size = new System.Drawing.Size(68, 27);
            this.lblReadISBN.TabIndex = 13;
            this.lblReadISBN.Text = "ISBN:";
            // 
            // txtReadRightISBN
            // 
            this.txtReadRightISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadRightISBN.Location = new System.Drawing.Point(213, 312);
            this.txtReadRightISBN.Name = "txtReadRightISBN";
            this.txtReadRightISBN.ReadOnly = true;
            this.txtReadRightISBN.Size = new System.Drawing.Size(59, 31);
            this.txtReadRightISBN.TabIndex = 14;
            // 
            // txtReadLeftISBN
            // 
            this.txtReadLeftISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadLeftISBN.Location = new System.Drawing.Point(123, 312);
            this.txtReadLeftISBN.Name = "txtReadLeftISBN";
            this.txtReadLeftISBN.ReadOnly = true;
            this.txtReadLeftISBN.Size = new System.Drawing.Size(59, 31);
            this.txtReadLeftISBN.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "-";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(98, 362);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(223, 31);
            this.txtAuthor.TabIndex = 17;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(98, 406);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(223, 31);
            this.txtTitle.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(551, 312);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 31);
            this.txtPrice.TabIndex = 19;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(551, 359);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 31);
            this.txtQuantity.TabIndex = 20;
            // 
            // lblLastDateAccessed
            // 
            this.lblLastDateAccessed.AutoSize = true;
            this.lblLastDateAccessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastDateAccessed.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastDateAccessed.Location = new System.Drawing.Point(332, 408);
            this.lblLastDateAccessed.Name = "lblLastDateAccessed";
            this.lblLastDateAccessed.Size = new System.Drawing.Size(213, 28);
            this.lblLastDateAccessed.TabIndex = 21;
            this.lblLastDateAccessed.Text = "Last Date Accessed:";
            // 
            // txtLastDateAccessed
            // 
            this.txtLastDateAccessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastDateAccessed.Location = new System.Drawing.Point(551, 406);
            this.txtLastDateAccessed.Name = "txtLastDateAccessed";
            this.txtLastDateAccessed.Size = new System.Drawing.Size(100, 31);
            this.txtLastDateAccessed.TabIndex = 22;
            // 
            // btnAddDone
            // 
            this.btnAddDone.Enabled = false;
            this.btnAddDone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDone.Location = new System.Drawing.Point(140, 467);
            this.btnAddDone.Name = "btnAddDone";
            this.btnAddDone.Size = new System.Drawing.Size(122, 39);
            this.btnAddDone.TabIndex = 25;
            this.btnAddDone.Text = "Add";
            this.btnAddDone.UseVisualStyleBackColor = true;
            this.btnAddDone.Visible = false;
            this.btnAddDone.Click += new System.EventHandler(this.btnAddDone_Click);
            // 
            // btnUpdateDone
            // 
            this.btnUpdateDone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDone.Location = new System.Drawing.Point(248, 467);
            this.btnUpdateDone.Name = "btnUpdateDone";
            this.btnUpdateDone.Size = new System.Drawing.Size(122, 39);
            this.btnUpdateDone.TabIndex = 26;
            this.btnUpdateDone.Text = "Update";
            this.btnUpdateDone.UseVisualStyleBackColor = true;
            this.btnUpdateDone.Click += new System.EventHandler(this.btnUpdateDone_Click);
            // 
            // btnDeleteDone
            // 
            this.btnDeleteDone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDone.Location = new System.Drawing.Point(345, 467);
            this.btnDeleteDone.Name = "btnDeleteDone";
            this.btnDeleteDone.Size = new System.Drawing.Size(122, 39);
            this.btnDeleteDone.TabIndex = 27;
            this.btnDeleteDone.Text = "Delete";
            this.btnDeleteDone.UseVisualStyleBackColor = true;
            this.btnDeleteDone.Visible = false;
            this.btnDeleteDone.Click += new System.EventHandler(this.btnDeleteDone_Click);
            // 
            // frmTransactionSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 528);
            this.Controls.Add(this.btnDeleteDone);
            this.Controls.Add(this.btnUpdateDone);
            this.Controls.Add(this.btnAddDone);
            this.Controls.Add(this.txtLastDateAccessed);
            this.Controls.Add(this.lblLastDateAccessed);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReadLeftISBN);
            this.Controls.Add(this.txtReadRightISBN);
            this.Controls.Add(this.lblReadISBN);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblEnterBookData);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnOkISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeftISBN);
            this.Controls.Add(this.txtRightISBN);
            this.Controls.Add(this.lblEnterISBN);
            this.Name = "frmTransactionSelect";
            this.Text = "frmTransactionSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterISBN;
        private System.Windows.Forms.TextBox txtRightISBN;
        private System.Windows.Forms.TextBox txtLeftISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOkISBN;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label lblEnterBookData;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblReadISBN;
        private System.Windows.Forms.TextBox txtReadRightISBN;
        private System.Windows.Forms.TextBox txtReadLeftISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblLastDateAccessed;
        private System.Windows.Forms.TextBox txtLastDateAccessed;
        private System.Windows.Forms.Button btnAddDone;
        private System.Windows.Forms.Button btnUpdateDone;
        private System.Windows.Forms.Button btnDeleteDone;
    }
}