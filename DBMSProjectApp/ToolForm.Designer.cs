namespace DBMSProjectApp
{
    partial class ToolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolForm));
            this.dataView = new System.Windows.Forms.DataGridView();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDID = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelDID = new System.Windows.Forms.Label();
            this.numericCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(354, 29);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(1178, 715);
            this.dataView.TabIndex = 35;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelID.Location = new System.Drawing.Point(20, 100);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 20);
            this.labelID.TabIndex = 36;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelName.Location = new System.Drawing.Point(20, 140);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 20);
            this.labelName.TabIndex = 37;
            this.labelName.Text = "Name";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(20, 260);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 40);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.HotPink;
            this.buttonClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.buttonClear.Location = new System.Drawing.Point(120, 260);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 40);
            this.buttonClear.TabIndex = 40;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.buttonView.Location = new System.Drawing.Point(220, 260);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(85, 40);
            this.buttonView.TabIndex = 41;
            this.buttonView.Text = "VIEW";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Turquoise;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.5F);
            this.buttonUpdate.Location = new System.Drawing.Point(20, 310);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 40);
            this.buttonUpdate.TabIndex = 42;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.5F);
            this.buttonDelete.Location = new System.Drawing.Point(120, 310);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 40);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(120, 100);
            this.textBoxID.MaxLength = 10;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(180, 27);
            this.textBoxID.TabIndex = 44;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 140);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 27);
            this.textBoxName.TabIndex = 45;
            // 
            // textBoxDID
            // 
            this.textBoxDID.Location = new System.Drawing.Point(120, 220);
            this.textBoxDID.MaxLength = 10;
            this.textBoxDID.Name = "textBoxDID";
            this.textBoxDID.Size = new System.Drawing.Size(180, 27);
            this.textBoxDID.TabIndex = 47;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelCount.Location = new System.Drawing.Point(20, 180);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(58, 20);
            this.labelCount.TabIndex = 38;
            this.labelCount.Text = "Count";
            // 
            // labelDID
            // 
            this.labelDID.AutoSize = true;
            this.labelDID.BackColor = System.Drawing.Color.Transparent;
            this.labelDID.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelDID.Location = new System.Drawing.Point(20, 220);
            this.labelDID.Name = "labelDID";
            this.labelDID.Size = new System.Drawing.Size(86, 20);
            this.labelDID.TabIndex = 48;
            this.labelDID.Text = "Dealer ID";
            // 
            // numericCount
            // 
            this.numericCount.Location = new System.Drawing.Point(120, 180);
            this.numericCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericCount.Name = "numericCount";
            this.numericCount.Size = new System.Drawing.Size(120, 27);
            this.numericCount.TabIndex = 46;
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1532, 743);
            this.Controls.Add(this.numericCount);
            this.Controls.Add(this.labelDID);
            this.Controls.Add(this.textBoxDID);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataView);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToolForm";
            this.Text = "ToolForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDID;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelDID;
        private System.Windows.Forms.NumericUpDown numericCount;
    }
}