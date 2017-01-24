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

namespace Wpf2 {
	/// <summary>
	/// Interaction logic for AddPerson.xaml
	/// </summary>
	public partial class AddPerson : Window {
		Controller controller;
		MainWindow MainWindow;
		public AddPerson() {
			controller = Controller.GetInstance();
			InitializeComponent();
		}

		public void GiveThis(MainWindow mw) {
			MainWindow = mw;
		}

		private void button_save_Click(object sender, RoutedEventArgs e) {
			int age;
			int.TryParse(textBox_age.Text, out age); // Should be done in the controller...

			controller.CurentPerson.FirstName = textBox_firstname.Text;
			controller.CurentPerson.LastName = textBox_lastname.Text;
			controller.CurentPerson.Age = age;
			controller.CurentPerson.TelephoneNr = textBox_telnr.Text;

			controller.AddPerson();
			MainWindow.UpdateInfo();
			this.Close();
		}

		private void button_cancel_Click(object sender, RoutedEventArgs e) {
			this.Close();
		}
	}
}
