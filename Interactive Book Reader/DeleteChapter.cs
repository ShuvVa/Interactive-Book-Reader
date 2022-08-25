//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Interactive_Book_Reader
{
    public partial class DeleteChapter : Form
    {
        //internal static int current_id; 
        static int DeleteChapterWithId = 0;

        static bool SucessfulDelete = false;
        public DeleteChapter()
        {
            InitializeComponent();
        }

        public DeleteChapter(string[] Chapter_IDs,int _current_id)
        {
            InitializeComponent();
            //current_id = _current_id;
            VariousIDComboBox.Items.AddRange(Chapter_IDs);
            VariousIDComboBox.SelectedIndex = 1;
            CurrentIDBox.Text = _current_id.ToString();
            CurrentIDRadioButton.Checked = true;
        }

        public int GetDeleteChapterWithId()
        {
            return DeleteChapterWithId;
        }

        public bool GetSucessfulDelete()
        {
            return SucessfulDelete;
        }

        private void ChangeChapter_AcceptChangesButton_Click(object sender, EventArgs e)
        {
            if (CurrentIDRadioButton.Checked == true)
            {
                if ((CurrentIDBox.Text == "0")||(CurrentIDBox.Text == "-1")) {
                    MessageBox.Show(
                        "Главы с ID \"0\" и \"-1\" являются необходимыми для корректной работы книги.",
                        "Ошибка удаления",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                    );
                }
                else
                {
                    DeleteChapterWithId = Convert.ToInt32(CurrentIDBox.Text);
                    SucessfulDelete = true;
                    Close();
                } 
                
            }
            if (VariousIDRadioButton.Checked == true)
            {
                if ((VariousIDComboBox.SelectedItem.ToString() == "0") || (VariousIDComboBox.SelectedItem.ToString() == "-1"))
                {
                    MessageBox.Show(
                        "Главы с ID \"0\" и \"-1\" являются необходимыми для корректной работы книги.",
                        "Ошибка удаления",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                    );
                }
                else
                {
                    DeleteChapterWithId = Convert.ToInt32(VariousIDComboBox.SelectedItem.ToString());
                    SucessfulDelete = true;
                    Close();
                }
            }
        }

        

        private void VariousIDRadioButton_Click(object sender, EventArgs e)
        {
            CurrentIDRadioButton.Checked = false;
            VariousIDRadioButton.Checked = true;
        }

        private void CurrentIDRadioButton_Click(object sender, EventArgs e)
        {
            CurrentIDRadioButton.Checked = true;
            VariousIDRadioButton.Checked = false;
        }
    }
}
