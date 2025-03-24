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
    /// Логика взаимодействия для ListStudentPage.xaml
    /// </summary>
    public partial class ListStudentPage : Page
    {
        public ListStudentPage()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            //GroupCmb.ItemsSource = App.context.Group.ToList();

            StudentCmb.SelectedValuePath = "ID";
            StudentCmb.DisplayMemberPath = "Name";
            //StudentCmb.ItemsSource = App.context.Student.ToList();
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(StudentLv, "Оценки");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.mainFrame.Navigate(new View.Pages.TeacherPage());
        }

        private void StudentLv_Loaded(object sender, RoutedEventArgs e)
        {
            //StudentLv.ItemsSource = App.context.Journal.ToList();
        }
    }
}
