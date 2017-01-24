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
        Controller controller;
        public MainWindow()
        {
            controller = Controller.GetInstance();
            InitializeComponent();

			UpdateInfo();
		}

		internal void UpdateInfo() {
			count.Content = controller.PersonCount;
			index.Content = controller.PersonIndex;

			textBox_firstname.Text = controller.CurentPerson.FirstName;
			textBox_lastname.Text = controller.CurentPerson.LastName;
			textBox_age.Text = controller.CurentPerson.Age + "";
			textBox_telnr.Text = controller.CurentPerson.TelephoneNr;
		}

		private void button_new_Click(object sender, RoutedEventArgs e) {
			//int age;
			//int.TryParse(textBox_age.Text, out age); // Should be done in the controller...

			//controller.CurentPerson.FirstName = textBox_firstname.Text;
			//controller.CurentPerson.LastName = textBox_lastname.Text;
			//controller.CurentPerson.Age = age;
			//controller.CurentPerson.TelephoneNr = textBox_telnr.Text;

			//controller.AddPerson();
			//UpdateInfo();

			// Pop up the new window here...
			AddPerson APwindow = new AddPerson();
			APwindow.Show();
			APwindow.GiveThis(this);
		}

		private void button_delete_Click(object sender, RoutedEventArgs e) {
			controller.DeletePerson();
			UpdateInfo();
		}

		private void button_up_Click(object sender, RoutedEventArgs e) {
			controller.NextPerson();
			UpdateInfo();
		}

		private void button_down_Click(object sender, RoutedEventArgs e) {
			controller.PrevPerson();
			UpdateInfo();
		}
	}
}
