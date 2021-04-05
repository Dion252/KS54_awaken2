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
using System.IO;
using AutorizBreakText.Winds;

namespace AutorizBreakText
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string path1 = @"C:\Users\WSR\source\repos\AutorizBreakText\Rez1.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ClPerson()
        { 
            
        }


        private void FirstName_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            int fn;
            if (int.TryParse(e.Text, out fn))
            {
                e.Handled = true;
            }
        }

        private void LastName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int ln;
            if (int.TryParse(e.Text, out ln))
            {
                e.Handled = true;
            }
        }

        private void AgeName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int ag;
            if (!int.TryParse(e.Text, out ag))
            {
                e.Handled = true;
            }
        }

        private void AutorizBtn1_Click(object sender, RoutedEventArgs e)
        {
            string text = LastName.Text + "#" + FirstName.Text + "#" + AgeName.Text;

            using (StreamWriter sw = new StreamWriter(path1))
            {
                sw.WriteLine(text);
            }
        }

        private void UserList1_Click(object sender, RoutedEventArgs e)
        {
           
            WList1 NewList = new WList1();
            //this.Hide();
            NewList.ShowDialog();
            this.Show();

        }
    }
}
