namespace Interactive_Book_Editor
{
    partial class ChangeChapter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeChapter));
            this.ChangeChapter_ChapterIDComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeChapterLabel = new System.Windows.Forms.Label();
            this.ChangeChapter_AcceptChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeChapter_ChapterIDComboBox
            // 
            this.ChangeChapter_ChapterIDComboBox.FormattingEnabled = true;
            this.ChangeChapter_ChapterIDComboBox.Location = new System.Drawing.Point(19, 152);
            this.ChangeChapter_ChapterIDComboBox.Name = "ChangeChapter_ChapterIDComboBox";
            this.ChangeChapter_ChapterIDComboBox.Size = new System.Drawing.Size(344, 28);
            this.ChangeChapter_ChapterIDComboBox.TabIndex = 0;
            // 
            // ChangeChapterLabel
            // 
            this.ChangeChapterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeChapterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChangeChapterLabel.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeChapterLabel.Location = new System.Drawing.Point(19, 19);
            this.ChangeChapterLabel.Margin = new System.Windows.Forms.Padding(10);
            this.ChangeChapterLabel.Name = "ChangeChapterLabel";
            this.ChangeChapterLabel.Padding = new System.Windows.Forms.Padding(10);
            this.ChangeChapterLabel.Size = new System.Drawing.Size(344, 120);
            this.ChangeChapterLabel.TabIndex = 14;
            this.ChangeChapterLabel.Text = "Выбор главы с определенным ID для редактирования";
            this.ChangeChapterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeChapter_AcceptChangesButton
            // 
            this.ChangeChapter_AcceptChangesButton.Location = new System.Drawing.Point(125, 267);
            this.ChangeChapter_AcceptChangesButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.ChangeChapter_AcceptChangesButton.Name = "ChangeChapter_AcceptChangesButton";
            this.ChangeChapter_AcceptChangesButton.Size = new System.Drawing.Size(132, 37);
            this.ChangeChapter_AcceptChangesButton.TabIndex = 15;
            this.ChangeChapter_AcceptChangesButton.Text = "Выбрать главу";
            this.ChangeChapter_AcceptChangesButton.UseVisualStyleBackColor = true;
            this.ChangeChapter_AcceptChangesButton.Click += new System.EventHandler(this.ChangeChapter_AcceptChangesButton_Click);
            // 
            // ChangeChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.ChangeChapter_AcceptChangesButton);
            this.Controls.Add(this.ChangeChapterLabel);
            this.Controls.Add(this.ChangeChapter_ChapterIDComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeChapter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор главы";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox ChangeChapter_ChapterIDComboBox;
        private Label ChangeChapterLabel;
        private Button ChangeChapter_AcceptChangesButton;
    }
}