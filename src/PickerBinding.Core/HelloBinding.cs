//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PickerBinding.Core
//{
//    public class HelloBinding
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public int Id { get; set; }

//        public override string ToString()
//        {
//            return FirstName;
//        }
//    }

//    public class HelloWorld
//    {
//        public string IAmTheWorld { get; set; }
//        public List<HelloBinding> HelloToAllMyBindings { get; set; }

//        HelloBinding _hb; 
//        public HelloBinding SelectedHBBinding
//        {
//            get
//            { return _hb; }
//            set
//            {
//                _hb = value;
//            }
//        }
//    }
//}
