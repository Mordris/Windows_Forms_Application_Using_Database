using System;
using System.Windows.Forms;

namespace DBMSProjectApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            // Start the form maximized
            WindowState = FormWindowState.Maximized;
        }

        public void LoadForm(object form)
        {
            if (this.BasicPanel.Controls.Count > 0)
            {
                this.BasicPanel.Controls.RemoveAt(0);
            }

            if (form is Form f)
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.BasicPanel.Controls.Add(f);
                this.BasicPanel.Tag = f;
                f.Show();
            }
        }

        private void labelheader_Click(object sender, EventArgs e)
        {
            BasicPanel.Controls.Clear();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            LoadForm(new CustomerForm());
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            LoadForm(new OrderForm());
        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {
            LoadForm(new WorkerForm());
        }

        private void buttonDealer_Click(object sender, EventArgs e)
        {
            LoadForm(new DealerForm());
        }

        private void buttonTool_Click(object sender, EventArgs e)
        {
            LoadForm(new ToolForm());
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            LoadForm(new ManagerForm());
        }

        private void buttonDataStat_Click(object sender, EventArgs e)
        {
            LoadForm(new StatisticsForm());
        }

    }
}
