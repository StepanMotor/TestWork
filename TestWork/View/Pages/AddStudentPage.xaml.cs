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
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();

            ChoiceGroupCmb.SelectedValuePath = "ID";
            ChoiceGroupCmb.DisplayMemberPath = "Name";
            //GroupCMB.ItemsSource = App.context.Group.ToList();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.mainFrame.Navigate(new View.Pages.TeacherPage());
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(AddNameTb.Text))
            {
                mes += "Введите ФИО\n";
            }
            if (string.IsNullOrWhiteSpace(ChoiceGroupCmb.Text))
            {
                mes += "Выберите группу\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Group selectedGroup = ChoiceGroupCmb.SelectedItem as Group;
            if (selectedGroup == null)
            {
                MessageBox.Show("Ошибка выбора группы");
                return;
            }

            //Student student = new Student()
            //{
            //    Name = AddNameTb.Text,
            //    IdGroup = selectedGroup.ID
            //};
            //App.context.Student.Add(student);
            //App.context.SaveChanges();
            //MessageBox.Show("Студент добавлен");

            AddNameTb.Text = "";
            ChoiceGroupCmb.Text = "";
        }
    }
}
