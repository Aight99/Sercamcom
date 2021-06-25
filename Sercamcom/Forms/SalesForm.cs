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
    public partial class SalesForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private MainForm linkToThePast;
        public SalesForm(MainForm link)
        {
            this.linkToThePast = link;
            InitializeComponent();
        }

        // Borderless Cons
        private void CloseButton_Click(object sender, EventArgs e)
        {
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
        private void HomeButton_MouseEnter(object sender, EventArgs e)
        {
            HomeButton_Shadow.Visible = true;
        }
        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            HomeButton_Shadow.Visible = false;
        }
        private void RefreshButton_MouseEnter(object sender, EventArgs e)
        {
            RefreshButton_Shadow.Visible = true;
        }
        private void RefreshButton_MouseLeave(object sender, EventArgs e)
        {
            RefreshButton_Shadow.Visible = false;
        }
        private void SearchButton_MouseEnter(object sender, EventArgs e)
        {
            SearchButton_Shadow.Visible = true;
        }
        private void SearchButton_MouseLeave(object sender, EventArgs e)
        {
            SearchButton_Shadow.Visible = false;
        }
        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton_Shadow.Visible = true;
        }
        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton_Shadow.Visible = false;
        }
        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton_Shadow.Visible = true;
        }
        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton_Shadow.Visible = false;
        }
        private void SaveButton_MouseEnter(object sender, EventArgs e)
        {
            SaveButton_Shadow.Visible = true;
        }
        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            SaveButton_Shadow.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            linkToThePast.Show();
            this.Close();
        }
    }
}
