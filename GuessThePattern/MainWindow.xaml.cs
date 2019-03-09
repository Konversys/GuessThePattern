using GuessThePattern.Model;
using System;
using System.Windows;

namespace GuessThePattern
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (!controller.CheckIsStart())
            {
                MessageBox.Show(String.Format("{0} из 100 баллов", controller.GetScore()), "Ваш результат");
                start.Visibility = Visibility.Visible;
                grid.Visibility = Visibility.Hidden;
                return;
            }
            if (CheckVariant())
            {
                controller.TakeRightAnwer();
            }
            controller.Next();
            SetVariants();
        }

        void SetVariants()
        {
            variant1.IsChecked = false;
            variant2.IsChecked = false;
            variant3.IsChecked = false;
            variant4.IsChecked = false;
            variant1.Content = controller.Patterns[0].Title;
            variant2.Content = controller.Patterns[1].Title;
            variant3.Content = controller.Patterns[2].Title;
            variant4.Content = controller.Patterns[3].Title;
            progress.Text = String.Format("Прогресс выполнения: {0} из 10", controller.Count);
            if (controller.DetermineTask())
            {
                code.Text = "";
                scroll.Visibility = Visibility.Hidden;
                image.Source = controller.GetRightPattern().UML;
            }
            else
            {
                image.Source = null;
                scroll.Visibility = Visibility.Visible;
                code.Text = controller.GetRightPattern().Code;
            }
        }

        bool CheckVariant()
        {
            switch (controller.RightAnswer)
            {
                case 0:
                    if (variant1.IsChecked == true)
                        return true;
                    return false;
                case 1:
                    if (variant2.IsChecked == true)
                        return true;
                    return false;
                case 2:
                    if (variant3.IsChecked == true)
                        return true;
                    return false;
                case 3:
                    if (variant4.IsChecked == true)
                        return true;
                    return false;
                default:
                    return false;
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            start.Visibility = Visibility.Hidden;
            grid.Visibility = Visibility.Visible;
            controller = new Controller();
            controller.Start();
            controller.Next();
            SetVariants();
        }
    }
}
