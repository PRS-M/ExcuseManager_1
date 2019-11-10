namespace ExcuseManager_1
{
    partial class MainForm
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
            this.excuseLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.lastUsedLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.excuseTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.lastUsedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fillDateLabel = new System.Windows.Forms.Label();
            this.folderButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // excuseLabel
            // 
            this.excuseLabel.AutoSize = true;
            this.excuseLabel.Location = new System.Drawing.Point(12, 15);
            this.excuseLabel.Name = "excuseLabel";
            this.excuseLabel.Size = new System.Drawing.Size(42, 13);
            this.excuseLabel.TabIndex = 0;
            this.excuseLabel.Text = "Excuse";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 41);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(42, 13);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "Results";
            // 
            // lastUsedLabel
            // 
            this.lastUsedLabel.AutoSize = true;
            this.lastUsedLabel.Location = new System.Drawing.Point(12, 67);
            this.lastUsedLabel.Name = "lastUsedLabel";
            this.lastUsedLabel.Size = new System.Drawing.Size(55, 13);
            this.lastUsedLabel.TabIndex = 2;
            this.lastUsedLabel.Text = "Last Used";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 93);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "FIll date";
            // 
            // excuseTextBox
            // 
            this.excuseTextBox.Location = new System.Drawing.Point(100, 12);
            this.excuseTextBox.Name = "excuseTextBox";
            this.excuseTextBox.Size = new System.Drawing.Size(250, 20);
            this.excuseTextBox.TabIndex = 4;
            this.excuseTextBox.TextChanged += new System.EventHandler(this.excuseTextBox_TextChanged);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(100, 38);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(250, 20);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.TextChanged += new System.EventHandler(this.resultTextBox_TextChanged);
            // 
            // lastUsedDateTimePicker
            // 
            this.lastUsedDateTimePicker.Location = new System.Drawing.Point(100, 64);
            this.lastUsedDateTimePicker.Name = "lastUsedDateTimePicker";
            this.lastUsedDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.lastUsedDateTimePicker.TabIndex = 8;
            this.lastUsedDateTimePicker.ValueChanged += new System.EventHandler(this.lastUsedDateTimePicker_ValueChanged);
            // 
            // fillDateLabel
            // 
            this.fillDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fillDateLabel.Location = new System.Drawing.Point(100, 91);
            this.fillDateLabel.Name = "fillDateLabel";
            this.fillDateLabel.Size = new System.Drawing.Size(250, 20);
            this.fillDateLabel.TabIndex = 9;
            this.fillDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(12, 121);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(75, 23);
            this.folderButton.TabIndex = 10;
            this.folderButton.Text = "Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(93, 121);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(174, 121);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 12;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Enabled = false;
            this.randomButton.Location = new System.Drawing.Point(255, 121);
            this.randomButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(95, 23);
            this.randomButton.TabIndex = 13;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 156);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.fillDateLabel);
            this.Controls.Add(this.lastUsedDateTimePicker);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.excuseTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.lastUsedLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.excuseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label excuseLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label lastUsedLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox excuseTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.DateTimePicker lastUsedDateTimePicker;
        private System.Windows.Forms.Label fillDateLabel;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

