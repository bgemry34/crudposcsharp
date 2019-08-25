namespace posincsharp
{
    partial class posmain
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
            this.createBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showProducts = new System.Windows.Forms.Button();
            this.showSales = new System.Windows.Forms.Button();
            this.showReceipts = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.Button();
            this.toSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(32, 40);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(32, 323);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(32, 113);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(32, 183);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(149, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 241);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // showProducts
            // 
            this.showProducts.BackColor = System.Drawing.Color.Fuchsia;
            this.showProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showProducts.ForeColor = System.Drawing.Color.White;
            this.showProducts.Location = new System.Drawing.Point(195, 11);
            this.showProducts.Name = "showProducts";
            this.showProducts.Size = new System.Drawing.Size(75, 23);
            this.showProducts.TabIndex = 5;
            this.showProducts.Text = "Products";
            this.showProducts.UseVisualStyleBackColor = false;
            this.showProducts.Click += new System.EventHandler(this.ShowProducts_Click);
            // 
            // showSales
            // 
            this.showSales.BackColor = System.Drawing.Color.Fuchsia;
            this.showSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSales.ForeColor = System.Drawing.Color.White;
            this.showSales.Location = new System.Drawing.Point(357, 11);
            this.showSales.Name = "showSales";
            this.showSales.Size = new System.Drawing.Size(75, 23);
            this.showSales.TabIndex = 6;
            this.showSales.Text = "Sales";
            this.showSales.UseVisualStyleBackColor = false;
            this.showSales.Click += new System.EventHandler(this.ShowSales_Click);
            // 
            // showReceipts
            // 
            this.showReceipts.BackColor = System.Drawing.Color.Fuchsia;
            this.showReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showReceipts.ForeColor = System.Drawing.Color.White;
            this.showReceipts.Location = new System.Drawing.Point(503, 12);
            this.showReceipts.Name = "showReceipts";
            this.showReceipts.Size = new System.Drawing.Size(75, 23);
            this.showReceipts.TabIndex = 7;
            this.showReceipts.Text = "Receipts";
            this.showReceipts.UseVisualStyleBackColor = false;
            this.showReceipts.Click += new System.EventHandler(this.ShowReceipts_Click);
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.Color.Fuchsia;
            this.logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logs.ForeColor = System.Drawing.Color.White;
            this.logs.Location = new System.Drawing.Point(651, 12);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(75, 23);
            this.logs.TabIndex = 8;
            this.logs.Text = "Log";
            this.logs.UseVisualStyleBackColor = false;
            this.logs.Click += new System.EventHandler(this.Logs_Click);
            // 
            // toSearch
            // 
            this.toSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.toSearch.Location = new System.Drawing.Point(137, 316);
            this.toSearch.Name = "toSearch";
            this.toSearch.Size = new System.Drawing.Size(251, 30);
            this.toSearch.TabIndex = 9;
            // 
            // posmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toSearch);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.showReceipts);
            this.Controls.Add(this.showSales);
            this.Controls.Add(this.showProducts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.createBtn);
            this.Name = "posmain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showProducts;
        private System.Windows.Forms.Button showSales;
        private System.Windows.Forms.Button showReceipts;
        private System.Windows.Forms.Button logs;
        private System.Windows.Forms.TextBox toSearch;
    }
}

