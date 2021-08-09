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
  
    public partial class Customer_tab : Form
    {
       
        public Customer_tab()
        {
            InitializeComponent();
        }
        String Strconnect = @"Data Source=127.0.0.1;Initial Catalog=INVOICE_CSHARP;User ID=sa;Password=1234";
        SqlConnection conn;
        DataSet data = new DataSet();
        DataSet data_ty = new DataSet();
        DataView dtv = new DataView();
        private void Customer_tab_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Strconnect);
            customer_type();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(Strconnect);
            new_call();
        }

        private void cal()
        {
            int cnt_1 = 0;
               foreach (DataGridViewRow s in grw.Rows)
            {
                cnt_1 += 1;
            }

            TDAY.Text = cnt_1.ToString("n0") + " รายการ";
        }
        private void customer_type()
        {
            String sql = "SELECT";
            sql += " CUSTY_ID,CUSTY_CODE,CUSTY_NAME";
            sql += " FROM";
            sql += " (SELECT 0 AS CUSTY_ID,'*' AS CUSTY_CODE,'(ทั้งหมด)' AS CUSTY_NAME FROM CUSTOMER_TYPE";
            sql += " UNION";
            sql += " SELECT CUSTY_ID,CUSTY_CODE,CUSTY_NAME";
            sql += " FROM CUSTOMER_TYPE) AS CUSTOMER_TYPE";
            sql += " ORDER BY CUSTY_CODE";
            SqlCommand cmd_print = new SqlCommand(sql, conn);
            SqlDataAdapter adapter_print = new SqlDataAdapter(cmd_print);
            adapter_print.Fill(data_ty, "CUSTY");
            if (data_ty.Tables["CUSTY"].Rows.Count > 0)
            {
                comboBox1.DataSource = data_ty.Tables["CUSTY"];
                comboBox1.DisplayMember = "CUSTY_NAME";
                comboBox1.ValueMember = "CUSTY_ID";
            }
                   }

        private void new_call()
        {
            data.Clear();
            String sql = "SELECT";
            sql += " CUS_ID,CUS_CODE,CUS_NAME,CUS_BRANCH,CUS_TEL,CUS_FAX,CUS_CAT";
            sql += " FROM CUSTOMER";
            if (comboBox1.SelectedIndex > 0)  //'รายการแรก 0 คือเลือกทั้งหมด
            {
                sql += " WHERE";
                sql += " CUS_CAT=" + comboBox1.SelectedValue;
            }
            sql += " ORDER BY CUS_CODE,CUS_NAME";
            SqlCommand cmd_print = new SqlCommand(sql, conn);
            SqlDataAdapter adapter_print = new SqlDataAdapter(cmd_print);
            adapter_print.Fill(data, "DOC");
            if (data.Tables["DOC"].Rows.Count > 0)
            {
                dtv = data.Tables["DOC"].AsDataView();
                grw.DataSource = dtv;
            }
            cal();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            new_call();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void listh_search_TextChanged(object sender, EventArgs e)
        {
            dtv.RowFilter = "[CUS_CODE] Like " + "'%" + listh_search.Text + "%' OR [CUS_NAME] Like " + "'%" + listh_search.Text + "%'";
            dtv.Sort = String.Empty;
            cal();
        }

        private void listh_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                listh_search.Text = "";
                dtv.RowFilter = "";
                cal();
            }
          }
    }
}
