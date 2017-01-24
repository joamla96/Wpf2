using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2 {
	class AddPersonVM {
		private static AddPersonVM instance;
		private Repository repository;
		public Person CurentPerson { get; private set; }

		private AddPersonVM() {
			CurentPerson = new Person();
			repository = new Repository();
		}

		public static AddPersonVM GetInstance() {
			if (instance == null) {
				instance = new AddPersonVM();
			}
			return instance;
		}


	}
}
