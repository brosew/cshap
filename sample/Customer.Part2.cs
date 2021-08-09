using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    public partial class Customer_partial
    {
        private string _Address;
          public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
    }
}
