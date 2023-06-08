using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBMSProjectApp
{
    public partial class StatisticsForm : Form
    {
        private readonly string connectionString = "Server=localHost;port=5432;UserId=postgres;" +
            "password=123456;database=BahcemDataBase";

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "SELECT datastats.\"totalcustomer\", datastats.\"totalorder\", datastats.\"totaldealer\", datastats.\"totalworker\" FROM datastats";
                    using (NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connect))
                    {
                        DataSet ds = new DataSet();
                        adapt.Fill(ds);
                        dataView.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
