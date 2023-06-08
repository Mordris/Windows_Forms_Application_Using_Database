using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProjectApp
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
            dataView.Visible = false;
        }

        NpgsqlConnection connect = new NpgsqlConnection("Server=localHost;port=5432;UserId=postgres;" +
            "password=123456;database=BahcemDataBase");

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int workerId;
            if (!int.TryParse(textBoxID.Text, out workerId))
            {
                MessageBox.Show("Invalid Worker ID. Please enter a valid integer value for Worker ID.");
                return;
            }

            if (IsWorkerIdExists(workerId))
            {
                MessageBox.Show("Worker ID already exists. Please enter a unique Worker ID.");
                return;
            }

            string workerName = textBoxName.Text;
            if (string.IsNullOrWhiteSpace(workerName))
            {
                MessageBox.Show("Worker Name is required. Please enter a valid Worker Name.");
                return;
            }

            string workerEmail = textBoxEmail.Text;
            if (!IsValidEmail(workerEmail))
            {
                MessageBox.Show("Invalid Worker Email. Please enter a valid email address.");
                return;
            }

            int workerAge;
            if (!int.TryParse(numericAge.Text, out workerAge) || workerAge <= 0)
            {
                MessageBox.Show("Invalid Worker Age. Please enter a valid integer value greater than 0 for Worker Age.");
                return;
            }

            string workerCity = textBoxCity.Text;
            if (string.IsNullOrWhiteSpace(workerCity))
            {
                MessageBox.Show("Worker City is required. Please enter a valid Worker City.");
                return;
            }

            string workerPhone = textBoxPhone.Text;
            if (!IsValidPhone(workerPhone))
            {
                MessageBox.Show("Invalid Worker Phone. Please enter a valid phone number.");
                return;
            }

            connect.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO workers VALUES (@workerid, @workername, @workeremail, @workerage, @workercity, @workerphone, @workerjoindate)", connect);
            command1.Parameters.AddWithValue("@workerid", workerId);
            command1.Parameters.AddWithValue("@workername", workerName);
            command1.Parameters.AddWithValue("@workeremail", workerEmail);
            command1.Parameters.AddWithValue("@workerage", workerAge);
            command1.Parameters.AddWithValue("@workercity", workerCity);
            command1.Parameters.AddWithValue("@workerphone", workerPhone);
            command1.Parameters.AddWithValue("@workerjoindate", dateTimePicker.Value);
            command1.ExecuteNonQuery();

            connect.Close();
            MessageBox.Show("Worker added successfully!");
            buttonView_Click(sender, EventArgs.Empty);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int workerId;
            if (!int.TryParse(textBoxID.Text, out workerId))
            {
                MessageBox.Show("Invalid Worker ID. Please enter a valid integer value for Worker ID.");
                return;
            }

            if (!IsWorkerIdExists(workerId))
            {
                MessageBox.Show("Worker ID does not exist. Please enter a valid Worker ID.");
                return;
            }

            string workerName = textBoxName.Text;
            if (string.IsNullOrWhiteSpace(workerName))
            {
                MessageBox.Show("Worker Name is required. Please enter a valid Worker Name.");
                return;
            }

            string workerEmail = textBoxEmail.Text;
            if (!IsValidEmail(workerEmail))
            {
                MessageBox.Show("Invalid Worker Email. Please enter a valid email address.");
                return;
            }

            int workerAge;
            if (!int.TryParse(numericAge.Text, out workerAge) || workerAge <= 0)
            {
                MessageBox.Show("Invalid Worker Age. Please enter a valid integer value greater than 0 for Worker Age.");
                return;
            }

            string workerCity = textBoxCity.Text;
            if (string.IsNullOrWhiteSpace(workerCity))
            {
                MessageBox.Show("Worker City is required. Please enter a valid Worker City.");
                return;
            }

            string workerPhone = textBoxPhone.Text;
            if (!IsValidPhone(workerPhone))
            {
                MessageBox.Show("Invalid Worker Phone. Please enter a valid phone number.");
                return;
            }

            connect.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("UPDATE workers SET workername = @workername, workeremail = @workeremail, workerage = @workerage, workercity = @workercity, workerphone = @workerphone, workerjoindate = @workerjoindate WHERE workerid = @workerid", connect);
            command2.Parameters.AddWithValue("@workerid", workerId);
            command2.Parameters.AddWithValue("@workername", workerName);
            command2.Parameters.AddWithValue("@workeremail", workerEmail);
            command2.Parameters.AddWithValue("@workerage", workerAge);
            command2.Parameters.AddWithValue("@workercity", workerCity);
            command2.Parameters.AddWithValue("@workerphone", workerPhone);
            command2.Parameters.AddWithValue("@workerjoindate", dateTimePicker.Value);
            command2.ExecuteNonQuery();

            connect.Close();
            MessageBox.Show("Worker updated successfully!");
            buttonView_Click(sender, EventArgs.Empty);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            dataView.Visible = true;
            string query = "SELECT * FROM workers ORDER BY workerid ASC";
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connect);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connect.Close();
            dataView.DataSource = ds.Tables[0];
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int workerId;
            if (!int.TryParse(textBoxID.Text, out workerId))
            {
                MessageBox.Show("Invalid Worker ID. Please enter a valid integer value for Worker ID.");
                return;
            }

            if (!IsWorkerIdExists(workerId))
            {
                MessageBox.Show("Worker ID does not exist. Please enter a valid Worker ID.");
                return;
            }

            connect.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("DELETE FROM workers WHERE workerid = @workerid", connect);
            command3.Parameters.AddWithValue("@workerid", workerId);
            command3.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Worker deleted successfully!");
            buttonView_Click(sender, EventArgs.Empty);
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

        private void WorkerForm_Load(object sender, EventArgs e)
        {

        }

        private bool IsWorkerIdExists(int workerId)
        {
            connect.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM workers WHERE workerid = @workerid", connect);
            command.Parameters.AddWithValue("@workerid", workerId);
            int count = Convert.ToInt32(command.ExecuteScalar());
            connect.Close();
            return count > 0;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            // Implement your phone number validation logic here
            // Example: check if the phone number is in the correct format, length, etc.
            return true;
        }
    }
}
