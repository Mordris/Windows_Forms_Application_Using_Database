using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBMSProjectApp
{
    public partial class ManagerForm : Form
    {
        private NpgsqlConnection connect;
        private const string connectionString = "Server=localHost;port=5432;UserId=postgres;password=123456;database=BahcemDataBase";

        public ManagerForm()
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
                NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO managers VALUES(@managerid, @managername, @managerage, @manageremail, " +
                    "@managercity, @managerphone, @managerdate, @dealerid)", connect);
                command1.Parameters.AddWithValue("@managerid", int.Parse(textBoxID.Text));
                command1.Parameters.AddWithValue("@managername", textBoxName.Text);
                command1.Parameters.AddWithValue("@managerage", int.Parse(numericAge.Text));
                command1.Parameters.AddWithValue("@manageremail", textBoxEmail.Text);
                command1.Parameters.AddWithValue("@managercity", textBoxCity.Text);
                command1.Parameters.AddWithValue("@managerphone", textBoxPhone.Text);
                command1.Parameters.AddWithValue("@managerdate", datePicker.Value);
                command1.Parameters.AddWithValue("@dealerid", int.Parse(textBoxDID.Text));
                command1.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Manager added successfully!");
                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while adding the manager: " + ex.Message);
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string query = "SELECT managers.\"managerid\", managers.\"managername\", managers.\"manageremail\", managers.\"managerage\", managers.\"managercity\"," +
                    " managers.\"managerphone\", managers.\"managerdate\", dealers.\"dealername\" FROM managers " +
                    " LEFT JOIN dealers " +
                    " ON managers.\"dealerid\" = dealers.\"dealerid\" " +
                    " ORDER BY managerid ASC ";
                NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connect);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                connect.Close();
                dataView.DataSource = ds.Tables[0];
                dataView.Visible = true;
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while retrieving manager data: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxID.Text))
                {
                    ShowError("Please enter a valid manager ID.");
                    return;
                }

                if (!int.TryParse(textBoxID.Text, out int managerID))
                {
                    ShowError("Invalid manager ID. Please enter a valid integer.");
                    return;
                }

                connect.Open();

                if (!ManagerExists(managerID))
                {
                    ShowError("Manager with the specified ID does not exist.");
                    connect.Close();
                    return;
                }

                NpgsqlCommand command3 = new NpgsqlCommand("DELETE FROM managers WHERE \"managerid\" = @managerid", connect);
                command3.Parameters.AddWithValue("@managerid", managerID);
                command3.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Manager deleted successfully!");
                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while deleting the manager: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                connect.Open();
                NpgsqlCommand command2 = new NpgsqlCommand("UPDATE managers SET \"managername\"=@managername, \"manageremail\"=@manageremail," +
                    "\"managerage\"=@managerage, \"managercity\"=@managercity, \"managerphone\"=@managerphone, \"managerdate\"=@managerdate, \"dealerid\"=@dealerid" +
                    " WHERE \"managerid\"=@managerid", connect);
                command2.Parameters.AddWithValue("@managerid", int.Parse(textBoxID.Text));
                command2.Parameters.AddWithValue("@managername", textBoxName.Text);
                command2.Parameters.AddWithValue("@manageremail", textBoxEmail.Text);
                command2.Parameters.AddWithValue("@managerage", int.Parse(numericAge.Text));
                command2.Parameters.AddWithValue("@managercity", textBoxCity.Text);
                command2.Parameters.AddWithValue("@managerphone", textBoxPhone.Text);
                command2.Parameters.AddWithValue("@managerdate", datePicker.Value);
                command2.Parameters.AddWithValue("@dealerid", int.Parse(textBoxDID.Text));
                command2.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Manager updated successfully!");
                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while updating the manager: " + ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            numericAge.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            datePicker.Value = DateTime.Now;
            textBoxDID.Text = string.Empty;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                ShowError("Please enter a valid manager ID.");
                return false;
            }

            if (!int.TryParse(textBoxID.Text, out _))
            {
                ShowError("Invalid manager ID. Please enter a valid integer.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                ShowError("Please enter a valid manager name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(numericAge.Text))
            {
                ShowError("Please enter a valid manager age.");
                return false;
            }

            if (!int.TryParse(numericAge.Text, out _))
            {
                ShowError("Invalid manager age. Please enter a valid integer.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                ShowError("Please enter a valid manager email.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxCity.Text))
            {
                ShowError("Please enter a valid manager city.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                ShowError("Please enter a valid manager phone number.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxDID.Text))
            {
                ShowError("Please enter a valid dealer ID.");
                return false;
            }

            if (!int.TryParse(textBoxDID.Text, out _))
            {
                ShowError("Invalid dealer ID. Please enter a valid integer.");
                return false;
            }

            return true;
        }

        private bool ManagerExists(int managerID)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM managers WHERE \"managerid\" = @managerid", connect);
            command.Parameters.AddWithValue("@managerid", managerID);
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
