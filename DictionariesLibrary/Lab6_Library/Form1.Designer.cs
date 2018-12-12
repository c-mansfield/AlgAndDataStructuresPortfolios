namespace Lab6_Library
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.txt_Isbn = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.lbl_Isbn = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Outputs = new System.Windows.Forms.Label();
            this.onloan_Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(230, 38);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(326, 38);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 1;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.Location = new System.Drawing.Point(73, 20);
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Size = new System.Drawing.Size(127, 20);
            this.txt_Isbn.TabIndex = 2;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(73, 64);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(127, 20);
            this.txt_Title.TabIndex = 3;
            // 
            // lbl_Isbn
            // 
            this.lbl_Isbn.AutoSize = true;
            this.lbl_Isbn.Location = new System.Drawing.Point(32, 23);
            this.lbl_Isbn.Name = "lbl_Isbn";
            this.lbl_Isbn.Size = new System.Drawing.Size(35, 13);
            this.lbl_Isbn.TabIndex = 4;
            this.lbl_Isbn.Text = "ISBN:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(32, 67);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "Title:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 160);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(22, 293);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(138, 20);
            this.txt_Search.TabIndex = 7;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(179, 291);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Outputs
            // 
            this.lbl_Outputs.AutoSize = true;
            this.lbl_Outputs.Location = new System.Drawing.Point(306, 136);
            this.lbl_Outputs.Name = "lbl_Outputs";
            this.lbl_Outputs.Size = new System.Drawing.Size(74, 13);
            this.lbl_Outputs.TabIndex = 9;
            this.lbl_Outputs.Text = "Show Outputs";
            // 
            // onloan_Change
            // 
            this.onloan_Change.Location = new System.Drawing.Point(269, 290);
            this.onloan_Change.Name = "onloan_Change";
            this.onloan_Change.Size = new System.Drawing.Size(132, 23);
            this.onloan_Change.TabIndex = 10;
            this.onloan_Change.Text = "Change Loan Status";
            this.onloan_Change.UseVisualStyleBackColor = true;
            this.onloan_Change.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 347);
            this.Controls.Add(this.onloan_Change);
            this.Controls.Add(this.lbl_Outputs);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Isbn);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.txt_Isbn);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.TextBox txt_Isbn;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label lbl_Isbn;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Outputs;
        private System.Windows.Forms.Button onloan_Change;
    }
}

