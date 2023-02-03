namespace Interactive_Book_Namespace
{
    partial class DeleteChapter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteChapter));
            this.ChangeChapter_AcceptChangesButton = new System.Windows.Forms.Button();
            this.DeleteChapterLabel = new System.Windows.Forms.Label();
            this.CurrentIDRadioButton = new System.Windows.Forms.RadioButton();
            this.VariousIDRadioButton = new System.Windows.Forms.RadioButton();
            this.CurrentIDBox = new System.Windows.Forms.TextBox();
            this.VariousIDComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ChangeChapter_AcceptChangesButton
            // 
            this.ChangeChapter_AcceptChangesButton.Location = new System.Drawing.Point(129, 349);
            this.ChangeChapter_AcceptChangesButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.ChangeChapter_AcceptChangesButton.Name = "ChangeChapter_AcceptChangesButton";
            this.ChangeChapter_AcceptChangesButton.Size = new System.Drawing.Size(132, 37);
            this.ChangeChapter_AcceptChangesButton.TabIndex = 17;
            this.ChangeChapter_AcceptChangesButton.Text = "Подтвердить";
            this.ChangeChapter_AcceptChangesButton.UseVisualStyleBackColor = true;
            this.ChangeChapter_AcceptChangesButton.Click += new System.EventHandler(this.ChangeChapter_AcceptChangesButton_Click);
            // 
            // DeleteChapterLabel
            // 
            this.DeleteChapterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteChapterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DeleteChapterLabel.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteChapterLabel.Location = new System.Drawing.Point(33, 93);
            this.DeleteChapterLabel.Margin = new System.Windows.Forms.Padding(10);
            this.DeleteChapterLabel.Name = "DeleteChapterLabel";
            this.DeleteChapterLabel.Padding = new System.Windows.Forms.Padding(10);
            this.DeleteChapterLabel.Size = new System.Drawing.Size(315, 83);
            this.DeleteChapterLabel.TabIndex = 16;
            this.DeleteChapterLabel.Text = "Удалить главу...";
            this.DeleteChapterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentIDRadioButton
            // 
            this.CurrentIDRadioButton.AutoSize = true;
            this.CurrentIDRadioButton.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentIDRadioButton.Location = new System.Drawing.Point(33, 212);
            this.CurrentIDRadioButton.Name = "CurrentIDRadioButton";
            this.CurrentIDRadioButton.Size = new System.Drawing.Size(150, 24);
            this.CurrentIDRadioButton.TabIndex = 18;
            this.CurrentIDRadioButton.TabStop = true;
            this.CurrentIDRadioButton.Text = "с текущим ID";
            this.CurrentIDRadioButton.UseVisualStyleBackColor = true;
            this.CurrentIDRadioButton.Click += new System.EventHandler(this.CurrentIDRadioButton_Click);
            // 
            // VariousIDRadioButton
            // 
            this.VariousIDRadioButton.AutoSize = true;
            this.VariousIDRadioButton.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VariousIDRadioButton.Location = new System.Drawing.Point(33, 256);
            this.VariousIDRadioButton.Name = "VariousIDRadioButton";
            this.VariousIDRadioButton.Size = new System.Drawing.Size(170, 24);
            this.VariousIDRadioButton.TabIndex = 19;
            this.VariousIDRadioButton.TabStop = true;
            this.VariousIDRadioButton.Text = "с выбранным ID";
            this.VariousIDRadioButton.UseVisualStyleBackColor = true;
            this.VariousIDRadioButton.Click += new System.EventHandler(this.VariousIDRadioButton_Click);
            // 
            // CurrentIDBox
            // 
            this.CurrentIDBox.Location = new System.Drawing.Point(263, 209);
            this.CurrentIDBox.MaxLength = 4;
            this.CurrentIDBox.Name = "CurrentIDBox";
            this.CurrentIDBox.ReadOnly = true;
            this.CurrentIDBox.Size = new System.Drawing.Size(85, 27);
            this.CurrentIDBox.TabIndex = 20;
            // 
            // VariousIDComboBox
            // 
            this.VariousIDComboBox.FormattingEnabled = true;
            this.VariousIDComboBox.Location = new System.Drawing.Point(263, 252);
            this.VariousIDComboBox.Name = "VariousIDComboBox";
            this.VariousIDComboBox.Size = new System.Drawing.Size(85, 28);
            this.VariousIDComboBox.TabIndex = 21;
            // 
            // DeleteChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.VariousIDComboBox);
            this.Controls.Add(this.CurrentIDBox);
            this.Controls.Add(this.VariousIDRadioButton);
            this.Controls.Add(this.CurrentIDRadioButton);
            this.Controls.Add(this.ChangeChapter_AcceptChangesButton);
            this.Controls.Add(this.DeleteChapterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteChapter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить главу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ChangeChapter_AcceptChangesButton;
        private Label DeleteChapterLabel;
        private RadioButton CurrentIDRadioButton;
        private RadioButton VariousIDRadioButton;
        private TextBox CurrentIDBox;
        private ComboBox VariousIDComboBox;
    }
}