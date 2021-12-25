using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interactive_Book_Reader
{
    public partial class ChangeChapter : Form
    {

        static int new_id = 0;

        static bool SucessfulChange = false;

        public int GetNew_Id()
        {
            return new_id;
        }
        public ChangeChapter()
        {
            InitializeComponent();
        }
        public ChangeChapter(string[] Chapters_IDs)
        {
            InitializeComponent();
            ChangeChapter_ChapterIDComboBox.Items.AddRange(Chapters_IDs);
            ChangeChapter_ChapterIDComboBox.SelectedIndex = 1;
        }

        private void ChangeChapter_AcceptChangesButton_Click(object sender, EventArgs e)
        {
            string? selectedVariant = ChangeChapter_ChapterIDComboBox.SelectedItem.ToString();

            if (selectedVariant == null)
            {
                MessageBox.Show(
                    "Вы ничего не выбрали. Пожалуйста, выберите какой-либо из вариантов.",
                    "Ошибка выбора",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
            else
            {
                new_id = Convert.ToInt32(selectedVariant);
                SucessfulChange = true;
                Close();
            }
        }
    }
}
