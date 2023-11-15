namespace PixisAirProject
{
    partial class AddTask
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
            this.taskLabel = new System.Windows.Forms.Label();
            this.taskHoursInput = new System.Windows.Forms.TextBox();
            this.taskDescInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskIDInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tasksButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.taskLabel.Location = new System.Drawing.Point(55, 93);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(141, 24);
            this.taskLabel.TabIndex = 12;
            this.taskLabel.Text = "ENTER TASKS";
            // 
            // taskHoursInput
            // 
            this.taskHoursInput.Location = new System.Drawing.Point(133, 188);
            this.taskHoursInput.Name = "taskHoursInput";
            this.taskHoursInput.Size = new System.Drawing.Size(100, 20);
            this.taskHoursInput.TabIndex = 18;
            // 
            // taskDescInput
            // 
            this.taskDescInput.Location = new System.Drawing.Point(133, 164);
            this.taskDescInput.Name = "taskDescInput";
            this.taskDescInput.Size = new System.Drawing.Size(100, 20);
            this.taskDescInput.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter Task Hours:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Task Description:";
            // 
            // taskIDInput
            // 
            this.taskIDInput.Location = new System.Drawing.Point(133, 141);
            this.taskIDInput.Name = "taskIDInput";
            this.taskIDInput.Size = new System.Drawing.Size(100, 20);
            this.taskIDInput.TabIndex = 14;
            this.taskIDInput.Text = "TASKID____";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Task ID:";
            // 
            // tasksButton
            // 
            this.tasksButton.Location = new System.Drawing.Point(59, 214);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(127, 53);
            this.tasksButton.TabIndex = 19;
            this.tasksButton.Text = "Add a Task";
            this.tasksButton.UseVisualStyleBackColor = true;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.errorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabel.Location = new System.Drawing.Point(55, 51);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 25);
            this.errorLabel.TabIndex = 20;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(96, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(142, 23);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back to Ronald\'s Form";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 282);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.tasksButton);
            this.Controls.Add(this.taskHoursInput);
            this.Controls.Add(this.taskDescInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskIDInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskLabel);
            this.Name = "AddTask";
            this.Text = "AddTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.TextBox taskHoursInput;
        private System.Windows.Forms.TextBox taskDescInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taskIDInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tasksButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button backButton;
    }
}