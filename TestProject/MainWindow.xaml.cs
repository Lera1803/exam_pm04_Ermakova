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

namespace TestProject
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

        private void textBoxName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Za-яА-Я\\s]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        

        private void textBoxSurname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Za-яА-Я\\s]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void textBoxTelephone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text[0]) && e.Text[0] != '+' && e.Text[0] != '-';
        }
        private void checkButton_Click(object sender, RoutedEventArgs e)
        {

            bool correct = Class1.Validation(textBoxName.Text, textBoxSurname.Text, textBoxTelephone.Text);
            if (correct)
            {
                MessageBox.Show("Данные введены верно!");
            }
            else
                MessageBox.Show("Данные введены неверно!");
        }
    }
}

