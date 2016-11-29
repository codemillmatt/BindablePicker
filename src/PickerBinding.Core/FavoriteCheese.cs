using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PickerBinding.Core
{
	public class FavoriteCheese : INotifyPropertyChanged
	{
		Cheese _selectedCheese;
		public Cheese SelectedCheese
		{
			get
			{
				return _selectedCheese;
			}
			set
			{
				_selectedCheese = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedCheese"));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
