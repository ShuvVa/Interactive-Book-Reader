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
    
    public partial class PasswordCheck : Form
    {
        private string book_password;

        //private string key = "IBR4EVER";

        internal static bool PasswordsEqual = false;
        public PasswordCheck()
        {
            InitializeComponent();
        }
        public PasswordCheck(string _pswrd )
        {
            InitializeComponent();
            Viginer_95 Decrypt = new (_pswrd);
            book_password = Decrypt.Decrypt();
        }

        public bool GetPasswordsEqual()
        {
            return PasswordsEqual;
        }

        private void PasswordCheckButton_Click(object sender, EventArgs e)
        {
            string incerted_password = PasswordCheckBox.Text.ToString();
            if (incerted_password != null && incerted_password != "")
            {
                if (incerted_password == book_password)
                {
                    PasswordsEqual = true;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "Неверный пароль",
                        "Ошибка доступа",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Поле ввода пароля пустое",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
