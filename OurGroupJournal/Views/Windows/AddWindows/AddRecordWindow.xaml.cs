using OurGroupJournal.Models;
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

namespace OurGroupJournal.Views.Windows.AddWindows
{
    /// <summary>
    /// Логика взаимодействия для AddRecordWindow.xaml
    /// </summary>
    public partial class AddRecordWindow : Window
    {
        public AddRecordWindow()
        {
            InitializeComponent();
            StudentCmb.ItemsSource = App.context.Students.ToList();
            DisciplineCmb.ItemsSource = App.context.Disciplines.ToList();
            MarkCmb.ItemsSource = App.context.Marks.ToList();
        }

        private void AddRecordBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(StudentCmb.Text) ||
                string.IsNullOrEmpty(DisciplineCmb.Text) ||
                string.IsNullOrEmpty(MarkCmb.Text) ||
                string.IsNullOrEmpty(DatePck.Text))
            {
                MessageBox.Show("Поля со звёздочкой обязательны к заполнению", "", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Records records = new Records()
                {
                    StudentId = ((Students)StudentCmb.SelectedItem).Id,
                    DisciplineId = ((Disciplines)DisciplineCmb.SelectedItem).Id,
                    MarkId = ((Marks)MarkCmb.SelectedItem).Id,
                    AssessmentDate = (DateTime)DatePck.SelectedDate
                };
                App.context.Records.Add(records);
                App.context.SaveChanges();
                MessageBox.Show("Запись добавлена", "", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
        }
    }
}
