using System.Windows;

namespace Wpf2.Views {
	/// <summary>
	/// Interaction logic for AddPerson.xaml
	/// </summary>
	public partial class AddPerson : Window {
		AddPersonVM Controller;
		public AddPerson() {
			Controller = AddPersonVM.GetInstance();
			InitializeComponent();
		}

		private void button_cancel_Click(object sender, RoutedEventArgs e) {

		}

		private void button_ok_Click(object sender, RoutedEventArgs e) {

		}
	}
}
