namespace Interactive_Book_Reader
{
    partial class BookReader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookReader));
            this.ChoiceOptions = new System.Windows.Forms.ComboBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.BookLabel = new System.Windows.Forms.Label();
            this.ChapterText = new System.Windows.Forms.RichTextBox();
            this.BookReaderStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFontParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBookDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.BookReaderStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChoiceOptions
            // 
            this.ChoiceOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoiceOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoiceOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceOptions.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceOptions.Items.AddRange(new object[] {
            "variant_01",
            "variant_02",
            "variant_03",
            "variant_04",
            "variant_05",
            "variant_06",
            "variant_07",
            "variant_08",
            "variant_09",
            "variant_10"});
            this.ChoiceOptions.Location = new System.Drawing.Point(8, 663);
            this.ChoiceOptions.Name = "ChoiceOptions";
            this.ChoiceOptions.Size = new System.Drawing.Size(866, 35);
            this.ChoiceOptions.TabIndex = 2;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AcceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptButton.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptButton.Location = new System.Drawing.Point(880, 664);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(118, 35);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "Выбрать";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // BookLabel
            // 
            this.BookLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookLabel.Location = new System.Drawing.Point(8, 38);
            this.BookLabel.Margin = new System.Windows.Forms.Padding(10);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Padding = new System.Windows.Forms.Padding(10);
            this.BookLabel.Size = new System.Drawing.Size(990, 64);
            this.BookLabel.TabIndex = 4;
            this.BookLabel.Text = "BookLabel";
            this.BookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChapterText
            // 
            this.ChapterText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChapterText.BackColor = System.Drawing.Color.White;
            this.ChapterText.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChapterText.Location = new System.Drawing.Point(8, 115);
            this.ChapterText.Name = "ChapterText";
            this.ChapterText.ReadOnly = true;
            this.ChapterText.Size = new System.Drawing.Size(990, 542);
            this.ChapterText.TabIndex = 5;
            this.ChapterText.Text = "Пожалуйста, откройте интерактивную книгу с помощью \"Файл\" -> \"Открыть книгу\".";
            // 
            // BookReaderStrip
            // 
            this.BookReaderStrip.BackColor = System.Drawing.Color.BurlyWood;
            this.BookReaderStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BookReaderStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.BookReaderStrip.Location = new System.Drawing.Point(5, 0);
            this.BookReaderStrip.Name = "BookReaderStrip";
            this.BookReaderStrip.Size = new System.Drawing.Size(996, 28);
            this.BookReaderStrip.TabIndex = 6;
            this.BookReaderStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenBookToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenBookToolStripMenuItem
            // 
            this.OpenBookToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.OpenBookToolStripMenuItem.Name = "OpenBookToolStripMenuItem";
            this.OpenBookToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.OpenBookToolStripMenuItem.Text = "Открыть книгу";
            this.OpenBookToolStripMenuItem.Click += new System.EventHandler(this.OpenBookToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFontParametersToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // OpenFontParametersToolStripMenuItem
            // 
            this.OpenFontParametersToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.OpenFontParametersToolStripMenuItem.Name = "OpenFontParametersToolStripMenuItem";
            this.OpenFontParametersToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.OpenFontParametersToolStripMenuItem.Text = "Открыть параметры шрифтов";
            this.OpenFontParametersToolStripMenuItem.Click += new System.EventHandler(this.OpenFontParametersToolStripMenuItem_Click);
            // 
            // OpenBookDialog
            // 
            this.OpenBookDialog.Filter = "Файл интерактивной книги (*.isb)|*.isb|Текстовый документ (*.txt)|*.txt|Все файлы" +
    " (*.*)|*.*";
            this.OpenBookDialog.Title = "Открыть интерактивную книгу";
            // 
            // BookReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.ChapterText);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ChoiceOptions);
            this.Controls.Add(this.BookReaderStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2540, 1600);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "BookReader";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Book Reader";
            this.BookReaderStrip.ResumeLayout(false);
            this.BookReaderStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox ChoiceOptions;
        private Button AcceptButton;
        private Label BookLabel;
        private RichTextBox ChapterText;
        private MenuStrip BookReaderStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem OpenBookToolStripMenuItem;
        private ToolStripMenuItem OpenFontParametersToolStripMenuItem;
        private OpenFileDialog OpenBookDialog;
        private FontDialog fontDialog;
    }
}