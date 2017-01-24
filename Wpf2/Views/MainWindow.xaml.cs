using System.Windows;

namespace Wpf2 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		Controller controller;
		public MainWindow() {
			controller = Controller.GetInstance();
			InitializeComponent();

			UpdateInfo();
		}

		private void UpdateInfo() {
			count.Content = controller.PersonCount;
			index.Content = controller.PersonIndex;

			textBox_firstname.Text = controller.CurentPerson.FirstName;
			textBox_lastname.Text = controller.CurentPerson.LastName;
			textBox_age.Text = controller.CurentPerson.Age + "";
			textBox_telnr.Text = controller.CurentPerson.TelephoneNr;
		}

		private void button_new_Click(object sender, RoutedEventArgs e) {
			//int age;
			//int.TryParse(textBox_age.Text, out age);	// Should be in the controller...

			//controler.CurentPerson.FirstName = textBox_firstname.Text;
			//controler.CurentPerson.LastName = textBox_lastname.Text;
			//controler.CurentPerson.Age = age;
			//controler.CurentPerson.TelephoneNr = textBox_telnr.Text;

			//controler.AddPerson();
			//UpdateInfo();
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
