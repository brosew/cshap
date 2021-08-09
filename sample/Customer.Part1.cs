using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    public partial class Customer_partial
    {
        private string _FistName;
        private string _LastName;

        public string FistName
        {
            get
            {
                return _FistName;
            }
            set
            {
                _FistName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
    }
}
