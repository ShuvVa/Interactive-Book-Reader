//using System;
//using System.IO;
using System.Text.Json;
//using System.Threading.Tasks;
using Interactive_Book_Namespace;

namespace Interactive_Book_Reader
{
    public partial class BookReader : Form
    {
        public BookReader()
        {
            InitializeComponent();

            //OpenBookDialog.Filter = "Файл интерактивной книги (*.ibr)|*.ibr|Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
        }

        static Book restored_book = new Book();

        static int chapter_index = 0;

        static bool StateLocked = true;
        private void ChangeChapter()
        {
            int i;
            BookLabel.Text = restored_book.BookTitle;

            for (i = 0; restored_book.Chapters[i].ChapterId != chapter_index; i++) {
                if (i >= restored_book.Chapters.Count()) {
                    i = -1;
                    chapter_index = -1;
                }
            }

            ChapterText.Text = restored_book.Chapters[i].ChapterText;
            ChoiceOptions.Items.Clear();

            string[] temp_array = restored_book.Chapters[i].ChapterVariants.Keys.ToArray();

            ChoiceOptions.Items.AddRange(temp_array);
            ChoiceOptions.SelectedIndex = 0;
        }

        private void OpenBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StateLocked = true;

            if (OpenBookDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // Получаем выбранный файл
            string filename = OpenBookDialog.FileName;
            // Передаем путь к файлу в поток ввода данных
            StreamReader FileReader = new StreamReader(filename);
            
            try
            {
                restored_book = JsonSerializer.Deserialize<Book>(FileReader.ReadLine());
            }

            catch (System.ArgumentNullException)
            {
                Chapter begin = new () { ChapterId = 0, ChapterText = "Some text for begining.", ChapterVariants = new Dictionary <string, int> { { "Let's go to the end, variant 1", -1 }, { "Let's go to the end, variant 2", -1 }, { "Let's go to the end, variant 3", -1 } } };
                Chapter end = new () { ChapterId = -1, ChapterText="End of the book", ChapterVariants = new Dictionary <string, int> { {"End of the book", -1 } } };

                Chapter[] chapters = new [] { begin, end };

                restored_book = new Book { BookAuthor = "Cool Author", BookTitle = "Cool Book", Password = "1111", Chapters = chapters };

                MessageBox.Show(
                    "Книга оказалась пустой. На место нее будет подключена шаблонная книга.",
                    "Ошибка открытия книги",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
            finally
            {
                MessageBox.Show(
                    "Книга успешно открыта!",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );

                StateLocked = false;
            }
                
            FileReader.Close();

            ChangeChapter();
            }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (StateLocked)
            {
                MessageBox.Show(
                    "Книга не была выбрана.",
                    "Ошибка чтения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
            else
            {
                string? selectedVariant = ChoiceOptions.SelectedItem.ToString();

                if (selectedVariant == null)
                {
                    MessageBox.Show(
                    "Вы не выбрали ни один из вариантов. Пожалуйста, выберите вариант дальнейшего развития событий.",
                    "Ошибка чтения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
                }

                else
                {
                    if (chapter_index != -1)
                        chapter_index = restored_book.Chapters[chapter_index].ChapterVariants[selectedVariant];
                    else Application.Exit();

                    ChangeChapter();
                }
            }
        }

        private void OpenFontParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта
            ChoiceOptions.Font = fontDialog.Font;
            ChapterText.Font = fontDialog.Font;
            AcceptButton.Font = fontDialog.Font;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ChoiceOptions.SelectedIndex = 0;
        }

        private void OpenBookEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BookEditor form = new BookEditor();

            //form.ShowDialog();
        }

        private void BookReader_Load(object sender, EventArgs e)
        {
            ChoiceOptions.SelectedIndex = 0;
        }
    }
} 
