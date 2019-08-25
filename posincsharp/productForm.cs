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
    public partial class productForm : Form
    {
        public String idtouse = "";
        public MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pos;SslMode=none; Allow Zero Datetime=true;");


        public productForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (idtouse != "")
            {
                String addquery = "Update products set productName = @name, productInfo = @info, productPrice = @price where id = @id";
                MySqlCommand addcmd = new MySqlCommand(addquery, conn);
                addcmd.Parameters.AddWithValue("@id", idtouse);
                addcmd.Parameters.AddWithValue("@name", productName.Text);
                addcmd.Parameters.AddWithValue("@info", productInfo.Text);
                addcmd.Parameters.AddWithValue("@price", productPrice.Text);

                conn.Open();
                addcmd.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
            else
            {
                String addquery = "insert into products(productName, productInfo, productPrice) values(@name, @info, @price)";
                MySqlCommand addcmd = new MySqlCommand(addquery, conn);
                addcmd.Parameters.AddWithValue("@name", productName.Text);
                addcmd.Parameters.AddWithValue("@info", productInfo.Text);
                addcmd.Parameters.AddWithValue("@price", productPrice.Text);

                conn.Open();
                addcmd.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (idtouse != "")
            {
                String query = "select * from products where id = @id";

                MySqlCommand command2 = new MySqlCommand(query, conn);
                conn.Open();

                command2.Parameters.AddWithValue("@id", idtouse);

                MySqlDataReader reader = command2.ExecuteReader();

                while (reader.Read())
                {
                    productName.Text = reader[1].ToString();
                    productInfo.Text = reader[2].ToString();
                    productPrice.Text = reader[3].ToString();
                }
                conn.Close();
            }
        }
    }
}
