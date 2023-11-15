namespace PixisAirProject
{
    partial class AddWorkOrder
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
            this.backButton = new System.Windows.Forms.Button();
            this.workOrderButton = new System.Windows.Forms.Button();
            this.taskIDInput = new System.Windows.Forms.TextBox();
            this.planeNumberInput = new System.Windows.Forms.TextBox();
            this.taskIDLabel = new System.Windows.Forms.Label();
            this.planeNumLabel = new System.Windows.Forms.Label();
            this.workOrderIDInput = new System.Windows.Forms.TextBox();
            this.workOrderIDLabel = new System.Windows.Forms.Label();
            this.workOrderLabel = new System.Windows.Forms.Label();
            this.workOrderStatLabel = new System.Windows.Forms.Label();
            this.woStatInput = new System.Windows.Forms.TextBox();
            this.startDateInput = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateInput = new System.Windows.Forms.TextBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.laborInput = new System.Windows.Forms.TextBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.costInput = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.workOrderListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(104, 32);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back to Ronald\'s Form";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // workOrderButton
            // 
            this.workOrderButton.Location = new System.Drawing.Point(68, 371);
            this.workOrderButton.Name = "workOrderButton";
            this.workOrderButton.Size = new System.Drawing.Size(127, 53);
            this.workOrderButton.TabIndex = 9;
            this.workOrderButton.Text = "Add a Work Order";
            this.workOrderButton.UseVisualStyleBackColor = true;
            this.workOrderButton.Click += new System.EventHandler(this.workOrderButton_Click);
            // 
            // taskIDInput
            // 
            this.taskIDInput.Location = new System.Drawing.Point(141, 212);
            this.taskIDInput.Name = "taskIDInput";
            this.taskIDInput.Size = new System.Drawing.Size(100, 20);
            this.taskIDInput.TabIndex = 3;
            this.taskIDInput.Text = "TASKID____";
            // 
            // planeNumberInput
            // 
            this.planeNumberInput.Location = new System.Drawing.Point(141, 187);
            this.planeNumberInput.Name = "planeNumberInput";
            this.planeNumberInput.Size = new System.Drawing.Size(100, 20);
            this.planeNumberInput.TabIndex = 2;
            // 
            // taskIDLabel
            // 
            this.taskIDLabel.AutoSize = true;
            this.taskIDLabel.Location = new System.Drawing.Point(12, 215);
            this.taskIDLabel.Name = "taskIDLabel";
            this.taskIDLabel.Size = new System.Drawing.Size(76, 13);
            this.taskIDLabel.TabIndex = 26;
            this.taskIDLabel.Text = "Enter Task ID:";
            // 
            // planeNumLabel
            // 
            this.planeNumLabel.AutoSize = true;
            this.planeNumLabel.Location = new System.Drawing.Point(12, 190);
            this.planeNumLabel.Name = "planeNumLabel";
            this.planeNumLabel.Size = new System.Drawing.Size(105, 13);
            this.planeNumLabel.TabIndex = 25;
            this.planeNumLabel.Text = "Enter Plane Number:";
            // 
            // workOrderIDInput
            // 
            this.workOrderIDInput.Location = new System.Drawing.Point(141, 161);
            this.workOrderIDInput.Name = "workOrderIDInput";
            this.workOrderIDInput.Size = new System.Drawing.Size(100, 20);
            this.workOrderIDInput.TabIndex = 1;
            this.workOrderIDInput.Text = "ORDER_____";
            // 
            // workOrderIDLabel
            // 
            this.workOrderIDLabel.AutoSize = true;
            this.workOrderIDLabel.Location = new System.Drawing.Point(13, 164);
            this.workOrderIDLabel.Name = "workOrderIDLabel";
            this.workOrderIDLabel.Size = new System.Drawing.Size(104, 13);
            this.workOrderIDLabel.TabIndex = 23;
            this.workOrderIDLabel.Text = "Enter WorkOrder ID:";
            // 
            // workOrderLabel
            // 
            this.workOrderLabel.AutoSize = true;
            this.workOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.workOrderLabel.Location = new System.Drawing.Point(26, 134);
            this.workOrderLabel.Name = "workOrderLabel";
            this.workOrderLabel.Size = new System.Drawing.Size(205, 24);
            this.workOrderLabel.TabIndex = 2;
            this.workOrderLabel.Text = "ENTER WORKORDER";
            // 
            // workOrderStatLabel
            // 
            this.workOrderStatLabel.AutoSize = true;
            this.workOrderStatLabel.Location = new System.Drawing.Point(13, 240);
            this.workOrderStatLabel.Name = "workOrderStatLabel";
            this.workOrderStatLabel.Size = new System.Drawing.Size(126, 13);
            this.workOrderStatLabel.TabIndex = 32;
            this.workOrderStatLabel.Text = "Enter Work Order Status:";
            // 
            // woStatInput
            // 
            this.woStatInput.Location = new System.Drawing.Point(141, 237);
            this.woStatInput.Name = "woStatInput";
            this.woStatInput.Size = new System.Drawing.Size(100, 20);
            this.woStatInput.TabIndex = 4;
            // 
            // startDateInput
            // 
            this.startDateInput.Location = new System.Drawing.Point(141, 263);
            this.startDateInput.Name = "startDateInput";
            this.startDateInput.Size = new System.Drawing.Size(100, 20);
            this.startDateInput.TabIndex = 5;
            this.startDateInput.Text = "0000-00-00";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(13, 266);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(86, 13);
            this.startDateLabel.TabIndex = 34;
            this.startDateLabel.Text = "Enter Start Date:";
            // 
            // endDateInput
            // 
            this.endDateInput.Location = new System.Drawing.Point(141, 289);
            this.endDateInput.Name = "endDateInput";
            this.endDateInput.Size = new System.Drawing.Size(100, 20);
            this.endDateInput.TabIndex = 6;
            this.endDateInput.Text = "0000-00-00";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(13, 292);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(83, 13);
            this.endDateLabel.TabIndex = 36;
            this.endDateLabel.Text = "Enter End Date:";
            // 
            // laborInput
            // 
            this.laborInput.Location = new System.Drawing.Point(141, 341);
            this.laborInput.Name = "laborInput";
            this.laborInput.Size = new System.Drawing.Size(100, 20);
            this.laborInput.TabIndex = 8;
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(12, 344);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(96, 13);
            this.laborLabel.TabIndex = 38;
            this.laborLabel.Text = "Enter Labor Hours:";
            // 
            // costInput
            // 
            this.costInput.Location = new System.Drawing.Point(141, 315);
            this.costInput.Name = "costInput";
            this.costInput.Size = new System.Drawing.Size(100, 20);
            this.costInput.TabIndex = 7;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(13, 318);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(59, 13);
            this.costLabel.TabIndex = 40;
            this.costLabel.Text = "Enter Cost:";
            // 
            // workOrderListBox
            // 
            this.workOrderListBox.FormattingEnabled = true;
            this.workOrderListBox.Location = new System.Drawing.Point(13, 64);
            this.workOrderListBox.Name = "workOrderListBox";
            this.workOrderListBox.Size = new System.Drawing.Size(228, 56);
            this.workOrderListBox.TabIndex = 1;
            // 
            // AddWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 450);
            this.Controls.Add(this.workOrderListBox);
            this.Controls.Add(this.costInput);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.laborInput);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.endDateInput);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateInput);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.woStatInput);
            this.Controls.Add(this.workOrderStatLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.workOrderButton);
            this.Controls.Add(this.taskIDInput);
            this.Controls.Add(this.planeNumberInput);
            this.Controls.Add(this.taskIDLabel);
            this.Controls.Add(this.planeNumLabel);
            this.Controls.Add(this.workOrderIDInput);
            this.Controls.Add(this.workOrderIDLabel);
            this.Controls.Add(this.workOrderLabel);
            this.Name = "AddWorkOrder";
            this.Text = "AddWorkOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button workOrderButton;
        private System.Windows.Forms.TextBox taskIDInput;
        private System.Windows.Forms.TextBox planeNumberInput;
        private System.Windows.Forms.Label taskIDLabel;
        private System.Windows.Forms.Label planeNumLabel;
        private System.Windows.Forms.TextBox workOrderIDInput;
        private System.Windows.Forms.Label workOrderIDLabel;
        private System.Windows.Forms.Label workOrderLabel;
        private System.Windows.Forms.Label workOrderStatLabel;
        private System.Windows.Forms.TextBox woStatInput;
        private System.Windows.Forms.TextBox startDateInput;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.TextBox endDateInput;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.TextBox laborInput;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.TextBox costInput;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.ListBox workOrderListBox;
    }
}