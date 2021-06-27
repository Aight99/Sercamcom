using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sercamcom
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public MainForm()
        {
            InitializeComponent();
        }



        // Borderless Cons
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (!Databank.IsSaved)
            {
                var result = MessageBox.Show("Есть несохранённые измениня! Сохранить перед закрытием?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Databank.IsSaved = true;
                    Databank.HashTable.UpdateFile();
                    Databank.SalesTable.UpdateFile();
                    MessageBox.Show("Данные сохранены!", "Успех");
                }
            }
            Application.Exit();
        }
        private void ControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void ControlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void ControlBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        // Selection Effect
        private void SalesButton_MouseEnter(object sender, EventArgs e)
        {
            SalesButton_Shadow.Visible = true;
        }
        private void SalesButton_MouseLeave(object sender, EventArgs e)
        {
            SalesButton_Shadow.Visible = false;
        }
        private void ProductsButton_MouseEnter(object sender, EventArgs e)
        {
            this.ProductsButton_Shadow.Visible = true;
        }
        private void ProductsButton_MouseLeave(object sender, EventArgs e)
        {
            this.ProductsButton_Shadow.Visible = false;
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Мяу!", "Очень важное сообщение!");
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SalesForm saletScreen = new SalesForm(this);
            saletScreen.Show();
            this.Hide();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductForm productScreen = new ProductForm(this);
            productScreen.Show();
            this.Hide();
        }
    }
}
