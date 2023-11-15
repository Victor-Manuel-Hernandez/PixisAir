namespace PixisAirProject
{
    partial class RonaldForm
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
            this.jobButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.jobListBox = new System.Windows.Forms.ListBox();
            this.workorderButton = new System.Windows.Forms.Button();
            this.tasksButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jobButton
            // 
            this.jobButton.Location = new System.Drawing.Point(661, 74);
            this.jobButton.Name = "jobButton";
            this.jobButton.Size = new System.Drawing.Size(127, 53);
            this.jobButton.TabIndex = 1;
            this.jobButton.Text = "Show All Jobs";
            this.jobButton.UseVisualStyleBackColor = true;
            this.jobButton.Click += new System.EventHandler(this.jobButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(661, 15);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(127, 53);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "menuButton";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // jobListBox
            // 
            this.jobListBox.FormattingEnabled = true;
            this.jobListBox.Location = new System.Drawing.Point(12, 15);
            this.jobListBox.Name = "jobListBox";
            this.jobListBox.Size = new System.Drawing.Size(631, 238);
            this.jobListBox.TabIndex = 4;
            // 
            // workorderButton
            // 
            this.workorderButton.Location = new System.Drawing.Point(661, 133);
            this.workorderButton.Name = "workorderButton";
            this.workorderButton.Size = new System.Drawing.Size(127, 53);
            this.workorderButton.TabIndex = 2;
            this.workorderButton.Text = "Enter WorkSpace";
            this.workorderButton.UseVisualStyleBackColor = true;
            this.workorderButton.Click += new System.EventHandler(this.workorderButton_Click);
            // 
            // tasksButton
            // 
            this.tasksButton.Location = new System.Drawing.Point(661, 192);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(127, 53);
            this.tasksButton.TabIndex = 3;
            this.tasksButton.Text = "Add a Task";
            this.tasksButton.UseVisualStyleBackColor = true;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(435, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 12;
            // 
            // RonaldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tasksButton);
            this.Controls.Add(this.workorderButton);
            this.Controls.Add(this.jobListBox);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.jobButton);
            this.Name = "RonaldForm";
            this.Text = "RonaldForm";
            this.Load += new System.EventHandler(this.RonaldForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jobButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.ListBox jobListBox;
        private System.Windows.Forms.Button workorderButton;
        private System.Windows.Forms.Button tasksButton;
        private System.Windows.Forms.Label label4;
    }
}

