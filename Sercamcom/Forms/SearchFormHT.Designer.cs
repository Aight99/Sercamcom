
namespace Sercamcom
{
    partial class SearchFormHT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFormHT));
            this.Search = new System.Windows.Forms.Button();
            this.Search_Shadow = new System.Windows.Forms.PictureBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Cancel_Shadow = new System.Windows.Forms.PictureBox();
            this.Big_Lable1 = new System.Windows.Forms.Label();
            this.productBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hash1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hash2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Shadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel_Shadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Search.Location = new System.Drawing.Point(531, 527);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(169, 58);
            this.Search.TabIndex = 10;
            this.Search.Text = "Искать";
            this.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.MouseEnter += new System.EventHandler(this.Search_MouseEnter);
            this.Search.MouseLeave += new System.EventHandler(this.Search_MouseLeave);
            // 
            // Search_Shadow
            // 
            this.Search_Shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.Search_Shadow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search_Shadow.Location = new System.Drawing.Point(524, 532);
            this.Search_Shadow.Name = "Search_Shadow";
            this.Search_Shadow.Size = new System.Drawing.Size(169, 58);
            this.Search_Shadow.TabIndex = 11;
            this.Search_Shadow.TabStop = false;
            this.Search_Shadow.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Cancel.Location = new System.Drawing.Point(346, 527);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(169, 58);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Отмена";
            this.Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.MouseEnter += new System.EventHandler(this.Cancel_MouseEnter);
            this.Cancel.MouseLeave += new System.EventHandler(this.Cancel_MouseLeave);
            // 
            // Cancel_Shadow
            // 
            this.Cancel_Shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.Cancel_Shadow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cancel_Shadow.Location = new System.Drawing.Point(339, 532);
            this.Cancel_Shadow.Name = "Cancel_Shadow";
            this.Cancel_Shadow.Size = new System.Drawing.Size(169, 58);
            this.Cancel_Shadow.TabIndex = 13;
            this.Cancel_Shadow.TabStop = false;
            this.Cancel_Shadow.Visible = false;
            // 
            // Big_Lable1
            // 
            this.Big_Lable1.AutoSize = true;
            this.Big_Lable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Big_Lable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Big_Lable1.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Big_Lable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.Big_Lable1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Big_Lable1.Location = new System.Drawing.Point(12, 9);
            this.Big_Lable1.Name = "Big_Lable1";
            this.Big_Lable1.Size = new System.Drawing.Size(206, 78);
            this.Big_Lable1.TabIndex = 14;
            this.Big_Lable1.Text = "Поиск";
            // 
            // productBox
            // 
            this.productBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.productBox.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productBox.Location = new System.Drawing.Point(340, 90);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(295, 53);
            this.productBox.TabIndex = 15;
            this.productBox.MouseEnter += new System.EventHandler(this.text2_MouseEnter);
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.loginBox.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(25, 90);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(295, 53);
            this.loginBox.TabIndex = 16;
            this.loginBox.MouseEnter += new System.EventHandler(this.text1_MouseEnter);
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Product,
            this.Hash1,
            this.Hash2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.GridColor = System.Drawing.Color.Black;
            this.dataGrid.Location = new System.Drawing.Point(25, 166);
            this.dataGrid.Name = "dataGrid";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Candara", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.Size = new System.Drawing.Size(675, 355);
            this.dataGrid.TabIndex = 21;
            // 
            // Login
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.Login.DefaultCellStyle = dataGridViewCellStyle3;
            this.Login.HeaderText = "Логин";
            this.Login.MinimumWidth = 6;
            this.Login.Name = "Login";
            this.Login.Width = 200;
            // 
            // Product
            // 
            this.Product.HeaderText = "Товар";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.Width = 200;
            // 
            // Hash1
            // 
            this.Hash1.HeaderText = "Хеш 1";
            this.Hash1.MinimumWidth = 6;
            this.Hash1.Name = "Hash1";
            this.Hash1.Width = 110;
            // 
            // Hash2
            // 
            this.Hash2.HeaderText = "Хеш 2";
            this.Hash2.MinimumWidth = 6;
            this.Hash2.Name = "Hash2";
            this.Hash2.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(346, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "Название товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(31, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Логин";
            // 
            // SearchFormHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(720, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.Big_Lable1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Cancel_Shadow);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_Shadow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchFormHT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchFormHT";
            ((System.ComponentModel.ISupportInitialize)(this.Search_Shadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel_Shadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.PictureBox Search_Shadow;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.PictureBox Cancel_Shadow;
        private System.Windows.Forms.Label Big_Lable1;
        private System.Windows.Forms.TextBox productBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}