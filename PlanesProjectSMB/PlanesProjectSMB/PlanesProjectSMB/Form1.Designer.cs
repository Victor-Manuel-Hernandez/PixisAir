namespace PlanesProjectSMB
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
            this.btnMntLog = new System.Windows.Forms.Button();
            this.btnPlnNum = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMainFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(609, 290);
            this.listBox1.TabIndex = 0;
            // 
            // btnMntLog
            // 
            this.btnMntLog.Location = new System.Drawing.Point(641, 93);
            this.btnMntLog.Name = "btnMntLog";
            this.btnMntLog.Size = new System.Drawing.Size(147, 37);
            this.btnMntLog.TabIndex = 1;
            this.btnMntLog.Text = "Maintenance Logs";
            this.btnMntLog.UseVisualStyleBackColor = true;
            // 
            // btnPlnNum
            // 
            this.btnPlnNum.Location = new System.Drawing.Point(641, 174);
            this.btnPlnNum.Name = "btnPlnNum";
            this.btnPlnNum.Size = new System.Drawing.Size(147, 37);
            this.btnPlnNum.TabIndex = 2;
            this.btnPlnNum.Text = "Plane Number Maintenance Log";
            this.btnPlnNum.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(641, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Job Type";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnMainFrm
            // 
            this.btnMainFrm.Location = new System.Drawing.Point(641, 12);
            this.btnMainFrm.Name = "btnMainFrm";
            this.btnMainFrm.Size = new System.Drawing.Size(147, 37);
            this.btnMainFrm.TabIndex = 4;
            this.btnMainFrm.Text = "Main Form";
            this.btnMainFrm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainFrm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPlnNum);
            this.Controls.Add(this.btnMntLog);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMntLog;
        private System.Windows.Forms.Button btnPlnNum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMainFrm;
    }
}

