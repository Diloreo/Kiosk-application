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

namespace finalprojectnew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="D:\SQL databases\kioskdb.mdf";Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM order_table";

           
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry, conString);
                DataSet ds = new DataSet();

                da.Fill(ds, "order_table");
                dgv1.DataSource = ds.Tables["Customer_order_table"];

            }
            catch (SqlException e)
            {
                MessageBox.Show("Error occured. Error details: "+ e.ToString());
            }
         
          
        }

    }
}
