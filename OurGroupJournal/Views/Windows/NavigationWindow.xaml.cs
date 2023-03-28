using OurGroupJournal.Views.Pages;
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
using System.Windows.Shapes;

namespace OurGroupJournal.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для NavigationWindow.xaml
    /// </summary>
    public partial class NavigationWindow : Window
    {
        public NavigationWindow()
        {
            InitializeComponent();
        }

        private void ShowDisciplinesBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewFrame.Navigate(new DisciplinePage());
        }

        private void ShowRecordsBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewFrame.Navigate(new RecordPage());
        }

        private void ShowStudentsBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewFrame.Navigate(new StudentPage());
        }
    }
}
