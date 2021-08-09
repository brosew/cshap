using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sample
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //cnn_sql_main = SqlConnection;
        //Friend db_str As String = "Data Source=127.0.0.1;Initial Catalog=invoice;User ID=sa;Password=1234"
          private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Customer_tab f = new Customer_tab();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            customer_entities f = new customer_entities();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}
