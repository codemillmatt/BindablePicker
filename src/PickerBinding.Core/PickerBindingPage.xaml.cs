using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PickerBinding.Core
{
    public partial class PickerBindingPage : ContentPage
    {
        FavoriteCheese _vm = new FavoriteCheese();
        public PickerBindingPage()
        {
            InitializeComponent();

            BindingContext = _vm;

            changeButton.Clicked += (sender, e) =>
            {
				//thePicker.SelectedItem = _vm.AllPossibleCheeses[1];
				_vm.SelectedCheese = Cheese.All[1];
            };

            addButton.Clicked += (sender, e) =>
            {
				//_vm.AllPossibleCheeses.Add(new Cheese { CheeseName = "new" });
				var c = _vm.SelectedCheese;
                //thePicker.ItemsSource.Insert(1, new Cheese { CheeseName = "asdf" });
                Cheese.All.Add(new Cheese { CheeseName = "New" });
            };
        }
    }
}
