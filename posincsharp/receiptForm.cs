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
    public partial class receiptForm : Form
    {
        public String idtouse = "";
        public MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pos;SslMode=none; Allow Zero Datetime=true;");

        public receiptForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (idtouse != "")
            {
                String addquery = "Update receipts set product_id = @name, qty = @info where id = @id";
                MySqlCommand addcmd = new MySqlCommand(addquery, conn);
                addcmd.Parameters.AddWithValue("@id", idtouse);
                addcmd.Parameters.AddWithValue("@name", productid.Text);
                addcmd.Parameters.AddWithValue("@info", qty.Text);

                conn.Open();
                addcmd.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
            else
            {
                String addquery = "insert into receipts(product_id, qty) values(@name, @info)";
                MySqlCommand addcmd = new MySqlCommand(addquery, conn);
                addcmd.Parameters.AddWithValue("@name", productid.Text);
                addcmd.Parameters.AddWithValue("@info", qty.Text);

                conn.Open();
                addcmd.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Income_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Month_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            if (idtouse != "")
            {
                String query = "select * from receipts where id = @id";

                MySqlCommand command2 = new MySqlCommand(query, conn);
                conn.Open();

                command2.Parameters.AddWithValue("@id", idtouse);

                MySqlDataReader reader = command2.ExecuteReader();

                while (reader.Read())
                {
                    productid.Text = reader[1].ToString();
                    qty.Text = reader[2].ToString();
                }
                conn.Close();
            }
        }
    }
}
