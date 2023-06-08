namespace DBMSProjectApp
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.dataView = new System.Windows.Forms.DataGridView();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDID = new System.Windows.Forms.Label();
            this.textBoxDID = new System.Windows.Forms.TextBox();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(354, 29);
            this.dataView.Margin = new System.Windows.Forms.Padding(4);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(1179, 715);
            this.dataView.TabIndex = 36;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelID.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelID.Location = new System.Drawing.Point(20, 100);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 20);
            this.labelID.TabIndex = 37;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelName.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelName.Location = new System.Drawing.Point(20, 140);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 20);
            this.labelName.TabIndex = 38;
            this.labelName.Text = "Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelEmail.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelEmail.Location = new System.Drawing.Point(20, 180);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 20);
            this.labelEmail.TabIndex = 39;
            this.labelEmail.Text = "Email";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.Color.Transparent;
            this.labelAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelAge.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelAge.Location = new System.Drawing.Point(20, 220);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(42, 20);
            this.labelAge.TabIndex = 40;
            this.labelAge.Text = "Age";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelCity.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelCity.Location = new System.Drawing.Point(20, 260);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(42, 20);
            this.labelCity.TabIndex = 41;
            this.labelCity.Text = "City";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelPhone.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelPhone.Location = new System.Drawing.Point(20, 300);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(60, 20);
            this.labelPhone.TabIndex = 42;
            this.labelPhone.Text = "Phone";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelDate.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelDate.Location = new System.Drawing.Point(20, 340);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(87, 20);
            this.labelDate.TabIndex = 43;
            this.labelDate.Text = "Join Date";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(20, 450);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 40);
            this.buttonAdd.TabIndex = 44;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.HotPink;
            this.buttonClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.buttonClear.Location = new System.Drawing.Point(120, 450);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 40);
            this.buttonClear.TabIndex = 45;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.buttonView.Location = new System.Drawing.Point(220, 450);
            this.buttonView.Margin = new System.Windows.Forms.Padding(4);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(85, 40);
            this.buttonView.TabIndex = 46;
            this.buttonView.Text = "VIEW";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Turquoise;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.5F);
            this.buttonUpdate.Location = new System.Drawing.Point(20, 500);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 40);
            this.buttonUpdate.TabIndex = 47;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.5F);
            this.buttonDelete.Location = new System.Drawing.Point(120, 500);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 40);
            this.buttonDelete.TabIndex = 48;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(120, 100);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.MaxLength = 10;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(200, 27);
            this.textBoxID.TabIndex = 49;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 140);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 27);
            this.textBoxName.TabIndex = 50;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(120, 180);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 27);
            this.textBoxEmail.TabIndex = 51;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(120, 260);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCity.MaxLength = 20;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 27);
            this.textBoxCity.TabIndex = 53;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(120, 300);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhone.MaxLength = 20;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 27);
            this.textBoxPhone.TabIndex = 54;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(120, 340);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 27);
            this.datePicker.TabIndex = 56;
            // 
            // labelDID
            // 
            this.labelDID.AutoSize = true;
            this.labelDID.BackColor = System.Drawing.Color.Transparent;
            this.labelDID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.labelDID.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelDID.Location = new System.Drawing.Point(20, 380);
            this.labelDID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDID.Name = "labelDID";
            this.labelDID.Size = new System.Drawing.Size(86, 20);
            this.labelDID.TabIndex = 57;
            this.labelDID.Text = "Dealer ID";
            // 
            // textBoxDID
            // 
            this.textBoxDID.Location = new System.Drawing.Point(120, 380);
            this.textBoxDID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDID.MaxLength = 10;
            this.textBoxDID.Name = "textBoxDID";
            this.textBoxDID.Size = new System.Drawing.Size(200, 27);
            this.textBoxDID.TabIndex = 58;
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(120, 220);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(120, 27);
            this.numericAge.TabIndex = 52;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1532, 743);
            this.Controls.Add(this.numericAge);
            this.Controls.Add(this.textBoxDID);
            this.Controls.Add(this.labelDID);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataView);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label labelDID;
        private System.Windows.Forms.TextBox textBoxDID;
        private System.Windows.Forms.NumericUpDown numericAge;
    }
}