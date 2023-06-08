using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBMSProjectApp
{
    public partial class DealerForm : Form
    {
        private NpgsqlConnection connect;
        private const string connectionString = "Server=localHost;port=5432;UserId=postgres;password=123456;database=BahcemDataBase";

        public DealerForm()
        {
            InitializeComponent();
            dataView.Visible = false;
            connect = new NpgsqlConnection(connectionString);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                connect.Open();

                if (DealerExists(int.Parse(textBoxID.Text)))
                {
                    ShowError("Dealer with the specified ID already exists.");
                    connect.Close();
                    return;
                }

                NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO dealers VALUES(@dealerid, @dealername, @dealercity, @dealeraddress)", connect);
                command1.Parameters.AddWithValue("@dealerid", int.Parse(textBoxID.Text));
                command1.Parameters.AddWithValue("@dealername", textBoxName.Text);
                command1.Parameters.AddWithValue("@dealercity", textBoxCity.Text);
                command1.Parameters.AddWithValue("@dealeraddress", textBoxAddress.Text);
                command1.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Dealer added successfully!");
                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while adding the dealer: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                connect.Open();

                if (!DealerExists(int.Parse(textBoxID.Text)))
                {
                    ShowError("Dealer with the specified ID does not exist.");
                    connect.Close();
                    return;
                }

                NpgsqlCommand command2 = new NpgsqlCommand("UPDATE dealers SET \"dealername\"=@dealername, \"dealercity\"=@dealercity, \"dealeraddress\"=@dealeraddress WHERE \"dealerid\"=@dealerid", connect);
                command2.Parameters.AddWithValue("@dealerid", int.Parse(textBoxID.Text));
                command2.Parameters.AddWithValue("@dealername", textBoxName.Text);
                command2.Parameters.AddWithValue("@dealercity", textBoxCity.Text);
                command2.Parameters.AddWithValue("@dealeraddress", textBoxAddress.Text);
                command2.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Dealer updated successfully!");
                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while updating the dealer: " + ex.Message);
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string query = "SELECT dealers.\"dealerid\", dealers.\"dealername\", dealers.\"dealercity\", dealers.\"dealeraddress\", managers.\"managername\" FROM dealers " +
                    "LEFT JOIN managers " +
                    "ON dealers.\"dealerid\" = managers.\"dealerid\" " +
                    "ORDER BY dealerid ASC ";
                NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connect);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                connect.Close();
                dataView.DataSource = ds.Tables[0];
                dataView.Visible = true;
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while retrieving dealer data: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxID.Text))
                {
                    ShowError("Please enter a valid dealer ID.");
                    return;
                }

                if (!int.TryParse(textBoxID.Text, out int dealerID))
                {
                    ShowError("Invalid dealer ID. Please enter a valid integer.");
                    return;
                }

                connect.Open();

                if (!DealerExists(dealerID))
                {
                    ShowError("Dealer with the specified ID does not exist.");
                    connect.Close();
                    return;
                }

                NpgsqlCommand command3 = new NpgsqlCommand("DELETE FROM dealers WHERE \"dealerid\" = @dealerid", connect);
                command3.Parameters.AddWithValue("@dealerid", dealerID);
                command3.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Dealer deleted successfully!");
                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while deleting the dealer: " + ex.Message);
            }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text) || string.IsNullOrWhiteSpace(textBoxName.Text)
                || string.IsNullOrWhiteSpace(textBoxCity.Text) || string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                ShowError("Please fill in all the fields.");
                return false;
            }

            if (!int.TryParse(textBoxID.Text, out int dealerID))
            {
                ShowError("Invalid dealer ID. Please enter a valid integer.");
                return false;
            }

            return true;
        }

        private bool DealerExists(int dealerID)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM dealers WHERE \"dealerid\" = @dealerid", connect);
            command.Parameters.AddWithValue("@dealerid", dealerID);
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DealerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
