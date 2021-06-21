
namespace Sercamcom
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SalesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SerCamComName = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.CloseBu = new System.Windows.Forms.Button();
            this.SalesButton_Shadow = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.ProductsButton_Shadow = new System.Windows.Forms.PictureBox();
            this.Big_Lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesButton_Shadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsButton_Shadow)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesButton
            // 
            this.SalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.SalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SalesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.SalesButton.FlatAppearance.BorderSize = 0;
            this.SalesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.SalesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalesButton.Font = new System.Drawing.Font("Candara", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SalesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.SalesButton.Location = new System.Drawing.Point(105, 291);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(450, 125);
            this.SalesButton.TabIndex = 1;
            this.SalesButton.Text = "Продажи";
            this.SalesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SalesButton.UseVisualStyleBackColor = false;
            this.SalesButton.MouseEnter += new System.EventHandler(this.SalesButton_MouseEnter);
            this.SalesButton.MouseLeave += new System.EventHandler(this.SalesButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::Sercamcom.Properties.Resources.logoъ;
            this.pictureBox1.InitialImage = global::Sercamcom.Properties.Resources.logoъ;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 36);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBar_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlBar_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlBar_MouseUp);
            // 
            // SerCamComName
            // 
            this.SerCamComName.AutoSize = true;
            this.SerCamComName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.SerCamComName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerCamComName.Font = new System.Drawing.Font("Candara", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SerCamComName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.SerCamComName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SerCamComName.Location = new System.Drawing.Point(12, 0);
            this.SerCamComName.Name = "SerCamComName";
            this.SerCamComName.Size = new System.Drawing.Size(179, 35);
            this.SerCamComName.TabIndex = 4;
            this.SerCamComName.Text = "   SerCamCom";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.CloseButton.BackgroundImage = global::Sercamcom.Properties.Resources.remove_symbol;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(1164, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CloseBu
            // 
            this.CloseBu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.CloseBu.BackgroundImage = global::Sercamcom.Properties.Resources.remove_symbol;
            this.CloseBu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBu.FlatAppearance.BorderSize = 0;
            this.CloseBu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBu.Location = new System.Drawing.Point(1950, 62);
            this.CloseBu.Name = "CloseBu";
            this.CloseBu.Size = new System.Drawing.Size(50, 50);
            this.CloseBu.TabIndex = 2;
            this.CloseBu.UseVisualStyleBackColor = false;
            this.CloseBu.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SalesButton_Shadow
            // 
            this.SalesButton_Shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.SalesButton_Shadow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalesButton_Shadow.Location = new System.Drawing.Point(95, 300);
            this.SalesButton_Shadow.Name = "SalesButton_Shadow";
            this.SalesButton_Shadow.Size = new System.Drawing.Size(450, 125);
            this.SalesButton_Shadow.TabIndex = 6;
            this.SalesButton_Shadow.TabStop = false;
            this.SalesButton_Shadow.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Sercamcom.Properties.Resources.logoъ;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(628, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(560, 503);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // ProductsButton
            // 
            this.ProductsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.ProductsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProductsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.ProductsButton.FlatAppearance.BorderSize = 0;
            this.ProductsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.ProductsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductsButton.Font = new System.Drawing.Font("Candara", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ProductsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ProductsButton.Location = new System.Drawing.Point(105, 452);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(450, 125);
            this.ProductsButton.TabIndex = 8;
            this.ProductsButton.Text = "Товары";
            this.ProductsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ProductsButton.UseVisualStyleBackColor = false;
            this.ProductsButton.MouseEnter += new System.EventHandler(this.ProductsButton_MouseEnter);
            this.ProductsButton.MouseLeave += new System.EventHandler(this.ProductsButton_MouseLeave);
            // 
            // ProductsButton_Shadow
            // 
            this.ProductsButton_Shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.ProductsButton_Shadow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProductsButton_Shadow.Location = new System.Drawing.Point(95, 461);
            this.ProductsButton_Shadow.Name = "ProductsButton_Shadow";
            this.ProductsButton_Shadow.Size = new System.Drawing.Size(450, 125);
            this.ProductsButton_Shadow.TabIndex = 9;
            this.ProductsButton_Shadow.TabStop = false;
            this.ProductsButton_Shadow.Visible = false;
            // 
            // Big_Lable1
            // 
            this.Big_Lable1.AutoSize = true;
            this.Big_Lable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Big_Lable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Big_Lable1.Font = new System.Drawing.Font("Candara", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Big_Lable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.Big_Lable1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Big_Lable1.Location = new System.Drawing.Point(163, 131);
            this.Big_Lable1.Name = "Big_Lable1";
            this.Big_Lable1.Size = new System.Drawing.Size(345, 86);
            this.Big_Lable1.TabIndex = 10;
            this.Big_Lable1.Text = "Выберите";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Candara", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(132, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 86);
            this.label1.TabIndex = 11;
            this.label1.Text = "справочник";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.Big_Lable1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsButton);
            this.Controls.Add(this.ProductsButton_Shadow);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SerCamComName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseBu);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.SalesButton_Shadow);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "MainForm";
            this.Text = "SerCamCom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesButton_Shadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsButton_Shadow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SerCamComName;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Button CloseBu;
        private System.Windows.Forms.PictureBox SalesButton_Shadow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.PictureBox ProductsButton_Shadow;
        private System.Windows.Forms.Label Big_Lable1;
        private System.Windows.Forms.Label label1;
    }
}

