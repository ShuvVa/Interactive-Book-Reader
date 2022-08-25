//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Text.Json;
//using System.Threading.Tasks;
//using System.Windows.Forms;


namespace Interactive_Book_Reader
{
    public partial class BookEditor : Form
    {
        public static Book book_editable;

        public static int chapter_count;

        public static int current_chapter;
        public BookEditor()
        {
            InitializeComponent();
        }

        public void Book_New()
        {
            Chapter begin = new () { ChapterId = 0, ChapterText = "Some text for begining.", ChapterVariants = new Dictionary <string, int> { { "Let's go to the end, variant 1", -1 }, { "Let's go to the end, variant 2", -1 }, { "Let's go to the end, variant 3", -1 } } };
            Chapter end = new () { ChapterId = -1, ChapterText="End of the book", ChapterVariants = new Dictionary <string, int> { {"End of the book", -1 } } };

            Chapter[] chapters = new [] { begin, end };

            book_editable = new Book { BookAuthor = "Cool Author", BookTitle = "Cool Book", Password = "1111", Chapters = chapters };

            chapter_count = book_editable.Chapters.Length;
        }

        public void ChangeGrid(int NewCurrentChapter)
        {
            //  Временные массивы, содержащие в себе тексты вариантов и ID вариантов следующих глав
            string[] temp_array_string = book_editable.Chapters[NewCurrentChapter].ChapterVariants.Keys.ToArray();
            int[] temp_array_int = book_editable.Chapters[NewCurrentChapter].ChapterVariants.Values.ToArray();

            //  Очистка таблицы вариантов выбора
            VariantsGrid.Rows.Clear();

            //  Заполнение ChapterTextProppertiesTab
            ChapterText.Text = book_editable.Chapters[NewCurrentChapter].ChapterText;

            //  Заполнение VariantsGrid
            for (int i = 0; i < book_editable.Chapters[NewCurrentChapter].ChapterVariants.Count; i++)
            {
                VariantsGrid.Rows.Add(1);
            }
            for (int i = 0; i < VariantsGrid.Rows.Count; i++)
            {
                VariantsGrid[0, i].Value = i + 1;
                VariantsGrid[1, i].Value = temp_array_string[i];
                VariantsGrid[2, i].Value = temp_array_int[i];
            }
        }

        public void ChangeChapter(int NewCurrentChapter)
        {
            //  Заполнение ChapterProppertiesPage
            ChapterIDEdit.Value = book_editable.Chapters[NewCurrentChapter].ChapterId;
            VariantNumberCounter.Value = book_editable.Chapters[NewCurrentChapter].ChapterVariants.Count;
            current_chapter = NewCurrentChapter;

            //  Заполнение ChapterTextProppertiesTab
            ChapterText.Text = book_editable.Chapters[NewCurrentChapter].ChapterText;

            //  Заполнение VariantsGrid
            ChangeGrid(NewCurrentChapter);
        }

        public void GetBookData()
        {
            //Количество глав в книге
            chapter_count = book_editable.Chapters.Length;

            //  Заполнение BookProppertiesPage
            BookLabelEditor.Text = book_editable.BookTitle;
            BookAuthorEditor.Text = book_editable.BookAuthor;
            PasswordSetBox.Text = book_editable.Password;
            PasswordChecking.Text = book_editable.Password;

            //  Замена содержимого формы на начальную главу
            ChangeChapter(0);
        }

        public string[] GetChapterIDs()
        {
            string[] Chapters_IDs = new string[book_editable.Chapters.Length];

            //  Процесс записи ID всех глав в книге в массив
            for (int i = 0; i < book_editable.Chapters.Length; i++)
            {
                Chapters_IDs[i] = Convert.ToString(book_editable.Chapters[i].ChapterId);
            }
            //  Сортировка глав
            for (int i = 0; i < book_editable.Chapters.Length; i++)
            {
                for (int j = 0; j < book_editable.Chapters.Length - 1; j++)
                {
                    if (Convert.ToInt32(Chapters_IDs[j]) > Convert.ToInt32(Chapters_IDs[j + 1])) { string temp = Chapters_IDs[j]; Chapters_IDs[j] = Chapters_IDs[j + 1]; Chapters_IDs[j + 1] = temp; }
                }
            }

            return Chapters_IDs;
        }
        private void AllowEditChapterID_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите изменить текущий ID главы? Это может повлиять на работоспособность книги.",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1
            );
            if (result == DialogResult.Yes) ChapterIDEdit.Visible = true;
            else ChapterIDEdit.Visible = false;
        }

        private void OpenBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Запуск диалога выбора файла
            if (OpenBookDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            //  Блок чтения книги с файла
            string filename = OpenBookDialog.FileName;
            StreamReader FileReader = new StreamReader(filename);
            Book temp_book = new Book();

            try
            {
                temp_book = JsonSerializer.Deserialize<Book>(FileReader.ReadLine());
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show(
                    "Выбранный файл с книгой - пустой. Будет создана новая книга.",
                    "Ошибка открытия книги",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
                Book_New();
                Viginer_95 viginer_95 = new Viginer_95(book_editable.Password);
                book_editable.Password = viginer_95.Encrypt();
            }

            
            
            FileReader.Close();

            //  Вызов формы проверки пароля
            PasswordCheck form = new PasswordCheck(temp_book.Password);
            form.ShowDialog();

            //В случае, если форма пройдена, идет загрузка данных книги
            if (form.GetPasswordsEqual() == true)
            {
                book_editable = temp_book;
                GetBookData();
            }

        }

        private void BookEditor_Load(object sender, EventArgs e)
        {
            //  Задание шаблонной книги при инициализации формы
            Book_New();
            GetBookData();
        }

        private void CreateNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Задание шаблонной книги при инициализации формы
            Book_New();
            //  Загрузка данных в форму
            GetBookData();
        }

        private void AddChapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (book_editable.Chapters.Length <= 1000)
            {
                if (book_editable.Chapters[chapter_count-2].ChapterId + 2 == chapter_count)
                {
                    chapter_count++;

                    Chapter temporary = new () { ChapterId = chapter_count-2, ChapterText = "Some text for test chapter.", ChapterVariants = new Dictionary <string, int> { { "Let's go to the end, variant 1", -1 }, { "Let's go to the end, variant 2", -1 }, { "Let's go to the end, variant 3", -1 } } };
                    //  Задание листа для добавления новой главы к сущестующим
                    List<Chapter> chapters = new List<Chapter> { };
                    chapters.AddRange(book_editable.Chapters);
                    chapters.Add(temporary);
                    //  Перестановка новой главы и завершения книги
                    var temp = chapters[chapter_count - 1]; chapters[chapter_count - 1] = chapters[chapter_count - 2]; chapters[chapter_count - 2] = temp;
                    //  Задание книге увеличенного массива глав
                    book_editable.Chapters = chapters.ToArray();
                }
                else
                {
                    chapter_count++;
                    string[] ChapterIDs = GetChapterIDs();
                    int i = 0;
                    for (i = 1; i < ChapterIDs.Length; i++)
                    {
                        if (Convert.ToInt32(ChapterIDs[i]) - Convert.ToInt32(ChapterIDs[i - 1]) >= 2)
                            break;

                    }
                    Chapter temporary = new () { ChapterId = i-1, ChapterText = "Some text for test chapter.", ChapterVariants = new Dictionary <string, int> { { "Let's go to the end, variant 1", -1 }, { "Let's go to the end, variant 2", -1 }, { "Let's go to the end, variant 3", -1 } } };
                    
                    List<Chapter> chapters = new List<Chapter> { };
                    chapters.AddRange(book_editable.Chapters);
                    chapters.Add(temporary);
                    //  Перестановка новой главы и завершения книги
                    var temp = chapters[chapter_count - 1]; chapters[chapter_count - 1] = chapters[chapter_count - 2]; chapters[chapter_count - 2] = temp;
                    //  Задание книге увеличенного массива глав
                    book_editable.Chapters = chapters.ToArray();
                }
            }
            else
            {
                MessageBox.Show(
                    "Слишком большое количество глав!",
                    "Ошибка добавления главы",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
        }

        private void SwitchChapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Переменная, отвечающая за главу, на которую будет сменяться содержимое формы
            int NextChapter = 0;

            if (book_editable.Chapters.Length < 2) {
                //  В случае, если книга не открыта (либо битая), вылезает окно, что надо либо создать новую, либо открыть другую
                MessageBox.Show(
                    "Книга является поврежденной. Откройте другую или создайте новую.",
                    "Ошибка открытия книги",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
            else
            {
                //  Запуски формы для выбора главы, на которую будет заменена текущая
                ChangeChapter form = new (GetChapterIDs());
                form.ShowDialog();

                //  Перебор ID для поиска главы, на которую будет заменена текущая
                for (int i = 0; i < book_editable.Chapters.Length; i++)
                {
                    if (form.GetNew_Id() == book_editable.Chapters[i].ChapterId) NextChapter = i;
                }
                //  Смена текущей главы на новую
                ChangeChapter(NextChapter);
            }
            
        }

        private void DeleteChapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Запуск формы удаления главы
            DeleteChapter form = new (GetChapterIDs(),current_chapter);
            form.ShowDialog();
            if (form.GetSucessfulDelete() == true)
            {
                chapter_count--;
                int chapter_to_delete = form.GetDeleteChapterWithId();

                List <Chapter> chapters = new List<Chapter>();
                chapters.AddRange(book_editable.Chapters);

                for (int i = 0; i < book_editable.Chapters.Length; i++)
                {
                    if (book_editable.Chapters[i].ChapterId == chapter_to_delete)
                    {
                        chapters.RemoveAt(i);
                    }
                }

                book_editable.Chapters = chapters.ToArray();

                MessageBox.Show(
                    "Удаление главы с ID " + chapter_to_delete + " прошло успешно.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );

                ChangeChapter(0);
            }
        }

        public void ChaptersSort()
        {
            List<Chapter>chapters = new List<Chapter> ();
            chapters.AddRange(book_editable.Chapters);
            
            for (int i = 1; i < chapters.Count - 1; i++)
            {
                for (int j = 1; j < chapters.Count - 2; j++)
                {
                    if (chapters[j].ChapterId > chapters[j + 1].ChapterId) { Chapter Temp = chapters[j]; chapters[j] = chapters[j + 1]; chapters[j + 1] = Temp; }
                }
            }

            book_editable.Chapters = chapters.ToArray();

        }
        private void SaveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveBookDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = SaveBookDialog.FileName;
            StreamWriter FileWriter = new StreamWriter(filename, true);

            Viginer_95 Encrypt = new(book_editable.Password);
            book_editable.Password = (Encrypt.Encrypt());

            ChaptersSort();

            FileWriter.WriteLine(JsonSerializer.Serialize(book_editable));
            FileWriter.Close();
        }

        private void BookPropperties_SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (BookLabelEditor.Text ==null|| BookLabelEditor.Text == "")
            {
                MessageBox.Show(
                    "Текстовое поле с названием книги пустое.",
                    "Ошибка сохранения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            } 
            else if (BookAuthorEditor.Text == null|| BookAuthorEditor.Text == "")
            {
                MessageBox.Show(
                    "Текстовое поле с именем автора пустое.",
                    "Ошибка сохранения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            } 
            else if (PasswordSetBox.Text == "")
            {
                MessageBox.Show(
                    "Текстовое поле с вводимым паролем пустое.",
                    "Ошибка сохранения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
            else if (PasswordChecking.Text == "")
            {
                MessageBox.Show(
                    "Текстовое поле с подтверждением пароля пустое.",
                    "Ошибка сохранения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
            else if (PasswordSetBox.Text != PasswordChecking.Text)
            {
                MessageBox.Show(
                    "Введенные пароли не совпадают.",
                    "Ошибка сохранения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
            else

            {
                book_editable.BookTitle = BookLabelEditor.Text;
                book_editable.BookAuthor = BookAuthorEditor.Text;
                book_editable.Password = PasswordSetBox.Text;

                MessageBox.Show(
                    "Изменение данных прошло успешно.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );
            }
        }

        private void ChapterPropperties_SaveChangesButton_Click(object sender, EventArgs e)
        {
            bool IsNoError = true;
            if (ChapterIDEdit.Visible)
            {
                for (int i = 0; i < book_editable.Chapters.Count(); i++)
                {
                    if (ChapterIDEdit.Value.Equals(0) || ChapterIDEdit.Value.Equals(-1))
                    {
                        MessageBox.Show(
                            "Зарезервированные системные ID не могут быть использованы для других глав.",
                            "Ошибка изменения ID",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1
                        );
                        IsNoError = false;
                        break;
                    }
                    else if (ChapterIDEdit.Value.Equals(book_editable.Chapters[i].ChapterId))
                    {
                        MessageBox.Show(
                            "Такое значение ID уже занято другой главой.",
                            "Ошибка изменения ID",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1
                        );
                        IsNoError = false;
                        break;
                    }
                    else book_editable.Chapters[current_chapter].ChapterId = ((int)ChapterIDEdit.Value);
                }
            }
            if (IsNoError)
            {
                int current_number_of_variants = book_editable.Chapters[current_chapter].ChapterVariants.Count;
                int new_number_of_variants = Convert.ToInt32(VariantNumberCounter.Value);

                string temp_string = "New text for new variant №";
                int temp_int = -1;

                List<string> current_variants_text = new List<string>();
                List<int> current_next_chapters = new List<int>();

                current_variants_text.AddRange(book_editable.Chapters[current_chapter].ChapterVariants.Keys);
                current_next_chapters.AddRange(book_editable.Chapters[current_chapter].ChapterVariants.Values);

                if (new_number_of_variants - current_number_of_variants > 0)
                {
                    for (int i = 0; i < new_number_of_variants - current_number_of_variants; i++)
                        book_editable.Chapters[current_chapter].ChapterVariants.Add(temp_string + (i + current_number_of_variants + 1) + ".", temp_int);
                }
                else if (current_number_of_variants - new_number_of_variants > 0)
                {
                    for (int i = current_number_of_variants - 1; i >= book_editable.Chapters[current_chapter].ChapterVariants.Count - (current_number_of_variants - new_number_of_variants); i--)
                    {
                        current_variants_text.RemoveAt(i);
                        current_next_chapters.RemoveAt(i);
                    }
                    book_editable.Chapters[current_chapter].ChapterVariants.Clear();
                    for (int i = 0; i < current_variants_text.Count; i++)
                    {
                        book_editable.Chapters[current_chapter].ChapterVariants.Add(current_variants_text[i], current_next_chapters[i]);
                    }
                }

                ChangeGrid(current_chapter);
                MessageBox.Show(
                    "Изменение данных прошло успешно.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );
            }
        }

        private void SaveChapterText_Click(object sender, EventArgs e)
        {
            if (ChapterText.Text == null || ChapterText.Text == "")
            {
                MessageBox.Show(
                    "Текстовое поле с текстом главы пустое.",
                    "Ошибка сохранения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
            else
            {
                book_editable.Chapters[current_chapter].ChapterText = ChapterText.Text;
                MessageBox.Show(
                    "Изменение данных прошло успешно.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );
            }
        }

        private bool AnyEqualKey()
        {
            for (int i = 0; i < VariantsGrid.RowCount; i++)
            {
                for (int j = 0; j < VariantsGrid.ColumnCount; j++)
                {
                    if ((VariantsGrid[1, i].Value.ToString() == VariantsGrid[1, j].Value.ToString()) && (i != j))
                        return true;
                }
            }
            return false;
        }

        private bool StrHasOtherChars(string str)
        {
            for (int i = 0;i < str.Length; i++)
            {
                if ((str[i] < '0' || str[i] > '9') && (str[i] != '-'))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsChapterWithThisIDExists(int _id)
        {
            for (int i = 0; i < book_editable.Chapters.Length; i++)
            {
                if (_id == book_editable.Chapters[i].ChapterId) return true;
            }
            return false;
        }

        private void VariantsGridSaveChangesButton_Click(object sender, EventArgs e)
        {
            bool IsError = false;
            for (int i = 0; i < book_editable.Chapters[current_chapter].ChapterVariants.Count; i++)
            {
                if (VariantsGrid[1, i].Value == null )
                {
                    MessageBox.Show(
                        "Вариант №" + (i + 1) + ": текстовое поле варианта - пустое. Повторите попытку ввода.",
                        "Ошибка сохранения",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                    );
                    IsError = true;
                } else if (VariantsGrid[1, i].Value.ToString() == "")
                {
                    MessageBox.Show(
                        "Вариант №" + (i + 1) + ": текстовое поле варианта - пустое. Повторите попытку ввода.",
                        "Ошибка сохранения",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                    );
                    IsError = true;
                }
                else if (AnyEqualKey())
                {
                    MessageBox.Show(
                        "Какие-то из вариантов - одинаковые. Попробуйте их отредактировать и сохранить вновь.",
                        "Ошибка сохранения",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                    );
                    IsError = true;
                    break;
                }
                else if (VariantsGrid[2, i].Value == null)
                {
                    MessageBox.Show(
                        "Вариант №" + (i + 1) + ": текстовое поле ID главы - пустое. Повторите попытку ввода.",
                        "Ошибка сохранения",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                    );
                    IsError = true;
                }
                else if (VariantsGrid[2, i].Value.ToString() == "")
                {
                    MessageBox.Show(
                        "Вариант №" + (i + 1) + ": текстовое поле ID главы - пустое. Повторите попытку ввода.",
                        "Ошибка сохранения",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                    );
                    IsError = true;
                }
                else if (StrHasOtherChars(VariantsGrid[2, i].Value.ToString())
                    ||
                    (Convert.ToInt32(VariantsGrid[2, i].Value.ToString()) < -1)
                    ||
                    (Convert.ToInt32(VariantsGrid[2, i].Value.ToString()) > 998)
                )
                {
                MessageBox.Show(
                    "Вариант №" + (i + 1) + ": было введено неправильное значение ID главы. Повторите попытку ввода.",
                    "Ошибка сохранения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
                    IsError = true;
                }
                else if (!IsChapterWithThisIDExists(Convert.ToInt32(VariantsGrid[2, i].Value.ToString())))
                {
                    MessageBox.Show(
                        "Вариант №" + (i + 1) + ": Главы с таким ID не существует. Повторите попытку ввода.",
                        "Ошибка сохранения",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                    );
                    IsError = true;
                }
            }
            if (!IsError)
            {
                book_editable.Chapters[current_chapter].ChapterVariants.Clear();
                for (int i = 0; i < VariantsGrid.RowCount; i++)
                {
                    string var = VariantsGrid[1, i].Value.ToString();
                    int ID = Convert.ToInt32(VariantsGrid[2, i].Value.ToString());
                    book_editable.Chapters[current_chapter].ChapterVariants.Add(var, ID);
                }

                MessageBox.Show(
                    "Изменение данных прошло успешно.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );
            }
        }
    }
}
