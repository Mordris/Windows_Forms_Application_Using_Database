using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBMSProjectApp
{
    public partial class OrderForm : Form
    {
        NpgsqlConnection connect = new NpgsqlConnection("Server=localhost;Port=5432;UserId=postgres;" +
            "Password=123456;Database=BahcemDataBase");

        public OrderForm()
        {
            InitializeComponent();
            dataView.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int orderId;

            // Check if Order ID is a valid integer
            if (!int.TryParse(textBoxOID.Text, out orderId))
            {
                MessageBox.Show("Invalid Order ID. Please enter a valid integer value for Order ID.");
                return;
            }

            // Check if the order ID already exists in the table
            if (IsOrderIdExists(orderId))
            {
                MessageBox.Show("Order ID already exists. Please enter a unique order ID.");
                return;
            }

            // Check if other input fields are valid
            int custId;
            if (!int.TryParse(textBoxCID.Text, out custId))
            {
                MessageBox.Show("Invalid Customer ID. Please enter a valid integer value for Customer ID.");
                return;
            }

            int orderPrice;
            if (!int.TryParse(textBoxPrice.Text, out orderPrice))
            {
                MessageBox.Show("Invalid Order Price. Please enter a valid integer value for Order Price.");
                return;
            }

            int workerId;
            if (!int.TryParse(textBoxWID.Text, out workerId))
            {
                MessageBox.Show("Invalid Worker ID. Please enter a valid integer value for Worker ID.");
                return;
            }

            int orderCategoryId;
            if (!int.TryParse(textBoxOCtgID.Text, out orderCategoryId))
            {
                MessageBox.Show("Invalid Order Category ID. Please enter a valid integer value for Order Category ID.");
                return;
            }

            int imageId;
            if (!int.TryParse(textBoxIID.Text, out imageId))
            {
                MessageBox.Show("Invalid Image ID. Please enter a valid integer value for Image ID.");
                return;
            }

            int receiptId;
            if (!int.TryParse(textBoxRID.Text, out receiptId))
            {
                MessageBox.Show("Invalid Receipt ID. Please enter a valid integer value for Receipt ID.");
                return;
            }

            connect.Open();

            // Insert the new order into the database
            NpgsqlCommand command1 = new NpgsqlCommand("insert into orders values(@orderid, @custid, @orderdate, @orderprice, @workerid, @ordercategoryid, @imageid, @receiptid)", connect);
            command1.Parameters.AddWithValue("@orderid", orderId);
            command1.Parameters.AddWithValue("@custid", custId);
            command1.Parameters.AddWithValue("@orderdate", datePicker.Value);
            command1.Parameters.AddWithValue("@orderprice", orderPrice);
            command1.Parameters.AddWithValue("@workerid", workerId);
            command1.Parameters.AddWithValue("@ordercategoryid", orderCategoryId);
            command1.Parameters.AddWithValue("@imageid", imageId);
            command1.Parameters.AddWithValue("@receiptid", receiptId);
            command1.ExecuteNonQuery();

            connect.Close();
            MessageBox.Show("Order added successfully!");
            buttonView_Click(sender, EventArgs.Empty);
        }


        private bool IsOrderIdExists(int orderId)
        {
            connect.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM orders WHERE \"orderid\" = @orderid", connect);
            command.Parameters.AddWithValue("@orderid", orderId);
            int count = Convert.ToInt32(command.ExecuteScalar());
            connect.Close();

            return count > 0;
        }


        private void buttonView_Click(object sender, EventArgs e)
        {
            try
            {
                dataView.Visible = true;
                string query = "SELECT orders.\"orderid\", orders.\"orderprice\", orders.\"orderdate\", customers.\"custname\", workers.\"workername\", " +
                    "ordercategories.\"ordercategoryname\", images.\"imageurl\", receipts.\"receiptaddress\", receipts.\"receiptpaid\" " +
                    "FROM orders " +
                    "LEFT JOIN customers ON orders.\"custid\" = customers.\"custid\" " +
                    "LEFT JOIN workers ON orders.\"workerid\" = workers.\"workerid\" " +
                    "LEFT JOIN ordercategories ON orders.\"ordercategoryid\" = ordercategories.\"ordercategoryid\" " +
                    "LEFT JOIN images ON orders.\"imageid\" = images.\"imageid\" " +
                    "LEFT JOIN receipts ON orders.\"receiptid\" = receipts.\"receiptid\"";
                NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connect);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                connect.Close();
                dataView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while retrieving orders: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                connect.Open();
                NpgsqlCommand command2 = new NpgsqlCommand("UPDATE orders SET \"custid\" = @custid, \"orderdate\" = @orderdate, " +
                    "\"orderprice\" = @orderprice, \"workerid\" = @workerid, \"ordercategoryid\" = @ordercategoryid, \"imageid\" = @imageid, \"receiptid\" = @receiptid " +
                    "WHERE \"orderid\" = @orderid", connect);
                command2.Parameters.AddWithValue("@orderid", int.Parse(textBoxOID.Text));
                command2.Parameters.AddWithValue("@custid", int.Parse(textBoxCID.Text));
                command2.Parameters.AddWithValue("@orderdate", datePicker.Value);
                command2.Parameters.AddWithValue("@orderprice", int.Parse(textBoxPrice.Text));
                command2.Parameters.AddWithValue("@workerid", int.Parse(textBoxWID.Text));
                command2.Parameters.AddWithValue("@ordercategoryid", int.Parse(textBoxOCtgID.Text));
                command2.Parameters.AddWithValue("@imageid", int.Parse(textBoxIID.Text));
                command2.Parameters.AddWithValue("@receiptid", int.Parse(textBoxRID.Text));
                command2.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Order updated successfully!");
                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while updating the order: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateOrderID())
                    return;

                connect.Open();
                NpgsqlCommand command3 = new NpgsqlCommand("DELETE FROM orders WHERE \"orderid\" = @orderid", connect);
                command3.Parameters.AddWithValue("@orderid", int.Parse(textBoxOID.Text));
                command3.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Order deleted successfully!");
                buttonView_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while deleting the order: " + ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOID.Text = string.Empty;
            textBoxCID.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxRID.Text = string.Empty;
            textBoxIID.Text = string.Empty;
            textBoxOCtgID.Text = string.Empty;
            textBoxWID.Text = string.Empty;
            datePicker.Value = DateTime.Now;
        }

        private bool ValidateInputs()
        {
            if (!ValidateOrderID() || !ValidateCustomerID() || !ValidatePrice() || !ValidateWorkerID() ||
                !ValidateOrderCategoryID() || !ValidateImageID() || !ValidateReceiptID())
            {
                return false;
            }

            return true;
        }

        private bool ValidateOrderID()
        {
            if (string.IsNullOrWhiteSpace(textBoxOID.Text))
            {
                ShowError("Order ID cannot be empty.");
                return false;
            }

            int orderID;
            if (!int.TryParse(textBoxOID.Text, out orderID))
            {
                ShowError("Invalid Order ID. Please enter a valid integer value.");
                return false;
            }

            // Check if the Order ID exists in the database
            bool orderExists = OrderExists(orderID);
            if (!orderExists)
            {
                ShowError("Order ID does not exist in the database.");
                return false;
            }

            return true;
        }

        private bool ValidateCustomerID()
        {
            if (string.IsNullOrWhiteSpace(textBoxCID.Text))
            {
                ShowError("Customer ID cannot be empty.");
                return false;
            }

            int customerID;
            if (!int.TryParse(textBoxCID.Text, out customerID))
            {
                ShowError("Invalid Customer ID. Please enter a valid integer value.");
                return false;
            }

            // Check if the Customer ID exists in the database
            bool customerExists = CustomerExists(customerID);
            if (!customerExists)
            {
                ShowError("Customer ID does not exist in the database.");
                return false;
            }

            return true;
        }

        private bool ValidatePrice()
        {
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                ShowError("Order Price cannot be empty.");
                return false;
            }

            decimal price;
            if (!decimal.TryParse(textBoxPrice.Text, out price))
            {
                ShowError("Invalid Order Price. Please enter a valid decimal value.");
                return false;
            }

            return true;
        }

        private bool ValidateWorkerID()
        {
            if (string.IsNullOrWhiteSpace(textBoxWID.Text))
            {
                ShowError("Worker ID cannot be empty.");
                return false;
            }

            int workerID;
            if (!int.TryParse(textBoxWID.Text, out workerID))
            {
                ShowError("Invalid Worker ID. Please enter a valid integer value.");
                return false;
            }

            // Check if the Worker ID exists in the database
            bool workerExists = WorkerExists(workerID);
            if (!workerExists)
            {
                ShowError("Worker ID does not exist in the database.");
                return false;
            }

            return true;
        }

        private bool ValidateOrderCategoryID()
        {
            if (string.IsNullOrWhiteSpace(textBoxOCtgID.Text))
            {
                ShowError("Order Category ID cannot be empty.");
                return false;
            }

            int orderCategoryID;
            if (!int.TryParse(textBoxOCtgID.Text, out orderCategoryID))
            {
                ShowError("Invalid Order Category ID. Please enter a valid integer value.");
                return false;
            }

            // Check if the Order Category ID exists in the database
            bool orderCategoryExists = OrderCategoryExists(orderCategoryID);
            if (!orderCategoryExists)
            {
                ShowError("Order Category ID does not exist in the database.");
                return false;
            }

            return true;
        }

        private bool ValidateImageID()
        {
            if (string.IsNullOrWhiteSpace(textBoxIID.Text))
            {
                ShowError("Image ID cannot be empty.");
                return false;
            }

            int imageID;
            if (!int.TryParse(textBoxIID.Text, out imageID))
            {
                ShowError("Invalid Image ID. Please enter a valid integer value.");
                return false;
            }

            // Check if the Image ID exists in the database
            bool imageExists = ImageExists(imageID);
            if (!imageExists)
            {
                ShowError("Image ID does not exist in the database.");
                return false;
            }

            return true;
        }

        private bool ValidateReceiptID()
        {
            if (string.IsNullOrWhiteSpace(textBoxRID.Text))
            {
                ShowError("Receipt ID cannot be empty.");
                return false;
            }

            int receiptID;
            if (!int.TryParse(textBoxRID.Text, out receiptID))
            {
                ShowError("Invalid Receipt ID. Please enter a valid integer value.");
                return false;
            }

            // Check if the Receipt ID exists in the database
            bool receiptExists = ReceiptExists(receiptID);
            if (!receiptExists)
            {
                ShowError("Receipt ID does not exist in the database.");
                return false;
            }

            return true;
        }

        private bool OrderExists(int orderID)
        {
            // Perform the necessary check to determine if the order exists in the database
            // Return true if the order exists, false otherwise
            // You can use a SELECT statement to check if the order exists in the orders table

            return false; // Placeholder, replace with actual implementation
        }

        private bool CustomerExists(int customerID)
        {
            // Perform the necessary check to determine if the customer exists in the database
            // Return true if the customer exists, false otherwise
            // You can use a SELECT statement to check if the customer exists in the customers table

            return false; // Placeholder, replace with actual implementation
        }

        private bool WorkerExists(int workerID)
        {
            // Perform the necessary check to determine if the worker exists in the database
            // Return true if the worker exists, false otherwise
            // You can use a SELECT statement to check if the worker exists in the workers table

            return false; // Placeholder, replace with actual implementation
        }

        private bool OrderCategoryExists(int orderCategoryID)
        {
            // Perform the necessary check to determine if the order category exists in the database
            // Return true if the order category exists, false otherwise
            // You can use a SELECT statement to check if the order category exists in the ordercategories table

            return false; // Placeholder, replace with actual implementation
        }

        private bool ImageExists(int imageID)
        {
            // Perform the necessary check to determine if the image exists in the database
            // Return true if the image exists, false otherwise
            // You can use a SELECT statement to check if the image exists in the images table

            return false; // Placeholder, replace with actual implementation
        }

        private bool ReceiptExists(int receiptID)
        {
            // Perform the necessary check to determine if the receipt exists in the database
            // Return true if the receipt exists, false otherwise
            // You can use a SELECT statement to check if the receipt exists in the receipts table

            return false; // Placeholder, replace with actual implementation
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
