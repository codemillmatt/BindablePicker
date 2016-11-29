using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickerBinding.Core
{
    public class Cheese
    {
        public string CheeseName { get; set; }
        public string Dairy { get; set; }
        public CheeseTypes Type { get; set; }
        public int Id { get; set; }

        static List<Cheese> _allCheeses;
        public static List<Cheese> All
        {
            get
            {
                if (_allCheeses == null)
                {
                    _allCheeses = new List<Cheese>
                    {
                        new Cheese { CheeseName="Little Boy Blue", Dairy="Hooks", Id=1, Type=CheeseTypes.Blue },
                        new Cheese { CheeseName="10 year", Dairy="Hooks",Id=2, Type=CheeseTypes.Cheddar },
                        new Cheese { CheeseName="Yellow Curds", Dairy="Murphs", Type=CheeseTypes.Curds },
                        new Cheese { CheeseName="St Jenifer", Dairy="Creme de la Coule", Type=CheeseTypes.Farmstead }
                    };
                }

                return _allCheeses;
            }
        }
    }

    public enum CheeseTypes
    {
        Cheddar,
        Swiss,
        Blue,
        Farmstead,
        Curds
    }
}
