namespace DBMSProjectApp
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.labelOID = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxOID = new System.Windows.Forms.TextBox();
            this.textBoxCID = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxWID = new System.Windows.Forms.TextBox();
            this.textBoxOCtgID = new System.Windows.Forms.TextBox();
            this.textBoxIID = new System.Windows.Forms.TextBox();
            this.textBoxRID = new System.Windows.Forms.TextBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOID
            // 
            this.labelOID.AutoSize = true;
            this.labelOID.BackColor = System.Drawing.Color.Transparent;
            this.labelOID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelOID.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelOID.Location = new System.Drawing.Point(20, 100);
            this.labelOID.Name = "labelOID";
            this.labelOID.Size = new System.Drawing.Size(79, 20);
            this.labelOID.TabIndex = 26;
            this.labelOID.Text = "Order ID";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelDate.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelDate.Location = new System.Drawing.Point(20, 180);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(100, 20);
            this.labelDate.TabIndex = 27;
            this.labelDate.Text = "Order Date";
            // 
            // labelCID
            // 
            this.labelCID.AutoSize = true;
            this.labelCID.BackColor = System.Drawing.Color.Transparent;
            this.labelCID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelCID.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelCID.Location = new System.Drawing.Point(20, 140);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(111, 20);
            this.labelCID.TabIndex = 28;
            this.labelCID.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(20, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(20, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Worker ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(17, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Order Category ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label6.ForeColor = System.Drawing.Color.GreenYellow;
            this.label6.Location = new System.Drawing.Point(20, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Image ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label7.ForeColor = System.Drawing.Color.GreenYellow;
            this.label7.Location = new System.Drawing.Point(20, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Receipt ID";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(20, 420);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 40);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.HotPink;
            this.buttonClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.buttonClear.Location = new System.Drawing.Point(120, 420);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 40);
            this.buttonClear.TabIndex = 36;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.buttonView.Location = new System.Drawing.Point(220, 420);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(85, 40);
            this.buttonView.TabIndex = 37;
            this.buttonView.Text = "VIEW";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Turquoise;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.5F);
            this.buttonUpdate.Location = new System.Drawing.Point(20, 470);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 40);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.5F);
            this.buttonDelete.Location = new System.Drawing.Point(120, 470);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 40);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxOID
            // 
            this.textBoxOID.Location = new System.Drawing.Point(172, 100);
            this.textBoxOID.MaxLength = 10;
            this.textBoxOID.Name = "textBoxOID";
            this.textBoxOID.Size = new System.Drawing.Size(176, 22);
            this.textBoxOID.TabIndex = 40;
            // 
            // textBoxCID
            // 
            this.textBoxCID.Location = new System.Drawing.Point(172, 140);
            this.textBoxCID.MaxLength = 10;
            this.textBoxCID.Name = "textBoxCID";
            this.textBoxCID.Size = new System.Drawing.Size(176, 22);
            this.textBoxCID.TabIndex = 41;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(172, 220);
            this.textBoxPrice.MaxLength = 5;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(176, 22);
            this.textBoxPrice.TabIndex = 42;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(148, 180);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 43;
            // 
            // textBoxWID
            // 
            this.textBoxWID.Location = new System.Drawing.Point(172, 260);
            this.textBoxWID.MaxLength = 10;
            this.textBoxWID.Name = "textBoxWID";
            this.textBoxWID.Size = new System.Drawing.Size(176, 22);
            this.textBoxWID.TabIndex = 44;
            // 
            // textBoxOCtgID
            // 
            this.textBoxOCtgID.Location = new System.Drawing.Point(172, 298);
            this.textBoxOCtgID.MaxLength = 10;
            this.textBoxOCtgID.Name = "textBoxOCtgID";
            this.textBoxOCtgID.Size = new System.Drawing.Size(176, 22);
            this.textBoxOCtgID.TabIndex = 45;
            // 
            // textBoxIID
            // 
            this.textBoxIID.Location = new System.Drawing.Point(172, 338);
            this.textBoxIID.MaxLength = 10;
            this.textBoxIID.Name = "textBoxIID";
            this.textBoxIID.Size = new System.Drawing.Size(176, 22);
            this.textBoxIID.TabIndex = 46;
            // 
            // textBoxRID
            // 
            this.textBoxRID.Location = new System.Drawing.Point(172, 378);
            this.textBoxRID.MaxLength = 10;
            this.textBoxRID.Name = "textBoxRID";
            this.textBoxRID.Size = new System.Drawing.Size(176, 22);
            this.textBoxRID.TabIndex = 47;
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(354, 29);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(1178, 715);
            this.dataView.TabIndex = 34;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1532, 743);
            this.Controls.Add(this.textBoxRID);
            this.Controls.Add(this.textBoxIID);
            this.Controls.Add(this.textBoxOCtgID);
            this.Controls.Add(this.textBoxWID);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCID);
            this.Controls.Add(this.textBoxOID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCID);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelOID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOID;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxOID;
        private System.Windows.Forms.TextBox textBoxCID;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox textBoxWID;
        private System.Windows.Forms.TextBox textBoxOCtgID;
        private System.Windows.Forms.TextBox textBoxIID;
        private System.Windows.Forms.TextBox textBoxRID;
        private System.Windows.Forms.DataGridView dataView;
    }
}