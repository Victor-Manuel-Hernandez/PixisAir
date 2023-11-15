namespace PixisAirVictor
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.taskBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.dspCustBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(775, 342);
            this.listBox1.TabIndex = 2;
            // 
            // taskBtn
            // 
            this.taskBtn.Location = new System.Drawing.Point(13, 415);
            this.taskBtn.Name = "taskBtn";
            this.taskBtn.Size = new System.Drawing.Size(75, 23);
            this.taskBtn.TabIndex = 3;
            this.taskBtn.Text = "Tasks";
            this.taskBtn.UseVisualStyleBackColor = true;
            this.taskBtn.Click += new System.EventHandler(this.taskBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(713, 36);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plane lookup";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(689, 20);
            this.textBox1.TabIndex = 0;
            // 
            // addCustBtn
            // 
            this.addCustBtn.Location = new System.Drawing.Point(95, 414);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(84, 23);
            this.addCustBtn.TabIndex = 4;
            this.addCustBtn.Text = "Add Customer";
            this.addCustBtn.UseVisualStyleBackColor = true;
            this.addCustBtn.Click += new System.EventHandler(this.addCustBtn_Click);
            // 
            // dspCustBtn
            // 
            this.dspCustBtn.Location = new System.Drawing.Point(186, 414);
            this.dspCustBtn.Name = "dspCustBtn";
            this.dspCustBtn.Size = new System.Drawing.Size(98, 23);
            this.dspCustBtn.TabIndex = 5;
            this.dspCustBtn.Text = "Customer Display";
            this.dspCustBtn.UseVisualStyleBackColor = true;
            this.dspCustBtn.Click += new System.EventHandler(this.dspCustBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dspCustBtn);
            this.Controls.Add(this.addCustBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.taskBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button taskBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.Button dspCustBtn;
    }
}

