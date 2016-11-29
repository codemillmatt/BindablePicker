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
				// Just hard code the cheese to set - see it change everywhere
				_vm.SelectedCheese = Cheese.All[1];
            };

            addButton.Clicked += (sender, e) =>
            {
                Cheese.All.Add(new Cheese { CheeseName = "New" });
            };
        }
    }
}
