namespace Interactive_Book_Editor
{
    partial class BookEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookEditor));
            this.BookEditorStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddChapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SwitchChapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteChapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBookDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveBookDialog = new System.Windows.Forms.SaveFileDialog();
            this.IntercativeBookPropperties = new System.Windows.Forms.TabControl();
            this.BookProppertiesPage = new System.Windows.Forms.TabPage();
            this.PasswordChecking = new System.Windows.Forms.TextBox();
            this.PasswordSetupLabel = new System.Windows.Forms.Label();
            this.PasswordSetBox = new System.Windows.Forms.TextBox();
            this.BookPropperties_SaveChangesButton = new System.Windows.Forms.Button();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.BookAuthorEditor = new System.Windows.Forms.TextBox();
            this.BookLabel = new System.Windows.Forms.Label();
            this.BookLabelEditor = new System.Windows.Forms.TextBox();
            this.ChapterProppertiesPage = new System.Windows.Forms.TabPage();
            this.VariantNumberCounter = new System.Windows.Forms.NumericUpDown();
            this.ChapterPropperties_SaveChangesButton = new System.Windows.Forms.Button();
            this.VariantCountLabel = new System.Windows.Forms.Label();
            this.DictionaryLabel = new System.Windows.Forms.Label();
            this.ChapterIDLabel = new System.Windows.Forms.Label();
            this.AllowEditChapterID = new System.Windows.Forms.Button();
            this.ChapterIDEdit = new System.Windows.Forms.NumericUpDown();
            this.ChapterTextProppertiesTab = new System.Windows.Forms.TabPage();
            this.SaveChapterText = new System.Windows.Forms.Button();
            this.ChaperTextEditorLabel = new System.Windows.Forms.Label();
            this.ChapterText = new System.Windows.Forms.RichTextBox();
            this.VariantsEditorTab = new System.Windows.Forms.TabPage();
            this.VariantsGridSaveChangesButton = new System.Windows.Forms.Button();
            this.VariantsGrid = new System.Windows.Forms.DataGridView();
            this.Grid_VariantNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_VariantText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_NextChapterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariantsOfStoryDevelopmentLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BookEditorStrip.SuspendLayout();
            this.IntercativeBookPropperties.SuspendLayout();
            this.BookProppertiesPage.SuspendLayout();
            this.ChapterProppertiesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariantNumberCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChapterIDEdit)).BeginInit();
            this.ChapterTextProppertiesTab.SuspendLayout();
            this.VariantsEditorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariantsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BookEditorStrip
            // 
            this.BookEditorStrip.BackColor = System.Drawing.Color.BurlyWood;
            this.BookEditorStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BookEditorStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.главыToolStripMenuItem});
            this.BookEditorStrip.Location = new System.Drawing.Point(0, 0);
            this.BookEditorStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.BookEditorStrip.Name = "BookEditorStrip";
            this.BookEditorStrip.Size = new System.Drawing.Size(1006, 28);
            this.BookEditorStrip.TabIndex = 0;
            this.BookEditorStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveBookToolStripMenuItem,
            this.OpenBookToolStripMenuItem,
            this.CreateNewBookToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveBookToolStripMenuItem
            // 
            this.SaveBookToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.SaveBookToolStripMenuItem.Name = "SaveBookToolStripMenuItem";
            this.SaveBookToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.SaveBookToolStripMenuItem.Text = "Сохранить книгу";
            this.SaveBookToolStripMenuItem.Click += new System.EventHandler(this.SaveBookToolStripMenuItem_Click);
            // 
            // OpenBookToolStripMenuItem
            // 
            this.OpenBookToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.OpenBookToolStripMenuItem.Name = "OpenBookToolStripMenuItem";
            this.OpenBookToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.OpenBookToolStripMenuItem.Text = "Открыть книгу";
            this.OpenBookToolStripMenuItem.Click += new System.EventHandler(this.OpenBookToolStripMenuItem_Click);
            // 
            // CreateNewBookToolStripMenuItem
            // 
            this.CreateNewBookToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.CreateNewBookToolStripMenuItem.Name = "CreateNewBookToolStripMenuItem";
            this.CreateNewBookToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.CreateNewBookToolStripMenuItem.Text = "Создать новую книгу";
            this.CreateNewBookToolStripMenuItem.Click += new System.EventHandler(this.CreateNewBookToolStripMenuItem_Click);
            // 
            // главыToolStripMenuItem
            // 
            this.главыToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.главыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddChapterToolStripMenuItem,
            this.SwitchChapterToolStripMenuItem,
            this.DeleteChapterToolStripMenuItem});
            this.главыToolStripMenuItem.Name = "главыToolStripMenuItem";
            this.главыToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.главыToolStripMenuItem.Text = "Главы";
            // 
            // AddChapterToolStripMenuItem
            // 
            this.AddChapterToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.AddChapterToolStripMenuItem.Name = "AddChapterToolStripMenuItem";
            this.AddChapterToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.AddChapterToolStripMenuItem.Text = "Добавить";
            this.AddChapterToolStripMenuItem.Click += new System.EventHandler(this.AddChapterToolStripMenuItem_Click);
            // 
            // SwitchChapterToolStripMenuItem
            // 
            this.SwitchChapterToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.SwitchChapterToolStripMenuItem.Name = "SwitchChapterToolStripMenuItem";
            this.SwitchChapterToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.SwitchChapterToolStripMenuItem.Text = "Переключиться";
            this.SwitchChapterToolStripMenuItem.Click += new System.EventHandler(this.SwitchChapterToolStripMenuItem_Click);
            // 
            // DeleteChapterToolStripMenuItem
            // 
            this.DeleteChapterToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.DeleteChapterToolStripMenuItem.Name = "DeleteChapterToolStripMenuItem";
            this.DeleteChapterToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.DeleteChapterToolStripMenuItem.Text = "Удалить";
            this.DeleteChapterToolStripMenuItem.Click += new System.EventHandler(this.DeleteChapterToolStripMenuItem_Click);
            // 
            // OpenBookDialog
            // 
            this.OpenBookDialog.Filter = "Файл интерактивной книги (*.ibr)|*.ibr|Текстовый документ (*.txt)|*.txt|Все файлы" +
    " (*.*)|*.*";
            this.OpenBookDialog.Title = "Открыть книгу";
            // 
            // SaveBookDialog
            // 
            this.SaveBookDialog.DefaultExt = "ibr";
            this.SaveBookDialog.Filter = "Файл интерактивной книги (*.ibr)|*.ibr|Текстовый документ (*.txt)|*.txt|Все файлы" +
    " (*.*)|*.*";
            // 
            // IntercativeBookPropperties
            // 
            this.IntercativeBookPropperties.Controls.Add(this.BookProppertiesPage);
            this.IntercativeBookPropperties.Controls.Add(this.ChapterProppertiesPage);
            this.IntercativeBookPropperties.Controls.Add(this.ChapterTextProppertiesTab);
            this.IntercativeBookPropperties.Controls.Add(this.VariantsEditorTab);
            this.IntercativeBookPropperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntercativeBookPropperties.Location = new System.Drawing.Point(0, 28);
            this.IntercativeBookPropperties.Multiline = true;
            this.IntercativeBookPropperties.Name = "IntercativeBookPropperties";
            this.IntercativeBookPropperties.SelectedIndex = 0;
            this.IntercativeBookPropperties.Size = new System.Drawing.Size(1006, 693);
            this.IntercativeBookPropperties.TabIndex = 1;
            // 
            // BookProppertiesPage
            // 
            this.BookProppertiesPage.BackColor = System.Drawing.Color.PapayaWhip;
            this.BookProppertiesPage.Controls.Add(this.PasswordChecking);
            this.BookProppertiesPage.Controls.Add(this.PasswordSetupLabel);
            this.BookProppertiesPage.Controls.Add(this.PasswordSetBox);
            this.BookProppertiesPage.Controls.Add(this.BookPropperties_SaveChangesButton);
            this.BookProppertiesPage.Controls.Add(this.AuthorLabel);
            this.BookProppertiesPage.Controls.Add(this.BookAuthorEditor);
            this.BookProppertiesPage.Controls.Add(this.BookLabel);
            this.BookProppertiesPage.Controls.Add(this.BookLabelEditor);
            this.BookProppertiesPage.Location = new System.Drawing.Point(4, 29);
            this.BookProppertiesPage.Name = "BookProppertiesPage";
            this.BookProppertiesPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookProppertiesPage.Size = new System.Drawing.Size(998, 660);
            this.BookProppertiesPage.TabIndex = 0;
            this.BookProppertiesPage.Text = "Настройки книги";
            // 
            // PasswordChecking
            // 
            this.PasswordChecking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordChecking.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordChecking.Location = new System.Drawing.Point(181, 465);
            this.PasswordChecking.MaxLength = 200;
            this.PasswordChecking.Name = "PasswordChecking";
            this.PasswordChecking.PlaceholderText = "Подтверждение пароля";
            this.PasswordChecking.Size = new System.Drawing.Size(661, 43);
            this.PasswordChecking.TabIndex = 14;
            this.PasswordChecking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordChecking.UseSystemPasswordChar = true;
            // 
            // PasswordSetupLabel
            // 
            this.PasswordSetupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordSetupLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PasswordSetupLabel.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordSetupLabel.Location = new System.Drawing.Point(34, 349);
            this.PasswordSetupLabel.Margin = new System.Windows.Forms.Padding(10);
            this.PasswordSetupLabel.Name = "PasswordSetupLabel";
            this.PasswordSetupLabel.Padding = new System.Windows.Forms.Padding(10);
            this.PasswordSetupLabel.Size = new System.Drawing.Size(934, 54);
            this.PasswordSetupLabel.TabIndex = 13;
            this.PasswordSetupLabel.Text = "Установка пароля для книги";
            this.PasswordSetupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordSetBox
            // 
            this.PasswordSetBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordSetBox.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordSetBox.Location = new System.Drawing.Point(181, 416);
            this.PasswordSetBox.MaxLength = 200;
            this.PasswordSetBox.Name = "PasswordSetBox";
            this.PasswordSetBox.PlaceholderText = "Пароль";
            this.PasswordSetBox.Size = new System.Drawing.Size(661, 43);
            this.PasswordSetBox.TabIndex = 12;
            this.PasswordSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordSetBox.UseSystemPasswordChar = true;
            // 
            // BookPropperties_SaveChangesButton
            // 
            this.BookPropperties_SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookPropperties_SaveChangesButton.Location = new System.Drawing.Point(801, 611);
            this.BookPropperties_SaveChangesButton.Name = "BookPropperties_SaveChangesButton";
            this.BookPropperties_SaveChangesButton.Size = new System.Drawing.Size(189, 41);
            this.BookPropperties_SaveChangesButton.TabIndex = 11;
            this.BookPropperties_SaveChangesButton.Text = "Сохранить изменения";
            this.BookPropperties_SaveChangesButton.UseVisualStyleBackColor = true;
            this.BookPropperties_SaveChangesButton.Click += new System.EventHandler(this.BookPropperties_SaveChangesButton_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AuthorLabel.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorLabel.Location = new System.Drawing.Point(34, 179);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(10);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Padding = new System.Windows.Forms.Padding(10);
            this.AuthorLabel.Size = new System.Drawing.Size(934, 64);
            this.AuthorLabel.TabIndex = 10;
            this.AuthorLabel.Text = "Автор книги";
            this.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookAuthorEditor
            // 
            this.BookAuthorEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookAuthorEditor.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookAuthorEditor.Location = new System.Drawing.Point(181, 256);
            this.BookAuthorEditor.MaxLength = 200;
            this.BookAuthorEditor.Name = "BookAuthorEditor";
            this.BookAuthorEditor.PlaceholderText = "Фамилия Имя/Ник";
            this.BookAuthorEditor.Size = new System.Drawing.Size(661, 43);
            this.BookAuthorEditor.TabIndex = 9;
            this.BookAuthorEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BookLabel
            // 
            this.BookLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookLabel.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookLabel.Location = new System.Drawing.Point(34, 25);
            this.BookLabel.Margin = new System.Windows.Forms.Padding(10);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Padding = new System.Windows.Forms.Padding(10);
            this.BookLabel.Size = new System.Drawing.Size(934, 64);
            this.BookLabel.TabIndex = 8;
            this.BookLabel.Text = "Название книги";
            this.BookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookLabelEditor
            // 
            this.BookLabelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookLabelEditor.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookLabelEditor.Location = new System.Drawing.Point(181, 102);
            this.BookLabelEditor.MaxLength = 200;
            this.BookLabelEditor.Name = "BookLabelEditor";
            this.BookLabelEditor.PlaceholderText = "Крутая книга";
            this.BookLabelEditor.Size = new System.Drawing.Size(661, 43);
            this.BookLabelEditor.TabIndex = 0;
            this.BookLabelEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChapterProppertiesPage
            // 
            this.ChapterProppertiesPage.BackColor = System.Drawing.Color.PapayaWhip;
            this.ChapterProppertiesPage.Controls.Add(this.VariantNumberCounter);
            this.ChapterProppertiesPage.Controls.Add(this.ChapterPropperties_SaveChangesButton);
            this.ChapterProppertiesPage.Controls.Add(this.VariantCountLabel);
            this.ChapterProppertiesPage.Controls.Add(this.DictionaryLabel);
            this.ChapterProppertiesPage.Controls.Add(this.ChapterIDLabel);
            this.ChapterProppertiesPage.Controls.Add(this.AllowEditChapterID);
            this.ChapterProppertiesPage.Controls.Add(this.ChapterIDEdit);
            this.ChapterProppertiesPage.Location = new System.Drawing.Point(4, 29);
            this.ChapterProppertiesPage.Name = "ChapterProppertiesPage";
            this.ChapterProppertiesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChapterProppertiesPage.Size = new System.Drawing.Size(998, 660);
            this.ChapterProppertiesPage.TabIndex = 1;
            this.ChapterProppertiesPage.Text = "Настройки главы";
            // 
            // VariantNumberCounter
            // 
            this.VariantNumberCounter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VariantNumberCounter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VariantNumberCounter.Location = new System.Drawing.Point(362, 403);
            this.VariantNumberCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.VariantNumberCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VariantNumberCounter.Name = "VariantNumberCounter";
            this.VariantNumberCounter.Size = new System.Drawing.Size(252, 31);
            this.VariantNumberCounter.TabIndex = 10;
            this.VariantNumberCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VariantNumberCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ChapterPropperties_SaveChangesButton
            // 
            this.ChapterPropperties_SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChapterPropperties_SaveChangesButton.Location = new System.Drawing.Point(801, 611);
            this.ChapterPropperties_SaveChangesButton.Name = "ChapterPropperties_SaveChangesButton";
            this.ChapterPropperties_SaveChangesButton.Size = new System.Drawing.Size(189, 41);
            this.ChapterPropperties_SaveChangesButton.TabIndex = 9;
            this.ChapterPropperties_SaveChangesButton.Text = "Сохранить изменения";
            this.ChapterPropperties_SaveChangesButton.UseVisualStyleBackColor = true;
            this.ChapterPropperties_SaveChangesButton.Click += new System.EventHandler(this.ChapterPropperties_SaveChangesButton_Click);
            // 
            // VariantCountLabel
            // 
            this.VariantCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VariantCountLabel.AutoSize = true;
            this.VariantCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VariantCountLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VariantCountLabel.Location = new System.Drawing.Point(362, 346);
            this.VariantCountLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.VariantCountLabel.Name = "VariantCountLabel";
            this.VariantCountLabel.Size = new System.Drawing.Size(252, 24);
            this.VariantCountLabel.TabIndex = 4;
            this.VariantCountLabel.Text = "Количество вариантов";
            this.VariantCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DictionaryLabel
            // 
            this.DictionaryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DictionaryLabel.AutoSize = true;
            this.DictionaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DictionaryLabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DictionaryLabel.Location = new System.Drawing.Point(128, 283);
            this.DictionaryLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.DictionaryLabel.Name = "DictionaryLabel";
            this.DictionaryLabel.Size = new System.Drawing.Size(730, 33);
            this.DictionaryLabel.TabIndex = 3;
            this.DictionaryLabel.Text = "Настройка вариантов развития событий книги";
            this.DictionaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChapterIDLabel
            // 
            this.ChapterIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChapterIDLabel.AutoSize = true;
            this.ChapterIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChapterIDLabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChapterIDLabel.Location = new System.Drawing.Point(312, 72);
            this.ChapterIDLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.ChapterIDLabel.Name = "ChapterIDLabel";
            this.ChapterIDLabel.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.ChapterIDLabel.Size = new System.Drawing.Size(348, 43);
            this.ChapterIDLabel.TabIndex = 2;
            this.ChapterIDLabel.Text = "ID текущей главы";
            this.ChapterIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllowEditChapterID
            // 
            this.AllowEditChapterID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AllowEditChapterID.Location = new System.Drawing.Point(362, 212);
            this.AllowEditChapterID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.AllowEditChapterID.Name = "AllowEditChapterID";
            this.AllowEditChapterID.Size = new System.Drawing.Size(252, 31);
            this.AllowEditChapterID.TabIndex = 1;
            this.AllowEditChapterID.Text = "Редактировать ID текущей главы";
            this.AllowEditChapterID.UseVisualStyleBackColor = true;
            this.AllowEditChapterID.Click += new System.EventHandler(this.AllowEditChapterID_Click);
            // 
            // ChapterIDEdit
            // 
            this.ChapterIDEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChapterIDEdit.BackColor = System.Drawing.SystemColors.Window;
            this.ChapterIDEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChapterIDEdit.Location = new System.Drawing.Point(362, 148);
            this.ChapterIDEdit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.ChapterIDEdit.Maximum = new decimal(new int[] {
            998,
            0,
            0,
            0});
            this.ChapterIDEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ChapterIDEdit.Name = "ChapterIDEdit";
            this.ChapterIDEdit.ReadOnly = true;
            this.ChapterIDEdit.Size = new System.Drawing.Size(252, 31);
            this.ChapterIDEdit.TabIndex = 0;
            this.ChapterIDEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChapterIDEdit.Visible = false;
            // 
            // ChapterTextProppertiesTab
            // 
            this.ChapterTextProppertiesTab.BackColor = System.Drawing.Color.PapayaWhip;
            this.ChapterTextProppertiesTab.Controls.Add(this.SaveChapterText);
            this.ChapterTextProppertiesTab.Controls.Add(this.ChaperTextEditorLabel);
            this.ChapterTextProppertiesTab.Controls.Add(this.ChapterText);
            this.ChapterTextProppertiesTab.Location = new System.Drawing.Point(4, 29);
            this.ChapterTextProppertiesTab.Name = "ChapterTextProppertiesTab";
            this.ChapterTextProppertiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChapterTextProppertiesTab.Size = new System.Drawing.Size(998, 660);
            this.ChapterTextProppertiesTab.TabIndex = 2;
            this.ChapterTextProppertiesTab.Text = "Редактор текста главы";
            // 
            // SaveChapterText
            // 
            this.SaveChapterText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChapterText.Location = new System.Drawing.Point(801, 611);
            this.SaveChapterText.Name = "SaveChapterText";
            this.SaveChapterText.Size = new System.Drawing.Size(189, 41);
            this.SaveChapterText.TabIndex = 8;
            this.SaveChapterText.Text = "Сохранить текст главы";
            this.SaveChapterText.UseVisualStyleBackColor = true;
            this.SaveChapterText.Click += new System.EventHandler(this.SaveChapterText_Click);
            // 
            // ChaperTextEditorLabel
            // 
            this.ChaperTextEditorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChaperTextEditorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChaperTextEditorLabel.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChaperTextEditorLabel.Location = new System.Drawing.Point(10, 10);
            this.ChaperTextEditorLabel.Margin = new System.Windows.Forms.Padding(10);
            this.ChaperTextEditorLabel.Name = "ChaperTextEditorLabel";
            this.ChaperTextEditorLabel.Padding = new System.Windows.Forms.Padding(10);
            this.ChaperTextEditorLabel.Size = new System.Drawing.Size(980, 64);
            this.ChaperTextEditorLabel.TabIndex = 7;
            this.ChaperTextEditorLabel.Text = "Редактор текста главы";
            this.ChaperTextEditorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChapterText
            // 
            this.ChapterText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChapterText.BackColor = System.Drawing.Color.White;
            this.ChapterText.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChapterText.Location = new System.Drawing.Point(10, 82);
            this.ChapterText.MaxLength = 4096;
            this.ChapterText.Name = "ChapterText";
            this.ChapterText.Size = new System.Drawing.Size(980, 523);
            this.ChapterText.TabIndex = 6;
            this.ChapterText.Text = "Пожалуйста, откройте интерактивную книгу с помощью \"Файл\" -> \"Открыть книгу\".";
            // 
            // VariantsEditorTab
            // 
            this.VariantsEditorTab.BackColor = System.Drawing.Color.PapayaWhip;
            this.VariantsEditorTab.Controls.Add(this.VariantsGridSaveChangesButton);
            this.VariantsEditorTab.Controls.Add(this.VariantsGrid);
            this.VariantsEditorTab.Controls.Add(this.VariantsOfStoryDevelopmentLabel);
            this.VariantsEditorTab.Location = new System.Drawing.Point(4, 29);
            this.VariantsEditorTab.Name = "VariantsEditorTab";
            this.VariantsEditorTab.Padding = new System.Windows.Forms.Padding(3);
            this.VariantsEditorTab.Size = new System.Drawing.Size(998, 660);
            this.VariantsEditorTab.TabIndex = 3;
            this.VariantsEditorTab.Text = "Настройка вариантов развития сюжета";
            // 
            // VariantsGridSaveChangesButton
            // 
            this.VariantsGridSaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantsGridSaveChangesButton.Location = new System.Drawing.Point(801, 611);
            this.VariantsGridSaveChangesButton.Name = "VariantsGridSaveChangesButton";
            this.VariantsGridSaveChangesButton.Size = new System.Drawing.Size(189, 41);
            this.VariantsGridSaveChangesButton.TabIndex = 14;
            this.VariantsGridSaveChangesButton.Text = "Сохранить изменения";
            this.VariantsGridSaveChangesButton.UseVisualStyleBackColor = true;
            this.VariantsGridSaveChangesButton.Click += new System.EventHandler(this.VariantsGridSaveChangesButton_Click);
            // 
            // VariantsGrid
            // 
            this.VariantsGrid.AllowUserToAddRows = false;
            this.VariantsGrid.AllowUserToDeleteRows = false;
            this.VariantsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantsGrid.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.VariantsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "123123";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VariantsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VariantsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VariantsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grid_VariantNumber,
            this.Grid_VariantText,
            this.Grid_NextChapterId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VariantsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.VariantsGrid.GridColor = System.Drawing.Color.PapayaWhip;
            this.VariantsGrid.Location = new System.Drawing.Point(28, 100);
            this.VariantsGrid.Margin = new System.Windows.Forms.Padding(25);
            this.VariantsGrid.Name = "VariantsGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VariantsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.VariantsGrid.RowHeadersVisible = false;
            this.VariantsGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.PapayaWhip;
            this.VariantsGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.VariantsGrid.RowTemplate.Height = 29;
            this.VariantsGrid.Size = new System.Drawing.Size(942, 477);
            this.VariantsGrid.TabIndex = 13;
            // 
            // Grid_VariantNumber
            // 
            this.Grid_VariantNumber.Frozen = true;
            this.Grid_VariantNumber.HeaderText = "Номер варианта";
            this.Grid_VariantNumber.MaxInputLength = 2;
            this.Grid_VariantNumber.MinimumWidth = 6;
            this.Grid_VariantNumber.Name = "Grid_VariantNumber";
            this.Grid_VariantNumber.ReadOnly = true;
            this.Grid_VariantNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_VariantNumber.Width = 80;
            // 
            // Grid_VariantText
            // 
            this.Grid_VariantText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grid_VariantText.HeaderText = "Текст варианта";
            this.Grid_VariantText.MaxInputLength = 255;
            this.Grid_VariantText.MinimumWidth = 6;
            this.Grid_VariantText.Name = "Grid_VariantText";
            // 
            // Grid_NextChapterId
            // 
            this.Grid_NextChapterId.HeaderText = "Переход на главу с выбранным ID";
            this.Grid_NextChapterId.MinimumWidth = 6;
            this.Grid_NextChapterId.Name = "Grid_NextChapterId";
            this.Grid_NextChapterId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_NextChapterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Grid_NextChapterId.Width = 107;
            // 
            // VariantsOfStoryDevelopmentLabel
            // 
            this.VariantsOfStoryDevelopmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantsOfStoryDevelopmentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VariantsOfStoryDevelopmentLabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VariantsOfStoryDevelopmentLabel.Location = new System.Drawing.Point(28, 27);
            this.VariantsOfStoryDevelopmentLabel.Margin = new System.Windows.Forms.Padding(5);
            this.VariantsOfStoryDevelopmentLabel.Name = "VariantsOfStoryDevelopmentLabel";
            this.VariantsOfStoryDevelopmentLabel.Padding = new System.Windows.Forms.Padding(5);
            this.VariantsOfStoryDevelopmentLabel.Size = new System.Drawing.Size(942, 43);
            this.VariantsOfStoryDevelopmentLabel.TabIndex = 12;
            this.VariantsOfStoryDevelopmentLabel.Text = "Варианты развития сюжета";
            this.VariantsOfStoryDevelopmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.IntercativeBookPropperties);
            this.Controls.Add(this.BookEditorStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.BookEditorStrip;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "BookEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Book Editor";
            this.Load += new System.EventHandler(this.BookEditor_Load);
            this.BookEditorStrip.ResumeLayout(false);
            this.BookEditorStrip.PerformLayout();
            this.IntercativeBookPropperties.ResumeLayout(false);
            this.BookProppertiesPage.ResumeLayout(false);
            this.BookProppertiesPage.PerformLayout();
            this.ChapterProppertiesPage.ResumeLayout(false);
            this.ChapterProppertiesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariantNumberCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChapterIDEdit)).EndInit();
            this.ChapterTextProppertiesTab.ResumeLayout(false);
            this.VariantsEditorTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VariantsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip BookEditorStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem OpenBookToolStripMenuItem;
        private ToolStripMenuItem SaveBookToolStripMenuItem;
        private ToolStripMenuItem главыToolStripMenuItem;
        private ToolStripMenuItem AddChapterToolStripMenuItem;
        private ToolStripMenuItem SwitchChapterToolStripMenuItem;
        private ToolStripMenuItem DeleteChapterToolStripMenuItem;
        private OpenFileDialog OpenBookDialog;
        private SaveFileDialog SaveBookDialog;
        private TabControl IntercativeBookPropperties;
        private TabPage BookProppertiesPage;
        private TabPage ChapterProppertiesPage;
        private TabPage ChapterTextProppertiesTab;
        private RichTextBox ChapterText;
        private Label ChaperTextEditorLabel;
        private ToolStripMenuItem CreateNewBookToolStripMenuItem;
        private Button SaveChapterText;
        private TextBox BookLabelEditor;
        private Label BookLabel;
        private Label AuthorLabel;
        private TextBox BookAuthorEditor;
        private Label DictionaryLabel;
        private Label ChapterIDLabel;
        private Button AllowEditChapterID;
        private NumericUpDown ChapterIDEdit;
        private Label VariantCountLabel;
        private Button ChapterPropperties_SaveChangesButton;
        private Button BookPropperties_SaveChangesButton;
        private NumericUpDown VariantNumberCounter;
        private TabPage VariantsEditorTab;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView VariantsGrid;
        private Label VariantsOfStoryDevelopmentLabel;
        private Button VariantsGridSaveChangesButton;
        private TextBox PasswordChecking;
        private Label PasswordSetupLabel;
        private TextBox PasswordSetBox;
        private DataGridViewTextBoxColumn Grid_VariantNumber;
        private DataGridViewTextBoxColumn Grid_VariantText;
        private DataGridViewTextBoxColumn Grid_NextChapterId;
    }
}