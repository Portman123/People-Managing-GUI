namespace comp282_cw2_201319103
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
            this.NameEntry = new System.Windows.Forms.TextBox();
            this.NameEntryLabel = new System.Windows.Forms.Label();
            this.AgeEntry = new System.Windows.Forms.TextBox();
            this.AgeEntryLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.NameSortButton = new System.Windows.Forms.Button();
            this.AgeSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameEntry
            // 
            this.NameEntry.Location = new System.Drawing.Point(12, 28);
            this.NameEntry.Name = "NameEntry";
            this.NameEntry.Size = new System.Drawing.Size(177, 20);
            this.NameEntry.TabIndex = 0;
            // 
            // NameEntryLabel
            // 
            this.NameEntryLabel.AutoSize = true;
            this.NameEntryLabel.Location = new System.Drawing.Point(12, 12);
            this.NameEntryLabel.Name = "NameEntryLabel";
            this.NameEntryLabel.Size = new System.Drawing.Size(35, 13);
            this.NameEntryLabel.TabIndex = 1;
            this.NameEntryLabel.Text = "Name";
            // 
            // AgeEntry
            // 
            this.AgeEntry.Location = new System.Drawing.Point(195, 28);
            this.AgeEntry.Name = "AgeEntry";
            this.AgeEntry.Size = new System.Drawing.Size(54, 20);
            this.AgeEntry.TabIndex = 2;
            // 
            // AgeEntryLabel
            // 
            this.AgeEntryLabel.AutoSize = true;
            this.AgeEntryLabel.Location = new System.Drawing.Point(195, 12);
            this.AgeEntryLabel.Name = "AgeEntryLabel";
            this.AgeEntryLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeEntryLabel.TabIndex = 3;
            this.AgeEntryLabel.Text = "Age";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 54);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(93, 54);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(174, 54);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(12, 85);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(237, 173);
            this.OutputListBox.TabIndex = 7;
            this.OutputListBox.SelectedIndexChanged += new System.EventHandler(this.OutputListBox_SelectedIndexChanged);
            // 
            // NameSortButton
            // 
            this.NameSortButton.Location = new System.Drawing.Point(12, 265);
            this.NameSortButton.Name = "NameSortButton";
            this.NameSortButton.Size = new System.Drawing.Size(75, 23);
            this.NameSortButton.TabIndex = 8;
            this.NameSortButton.Text = "Name Sort";
            this.NameSortButton.UseVisualStyleBackColor = true;
            this.NameSortButton.Click += new System.EventHandler(this.NameSortButton_Click);
            // 
            // AgeSortButton
            // 
            this.AgeSortButton.Location = new System.Drawing.Point(93, 265);
            this.AgeSortButton.Name = "AgeSortButton";
            this.AgeSortButton.Size = new System.Drawing.Size(75, 23);
            this.AgeSortButton.TabIndex = 9;
            this.AgeSortButton.Text = "Age Sort";
            this.AgeSortButton.UseVisualStyleBackColor = true;
            this.AgeSortButton.Click += new System.EventHandler(this.AgeSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 303);
            this.Controls.Add(this.AgeSortButton);
            this.Controls.Add(this.NameSortButton);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AgeEntryLabel);
            this.Controls.Add(this.AgeEntry);
            this.Controls.Add(this.NameEntryLabel);
            this.Controls.Add(this.NameEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameEntry;
        private System.Windows.Forms.Label NameEntryLabel;
        private System.Windows.Forms.TextBox AgeEntry;
        private System.Windows.Forms.Label AgeEntryLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Button NameSortButton;
        private System.Windows.Forms.Button AgeSortButton;
    }
}

