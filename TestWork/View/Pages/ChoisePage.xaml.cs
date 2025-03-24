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
    /// Логика взаимодействия для ChoisePage.xaml
    /// </summary>
    public partial class ChoisePage : Page
    {
        public ChoisePage()
        {
            InitializeComponent();
            CmbGroup.SelectedValuePath = "ID";
            CmbGroup.DisplayMemberPath = "Name";
            //CmbGroup.ItemsSource = App.context.Group.ToList();

            CmbStudent.SelectedValuePath = "ID";
            CmbStudent.DisplayMemberPath = "Name";
            //CmbStudent.ItemsSource = App.context.Student.ToList();


            CmbTest.SelectedValuePath = "ID";
            CmbTest.DisplayMemberPath = "Name";
            //CmbTest.ItemsSource = App.context.Test.ToList();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(CmbGroup.Text))
                mes += "Выберетe груnny\n";
            if (string.IsNullOrWhiteSpace(CmbStudent.Text))
                mes += "Выберите студента\n";
            if (string.IsNullOrWhiteSpace(CmbTest.Text))
                mes += "Выбeрите тест\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            else if (CmbTest.Text == "Общие основы функционирования субъектов хозяйствования")
            {
                //ClassFrame.Frame Body.Navigate(new PageMain.PageTest1());
            }
            else if (CmbTest.Text == "Сущность и структура основного капитала и оборотных средств предприятия")
            {
                //ClassFrame.Frame Body.Navigate(new PageMain.PageTest2());
            }
            else if (CmbTest.Text == "Формы и системы оплаты труда")
            {
                //ClassFrame.Frame Body.Navigate(new PageMain.PageTest3());
            }
            else if (CmbTest.Text == "Результаты коммерческой деятельности")
            {
                //ClassFrame.Frame Body.Navigate(new PageMain.PageTest4());
            }
        }

        private void CmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectGroup = Convert.ToInt32(CmbGroup.SelectedValue);
            //CmbGroup.ItemsSource = App.context.Student.Where(x => x.IdGroup == SelectGroup).ToList();
        }

        private void BtnStart_Click_1(object sender, RoutedEventArgs e)
        {
            FrameHelper.mainFrame.Navigate(new View.Pages.TestPage());
        }
    }
    }

