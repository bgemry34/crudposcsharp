using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace posincsharp
{
    public partial class posmain : Form
    {
        public MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pos;SslMode=none; Allow Zero Datetime=true;");
        public string table = "";
        public string idselected = "";

        public posmain()
        {
            InitializeComponent();
        }

        private void ShowProducts_Click(object sender, EventArgs e)
        {
            table = "products";
            String query = "select * from products order by id desc";

            MySqlCommand command2 = new MySqlCommand(query, conn);
            conn.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Product id");
            dataGridView1.Columns.Add("prorductName", "Product Name");
            dataGridView1.Columns.Add("productInfo", "Product Info");
            dataGridView1.Columns.Add("productPrice", "Product price");


            dataGridView1.Columns[0].HeaderText = "Product ID";
            dataGridView1.Columns[1].HeaderText = "Product Name";
            dataGridView1.Columns[2].HeaderText = "Product Info";
            dataGridView1.Columns[3].HeaderText = "Product Price";
            MySqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(new String[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()});
                }
            }
            conn.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if(table == "products")
            {
                using(var prodForm = new productForm())
                {
                    prodForm.ShowDialog();
                }
            }

            if (table == "sales")
            {
                using (var salesform = new salesForm())
                {
                    salesform.ShowDialog();
                }
            }

            if (table == "receipts")
            {
                using (var resibo = new receiptForm())
                {
                    resibo.ShowDialog();
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idselected = this.dataGridView1[0, e.RowIndex].Value.ToString();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (idselected != "" && table == "products"){
                using(var editform = new productForm())
                {
                    editform.idtouse = idselected;
                    editform.ShowDialog();
                }
            }

            if (idselected != "" && table == "sales")
            {
                using (var sales = new salesForm())
                {
                    sales.idtouse = idselected;
                    sales.ShowDialog();
                }
            }

            if (idselected != "" && table == "receipts")
            {
                using (var resibo = new receiptForm())
                {
                    resibo.idtouse = idselected;
                    resibo.ShowDialog();
                }
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You wanna Delete this product?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String addquery = "Delete from "+ table + " where id = @id";
                MySqlCommand addcmd = new MySqlCommand(addquery, conn);
                conn.Open();
                addcmd.Parameters.AddWithValue("@id", idselected);
                addcmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("deleted succezzfully");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            table = "products";
            String query = "select * from products where productName like '%"+ toSearch.Text + "%'";

            MySqlCommand command2 = new MySqlCommand(query, conn);;

            conn.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Product id");
            dataGridView1.Columns.Add("prorductName", "Product Name");
            dataGridView1.Columns.Add("productInfo", "Product Info");
            dataGridView1.Columns.Add("productPrice", "Product price");


            dataGridView1.Columns[0].HeaderText = "Product ID";
            dataGridView1.Columns[1].HeaderText = "Product Name";
            dataGridView1.Columns[2].HeaderText = "Product Info";
            dataGridView1.Columns[3].HeaderText = "Product Price";
            MySqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(new String[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() });
                }
            }
            conn.Close();
        }

        private void ShowSales_Click(object sender, EventArgs e)
        {
            table = "sales";
            String query = "select * from sales order by id desc";

            MySqlCommand command2 = new MySqlCommand(query, conn);
            conn.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Sales id");
            dataGridView1.Columns.Add("Month", "Month");
            dataGridView1.Columns.Add("Year", "Year");
            dataGridView1.Columns.Add("Income", "Income");


            dataGridView1.Columns[0].HeaderText = "Sales ID";
            dataGridView1.Columns[1].HeaderText = "Month";
            dataGridView1.Columns[2].HeaderText = "Year";
            dataGridView1.Columns[3].HeaderText = "Income";
            MySqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(new String[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() });
                }
            }
            conn.Close();
        }

        private void ShowReceipts_Click(object sender, EventArgs e)
        {
            table = "receipts";
            String query = "select * from receipts order by id desc";

            MySqlCommand command2 = new MySqlCommand(query, conn);
            conn.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("item_id", "item_id");
            dataGridView1.Columns.Add("qty", "qty");
            dataGridView1.Columns.Add("datemy", "datecreate");


            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "item_id";
            dataGridView1.Columns[2].HeaderText = "qty";
            dataGridView1.Columns[2].HeaderText = "date";
                
            MySqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(new String[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() });
                }
            }
            conn.Close();
        }

        private void Logs_Click(object sender, EventArgs e)
        {
            table = "logs";
            String query = "select * from logs order by id desc";

            MySqlCommand command2 = new MySqlCommand(query, conn);
            conn.Open();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("item_id", "item_id");
            dataGridView1.Columns.Add("qty", "qty");


            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "user_id";
            dataGridView1.Columns[2].HeaderText = "date created";
            dataGridView1.Columns[2].HeaderText = "action";

            MySqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(new String[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() });
                }
            }
            conn.Close();
        }
    }
}
