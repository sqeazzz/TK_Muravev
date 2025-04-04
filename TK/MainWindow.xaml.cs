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

namespace TK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int task1 = int.Parse(txtTask1.Text);
                int task2 = int.Parse(txtTask2.Text);
                int task3 = int.Parse(txtTask3.Text);
                int task4 = int.Parse(txtTask4.Text);

                int total = CalculateTotalScore(task1, task2, task3, task4);
                string grade = CalculateGrade(total);

                lblTotalScore.Text = $"Общая сумма: {total}";
                lblGrade.Text = $"Оценка: {grade}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public int CalculateTotalScore(int task1, int task2, int task3, int task4)
        {
            return task1 + task2 + task3 + task4;
        }

        public void ValidateInput(int score, int maxScore, string taskName)
        {
            if (score < 0 || score > maxScore)
                throw new ArgumentException($"{taskName}: баллы должны быть от 0 до {maxScore}");
        }

        public int ParseInput(string input, int maxScore, string taskName)
        {
            if (!int.TryParse(input, out int score))
                throw new FormatException($"Пожалуйста, введите корректное числовое значение для {taskName}.");

            ValidateInput(score, maxScore, taskName);
            return score;
        }

        public string CalculateGrade(int totalScore)
        {
            if (totalScore >= 70) return "5 (отлично)";
            else if (totalScore >= 40) return "4 (хорошо)";
            else if (totalScore >= 20) return "3 (удовлетворительно)";
            else return "2 (неудовлетворительно)";
        }
    }
}



