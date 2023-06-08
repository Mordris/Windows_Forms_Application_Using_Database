using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBMSProjectApp
{
    public partial class ToolForm : Form
    {
        NpgsqlConnection connect = new NpgsqlConnection("Server=localHost;port=5432;UserId=postgres;password=123456;database=BahcemDataBase");

        public ToolForm()
        {
            InitializeComponent();
            dataView.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int toolId;
            if (!int.TryParse(textBoxID.Text, out toolId))
            {
                MessageBox.Show("Invalid Tool ID. Please enter a valid integer value for Tool ID.");
                return;
            }

            if (IsToolIdExists(toolId))
            {
                MessageBox.Show("Tool ID already exists. Please enter a unique Tool ID.");
                return;
            }

            string toolName = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(toolName))
            {
                MessageBox.Show("Tool Name cannot be empty. Please enter a valid Tool Name.");
                return;
            }

            int toolCount;
            if (!int.TryParse(numericCount.Text, out toolCount))
            {
                MessageBox.Show("Invalid Tool Count. Please enter a valid integer value for Tool Count.");
                return;
            }

            connect.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("insert into tools values (@toolid, @toolname, @toolcount, @dealerid)", connect);
            command1.Parameters.AddWithValue("@toolid", toolId);
            command1.Parameters.AddWithValue("@toolname", toolName);
            command1.Parameters.AddWithValue("@toolcount", toolCount);
            command1.Parameters.AddWithValue("@dealerid", int.Parse(textBoxDID.Text));
            command1.ExecuteNonQuery();

            connect.Close();
            MessageBox.Show("Tool added successfully!");
            buttonView_Click(sender, EventArgs.Empty);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            dataView.Visible = true;
            string query = "select tools.toolid, tools.toolname, tools.toolcount, dealers.dealername from tools " +
                "left join dealers on tools.dealerid = dealers.dealerid";
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connect.Close();
            dataView.DataSource = ds.Tables[0];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int toolId;
            if (!int.TryParse(textBoxID.Text, out toolId))
            {
                MessageBox.Show("Invalid Tool ID. Please enter a valid integer value for Tool ID.");
                return;
            }

            if (!IsToolIdExists(toolId))
            {
                MessageBox.Show("Tool ID does not exist. Please enter a valid Tool ID.");
                return;
            }

            string toolName = textBoxName.Text;
            if (string.IsNullOrWhiteSpace(toolName))
            {
                MessageBox.Show("Tool Name is required. Please enter a valid Tool Name.");
                return;
            }

            int toolCount;
            if (!int.TryParse(numericCount.Text, out toolCount) || toolCount <= 0)
            {
                MessageBox.Show("Invalid Tool Count. Please enter a valid integer value greater than 0 for Tool Count.");
                return;
            }

            int dealerId;
            if (!int.TryParse(textBoxDID.Text, out dealerId) || dealerId <= 0)
            {
                MessageBox.Show("Invalid Dealer ID. Please enter a valid integer value greater than 0 for Dealer ID.");
                return;
            }

            connect.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("update tools set toolname = @toolname, toolcount = @toolcount, dealerid = @dealerid where toolid = @toolid", connect);
            command2.Parameters.AddWithValue("@toolid", toolId);
            command2.Parameters.AddWithValue("@toolname", toolName);
            command2.Parameters.AddWithValue("@toolcount", toolCount);
            command2.Parameters.AddWithValue("@dealerid", dealerId);
            command2.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Tool updated successfully!");
            buttonView_Click(sender, EventArgs.Empty);
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int toolId;
            if (!int.TryParse(textBoxID.Text, out toolId))
            {
                MessageBox.Show("Invalid Tool ID. Please enter a valid integer value for Tool ID.");
                return;
            }

            if (!IsToolIdExists(toolId))
            {
                MessageBox.Show("Tool ID does not exist. Please enter a valid Tool ID.");
                return;
            }

            connect.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("delete from tools where toolid = @toolid", connect);
            command3.Parameters.AddWithValue("@toolid", toolId);
            command3.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Tool deleted successfully!");
            buttonView_Click(sender, EventArgs.Empty);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            numericCount.Text = string.Empty;
            textBoxDID.Text = string.Empty;
        }

        private bool IsToolIdExists(int toolId)
        {
            connect.Open();
            NpgsqlCommand command = new NpgsqlCommand("select count(*) from tools where toolid = @toolid", connect);
            command.Parameters.AddWithValue("@toolid", toolId);
            int count = Convert.ToInt32(command.ExecuteScalar());
            connect.Close();

            return count > 0;
        }
    }
}
