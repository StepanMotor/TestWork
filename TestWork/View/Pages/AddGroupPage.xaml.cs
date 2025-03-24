using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public AddGroupPage()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.mainFrame.Navigate(new View.Pages.TeacherPage());
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(AddGroupTb.Text))
            {
                mes += "Введите название группы\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            //Group group = new Group()
            //{
            //    Name = AddGroupTb.Text,
            //};
            //App.context.Group.Add(group);
            //App.context.SaveChanges();
            //MessageBox.Show("Группа добавлена");

            AddGroupTb.Text = "";
        }
    }
}
