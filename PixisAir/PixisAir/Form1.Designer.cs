namespace PixisAir
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
            this.HeadingLbl = new System.Windows.Forms.Label();
            this.kyleBtn = new System.Windows.Forms.Button();
            this.ronaldBtn = new System.Windows.Forms.Button();
            this.victorBtn = new System.Windows.Forms.Button();
            this.santosBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeadingLbl
            // 
            this.HeadingLbl.AutoSize = true;
            this.HeadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLbl.Location = new System.Drawing.Point(62, 23);
            this.HeadingLbl.Name = "HeadingLbl";
            this.HeadingLbl.Size = new System.Drawing.Size(197, 73);
            this.HeadingLbl.TabIndex = 0;
            this.HeadingLbl.Text = "Menu";
            // 
            // kyleBtn
            // 
            this.kyleBtn.Location = new System.Drawing.Point(99, 116);
            this.kyleBtn.Name = "kyleBtn";
            this.kyleBtn.Size = new System.Drawing.Size(86, 32);
            this.kyleBtn.TabIndex = 1;
            this.kyleBtn.Text = "Kyle";
            this.kyleBtn.UseVisualStyleBackColor = true;
            this.kyleBtn.Click += new System.EventHandler(this.kyleBtn_Click);
            // 
            // ronaldBtn
            // 
            this.ronaldBtn.Location = new System.Drawing.Point(99, 154);
            this.ronaldBtn.Name = "ronaldBtn";
            this.ronaldBtn.Size = new System.Drawing.Size(86, 32);
            this.ronaldBtn.TabIndex = 1;
            this.ronaldBtn.Text = "Ronald";
            this.ronaldBtn.UseVisualStyleBackColor = true;
            // 
            // victorBtn
            // 
            this.victorBtn.Location = new System.Drawing.Point(99, 230);
            this.victorBtn.Name = "victorBtn";
            this.victorBtn.Size = new System.Drawing.Size(86, 32);
            this.victorBtn.TabIndex = 1;
            this.victorBtn.Text = "Victor";
            this.victorBtn.UseVisualStyleBackColor = true;
            // 
            // santosBtn
            // 
            this.santosBtn.Location = new System.Drawing.Point(99, 192);
            this.santosBtn.Name = "santosBtn";
            this.santosBtn.Size = new System.Drawing.Size(86, 32);
            this.santosBtn.TabIndex = 1;
            this.santosBtn.Text = "Santos";
            this.santosBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 300);
            this.Controls.Add(this.santosBtn);
            this.Controls.Add(this.victorBtn);
            this.Controls.Add(this.ronaldBtn);
            this.Controls.Add(this.kyleBtn);
            this.Controls.Add(this.HeadingLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLbl;
        private System.Windows.Forms.Button kyleBtn;
        private System.Windows.Forms.Button ronaldBtn;
        private System.Windows.Forms.Button victorBtn;
        private System.Windows.Forms.Button santosBtn;
    }
}

