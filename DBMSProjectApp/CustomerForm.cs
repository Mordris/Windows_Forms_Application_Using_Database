using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBMSProjectApp
{
    public partial class CustomerForm : Form
    {
        private readonly string connectionString = "Server=localHost;port=5432;UserId=postgres;password=123456;database=BahcemDataBase";
        private NpgsqlConnection connect;

        public CustomerForm()
        {
            InitializeComponent();
            dataView.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int custId = ParseCustomerId();
                if (custId == -1)
                    return;

                string nameInput = GetTrimmedValue(textBoxName);
                if (string.IsNullOrEmpty(nameInput))
                {
                    ShowError("Please enter a valid customer name.");
                    return;
                }

                string emailInput = GetTrimmedValue(textBoxEmail);
                if (string.IsNullOrEmpty(emailInput))
                {
                    ShowError("Please enter a valid customer email.");
                    return;
                }

                int custAge = ParseCustomerAge();
                if (custAge == -1)
                    return;

                string cityInput = GetTrimmedValue(textBoxCity);
                if (string.IsNullOrEmpty(cityInput))
                {
                    ShowError("Please enter a valid customer city.");
                    return;
                }

                string phoneInput = GetTrimmedValue(textBoxPhone);
                if (string.IsNullOrEmpty(phoneInput))
                {
                    ShowError("Please enter a valid customer phone number.");
                    return;
                }

                if (DoesCustomerExist(custId))
                {
                    MessageBox.Show("Customer with the specified ID already exists.");
                    return;
                }

                using (NpgsqlConnection connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    using (NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO customers VALUES (@custid, @custname, @custemail, @custage, @custcity, @custphone, @custjoindate)", connect))
                    {
                        command1.Parameters.AddWithValue("@custid", custId);
                        command1.Parameters.AddWithValue("@custname", nameInput);
                        command1.Parameters.AddWithValue("@custemail", emailInput);
                        command1.Parameters.AddWithValue("@custage", custAge);
                        command1.Parameters.AddWithValue("@custcity", cityInput);
                        command1.Parameters.AddWithValue("@custphone", phoneInput);
                        command1.Parameters.AddWithValue("@custjoindate", dateTimePicker.Value);
                        command1.ExecuteNonQuery();
                    }

                    MessageBox.Show("Customer added successfully!");
                }

                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while adding the customer: " + ex.Message);
            }
        }


        private int ParseCustomerId()
        {
            string idInput = GetTrimmedValue(textBoxID);
            if (string.IsNullOrEmpty(idInput))
            {
                ShowError("Please enter a valid customer ID.");
                return -1;
            }

            if (!int.TryParse(idInput, out int custId))
            {
                ShowError("Invalid customer ID. Please enter a numeric value.");
                return -1;
            }

            return custId;
        }

        private int ParseCustomerAge()
        {
            string ageInput = GetTrimmedValue(numericAge);
            if (!int.TryParse(ageInput, out int custAge))
            {
                ShowError("Invalid customer age. Please enter a numeric value.");
                return -1;
            }

            return custAge;
        }

        private string GetTrimmedValue(Control control)
        {
            return control.Text.Trim();
        }

        private void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool DoesCustomerExist(int customerId)
        {
            using (connect = new NpgsqlConnection(connectionString))
            {
                connect.Open();

                NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM customers WHERE \"custid\" = @custid", connect);
                command.Parameters.AddWithValue("@custid", customerId);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int custId = ParseCustomerId();
                if (custId == -1)
                    return;

                string nameInput = GetTrimmedValue(textBoxName);
                if (string.IsNullOrEmpty(nameInput))
                {
                    ShowError("Please enter a valid customer name.");
                    return;
                }

                string emailInput = GetTrimmedValue(textBoxEmail);
                if (string.IsNullOrEmpty(emailInput))
                {
                    ShowError("Please enter a valid customer email.");
                    return;
                }

                int custAge = ParseCustomerAge();
                if (custAge == -1)
                    return;

                string cityInput = GetTrimmedValue(textBoxCity);
                if (string.IsNullOrEmpty(cityInput))
                {
                    ShowError("Please enter a valid customer city.");
                    return;
                }

                string phoneInput = GetTrimmedValue(textBoxPhone);
                if (string.IsNullOrEmpty(phoneInput))
                {
                    ShowError("Please enter a valid customer phone number.");
                    return;
                }

                using (connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    if (!DoesCustomerExist(custId))
                    {
                        MessageBox.Show("Customer with the specified ID does not exist.");
                        return;
                    }

                    NpgsqlCommand command2 = new NpgsqlCommand("UPDATE customers SET \"custname\"=@custname,\"custemail\"=@custemail," +
                        "\"custage\"=@custage, \"custcity\"=@custcity, \"custphone\"=@custphone, \"custjoindate\"=@custjoindate WHERE \"custid\"=@custid", connect);

                    command2.Parameters.AddWithValue("@custid", custId);
                    command2.Parameters.AddWithValue("@custname", nameInput);
                    command2.Parameters.AddWithValue("@custemail", emailInput);
                    command2.Parameters.AddWithValue("@custage", custAge);
                    command2.Parameters.AddWithValue("@custcity", cityInput);
                    command2.Parameters.AddWithValue("@custphone", phoneInput);
                    command2.Parameters.AddWithValue("@custjoindate", dateTimePicker.Value);
                    command2.ExecuteNonQuery();
                }

                MessageBox.Show("Customer updated successfully!");
                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while updating the customer: " + ex.Message);
            }
        }


        private void buttonView_Click(object sender, EventArgs e)
        {
            try
            {
                using (connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "SELECT * FROM customers ORDER BY custid ASC";
                    NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connect);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);

                    dataView.DataSource = ds.Tables[0];
                    dataView.Visible = true;
                }
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while retrieving customer data: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int custId = ParseCustomerId();
                if (custId == -1)
                    return;

                using (connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    if (!DoesCustomerExist(custId))
                    {
                        MessageBox.Show("Customer with the specified ID does not exist.");
                        return;
                    }

                    NpgsqlCommand command3 = new NpgsqlCommand("DELETE FROM customers WHERE \"custid\" = @custid", connect);
                    command3.Parameters.AddWithValue("@custid", custId);
                    command3.ExecuteNonQuery();
                }

                MessageBox.Show("Customer deleted successfully!");
                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while deleting the customer: " + ex.Message);
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
            dateTimePicker.Value = DateTime.Now;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
