
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
            this.SalesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SerCamComName = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.CloseBu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesButton
            // 
            this.SalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.SalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SalesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.SalesButton.FlatAppearance.BorderSize = 15;
            this.SalesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.SalesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(55)))));
            this.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalesButton.Font = new System.Drawing.Font("Candara", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SalesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.SalesButton.Location = new System.Drawing.Point(140, 251);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(450, 125);
            this.SalesButton.TabIndex = 1;
            this.SalesButton.Text = "Продажи";
            this.SalesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SalesButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::Sercamcom.Properties.Resources.logoъ;
            this.pictureBox1.InitialImage = global::Sercamcom.Properties.Resources.logoъ;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 56);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SerCamComName
            // 
            this.SerCamComName.AutoSize = true;
            this.SerCamComName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.SerCamComName.Font = new System.Drawing.Font("Candara", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SerCamComName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.SerCamComName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SerCamComName.Location = new System.Drawing.Point(-9, 0);
            this.SerCamComName.Name = "SerCamComName";
            this.SerCamComName.Size = new System.Drawing.Size(269, 51);
            this.SerCamComName.TabIndex = 4;
            this.SerCamComName.Text = "   SerCamCom";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.CloseButton.BackgroundImage = global::Sercamcom.Properties.Resources.remove_symbol;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.Location = new System.Drawing.Point(1148, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SerCamComName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseBu);
            this.Controls.Add(this.SalesButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SerCamComName;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Button CloseBu;
    }
}

