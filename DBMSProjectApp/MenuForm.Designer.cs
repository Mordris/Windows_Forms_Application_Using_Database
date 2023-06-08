namespace DBMSProjectApp
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.labelheader = new System.Windows.Forms.Label();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.BasicPanel = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonWorker = new System.Windows.Forms.Button();
            this.buttonDealer = new System.Windows.Forms.Button();
            this.buttonTool = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonDataStat = new System.Windows.Forms.Button();
            this.BasicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelheader
            // 
            this.labelheader.AutoSize = true;
            this.labelheader.BackColor = System.Drawing.Color.Transparent;
            this.labelheader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.labelheader.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelheader.Location = new System.Drawing.Point(13, 19);
            this.labelheader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelheader.Name = "labelheader";
            this.labelheader.Size = new System.Drawing.Size(152, 39);
            this.labelheader.TabIndex = 0;
            this.labelheader.Text = "Bahçem";
            this.labelheader.Click += new System.EventHandler(this.labelheader_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonCustomer.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonCustomer.Location = new System.Drawing.Point(200, 30);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(140, 70);
            this.buttonCustomer.TabIndex = 1;
            this.buttonCustomer.Text = "Customer Informations";
            this.buttonCustomer.UseVisualStyleBackColor = false;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // BasicPanel
            // 
            this.BasicPanel.BackColor = System.Drawing.Color.Transparent;
            this.BasicPanel.Controls.Add(this.labelWelcome);
            this.BasicPanel.Location = new System.Drawing.Point(-1, 106);
            this.BasicPanel.Name = "BasicPanel";
            this.BasicPanel.Size = new System.Drawing.Size(1543, 645);
            this.BasicPanel.TabIndex = 2;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelWelcome.Location = new System.Drawing.Point(600, 220);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(385, 77);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "WELCOME";
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonOrder.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonOrder.Location = new System.Drawing.Point(380, 30);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(140, 70);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Order Informations";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonWorker
            // 
            this.buttonWorker.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonWorker.Location = new System.Drawing.Point(560, 30);
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.Size = new System.Drawing.Size(140, 70);
            this.buttonWorker.TabIndex = 3;
            this.buttonWorker.Text = "Worker Informations";
            this.buttonWorker.UseVisualStyleBackColor = false;
            this.buttonWorker.Click += new System.EventHandler(this.buttonWorker_Click);
            // 
            // buttonDealer
            // 
            this.buttonDealer.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonDealer.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDealer.Location = new System.Drawing.Point(740, 30);
            this.buttonDealer.Name = "buttonDealer";
            this.buttonDealer.Size = new System.Drawing.Size(140, 70);
            this.buttonDealer.TabIndex = 4;
            this.buttonDealer.Text = "Dealer Informations";
            this.buttonDealer.UseVisualStyleBackColor = false;
            this.buttonDealer.Click += new System.EventHandler(this.buttonDealer_Click);
            // 
            // buttonTool
            // 
            this.buttonTool.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonTool.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonTool.Location = new System.Drawing.Point(920, 30);
            this.buttonTool.Name = "buttonTool";
            this.buttonTool.Size = new System.Drawing.Size(140, 70);
            this.buttonTool.TabIndex = 5;
            this.buttonTool.Text = "Tool Informations";
            this.buttonTool.UseVisualStyleBackColor = false;
            this.buttonTool.Click += new System.EventHandler(this.buttonTool_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonManager.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonManager.Location = new System.Drawing.Point(1100, 30);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(140, 70);
            this.buttonManager.TabIndex = 6;
            this.buttonManager.Text = "Manager Informations";
            this.buttonManager.UseVisualStyleBackColor = false;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // buttonDataStat
            // 
            this.buttonDataStat.BackColor = System.Drawing.Color.HotPink;
            this.buttonDataStat.ForeColor = System.Drawing.Color.Black;
            this.buttonDataStat.Location = new System.Drawing.Point(1380, 30);
            this.buttonDataStat.Name = "buttonDataStat";
            this.buttonDataStat.Size = new System.Drawing.Size(140, 70);
            this.buttonDataStat.TabIndex = 7;
            this.buttonDataStat.Text = "Statistiscs";
            this.buttonDataStat.UseVisualStyleBackColor = false;
            this.buttonDataStat.Click += new System.EventHandler(this.buttonDataStat_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1538, 750);
            this.Controls.Add(this.buttonDataStat);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.BasicPanel);
            this.Controls.Add(this.buttonTool);
            this.Controls.Add(this.labelheader);
            this.Controls.Add(this.buttonDealer);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonWorker);
            this.Controls.Add(this.buttonOrder);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.BasicPanel.ResumeLayout(false);
            this.BasicPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelheader;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Panel BasicPanel;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonTool;
        private System.Windows.Forms.Button buttonDealer;
        private System.Windows.Forms.Button buttonWorker;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonDataStat;
        private System.Windows.Forms.Label labelWelcome;
    }
}

