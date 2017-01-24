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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controler controler;
        public MainWindow()
        {
            controler = Controler.GetInstance();
            InitializeComponent();

			UpdateInfo();
		}

		private void UpdateInfo() {
			count.Content = controler.PersonCount;
			index.Content = controler.PersonIndex;

			textBox_firstname.Text = controler.CurentPerson.FirstName;
			textBox_lastname.Text = controler.CurentPerson.LastName;
			textBox_age.Text = controler.CurentPerson.Age + "";
			textBox_telnr.Text = controler.CurentPerson.TelephoneNr;
		}

		private void button_new_Click(object sender, RoutedEventArgs e) {
			int age;
			int.TryParse(textBox_age.Text, out age);

			controler.CurentPerson.FirstName = textBox_firstname.Text;
			controler.CurentPerson.LastName = textBox_lastname.Text;
			controler.CurentPerson.Age = age;
			controler.CurentPerson.TelephoneNr = textBox_telnr.Text;

			controler.AddPerson();
			UpdateInfo();
		}

		private void button_delete_Click(object sender, RoutedEventArgs e) {
			controler.DeletePerson();
			UpdateInfo();
		}

		private void button_up_Click(object sender, RoutedEventArgs e) {
			controler.NextPerson();
			UpdateInfo();
		}

		private void button_down_Click(object sender, RoutedEventArgs e) {
			controler.PrevPerson();
			UpdateInfo();
		}
	}
}
