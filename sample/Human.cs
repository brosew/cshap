using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public class Person
    {
        public void speak()
        {
            MessageBox.Show("Person พูด");
        }
        public void walk()
        {
            MessageBox.Show("Person เดิน");
        }
    }

    public class Programmer : Person
    {
               public void Programming()
        {
            MessageBox.Show("Programming เขียนโปรแกรม");
        }
    }
}
