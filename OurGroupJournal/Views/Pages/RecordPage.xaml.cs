using OurGroupJournal.Views.Windows.AddWindows;
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

namespace OurGroupJournal.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RecordPage.xaml
    /// </summary>
    public partial class RecordPage : Page
    {
        public RecordPage()
        {
            InitializeComponent();
            RecordDg.ItemsSource = App.context.Records.ToList();
        }

        private void AddRecordsBtn_Click(object sender, RoutedEventArgs e)
        {
            AddRecordWindow addRecordWindow = new AddRecordWindow();
            addRecordWindow.ShowDialog();
        }
    }
}
