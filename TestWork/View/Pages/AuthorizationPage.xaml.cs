using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestWork.AppDate;

namespace TestWork.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Password))
            {
                MessageBox.Show("Введите пароль");

            }
            else
            {
                if (LoginTb.Password == "123")
                {
                    MessageBox.Show("Данные верны");
                    FrameHelper.mainFrame.Navigate(new View.Pages.TeacherPage());
                }
                else
                {
                    MessageBox.Show("Данные неверны");
                }
            }
        }
    }
}
