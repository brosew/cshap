using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class customer_entities : Form
    {
        public customer_entities()
        {
            InitializeComponent();
        }
        INVOICE_CSHARPEntities edm = new INVOICE_CSHARPEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            var cs = from t in edm.CUSTOMER
                     select t;
            dataGridView1.DataSource = cs.ToList();
                    }
        
    }
}
