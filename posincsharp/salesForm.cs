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
    public partial class salesForm : Form
    {
        public String idtouse = "";
        public MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=pos;SslMode=none; Allow Zero Datetime=true;");

        public salesForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (idtouse != "")
            {
                String addquery = "Update sales set month = @name, year = @info, income = @price where id = @id";
                MySqlCommand addcmd = new MySqlCommand(addquery, conn);
                addcmd.Parameters.AddWithValue("@id", idtouse);
                addcmd.Parameters.AddWithValue("@name", month.Text);
                addcmd.Parameters.AddWithValue("@info", year.Text);
                addcmd.Parameters.AddWithValue("@price", income.Text);

                conn.Open();
                addcmd.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
            else
            {
                String addquery = "insert into sales(month, year, income) values(@name, @info, @price)";
                MySqlCommand addcmd = new MySqlCommand(addquery, conn);
                addcmd.Parameters.AddWithValue("@name", month.Text);
                addcmd.Parameters.AddWithValue("@info", year.Text);
                addcmd.Parameters.AddWithValue("@price", income.Text);

                conn.Open();
                addcmd.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            if (idtouse != "")
            {
                String query = "select * from sales where id = @id";

                MySqlCommand command2 = new MySqlCommand(query, conn);
                conn.Open();

                command2.Parameters.AddWithValue("@id", idtouse);

                MySqlDataReader reader = command2.ExecuteReader();

                while (reader.Read())
                {
                    month.Text = reader[1].ToString();
                    year.Text = reader[2].ToString();
                    income.Text = reader[3].ToString();
                }
                conn.Close();
            }
        }
    }
}
