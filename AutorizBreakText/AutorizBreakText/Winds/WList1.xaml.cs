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
using System.IO;

namespace AutorizBreakText.Winds
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class WList1 : Window
    {
        List<Person> personList = new List<Person>();


        string path1 = @"C:\Users\WSR\source\repos\AutorizBreakText\Rez1.txt";

        public WList1()
        {

            InitializeComponent();
            StreamReader sw = new StreamReader(path1);
            string Text = sw.ReadLine();
            string[] User = Text.Split('#');
            personList.Add(new Person {Lname = User[0],
                                       Fname = User[1],
                                         Age = Int32.Parse(User[2])
            });


            DtGrid1.ItemsSource = personList;


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            this.Close();

        }
    }
}
